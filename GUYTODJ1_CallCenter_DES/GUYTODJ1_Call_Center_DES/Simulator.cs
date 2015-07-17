using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: Simulator.cs                                                            ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||     The simulator is the central class which majority of the other classes commuincate with to drie the simulation and its     ||
 * ||     behaviour                                                                                                                  ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    
    class Simulator
    {
        public SimulationDisplayDataSubject simData { get; set; }
        public SimulationDisplayDataSubject statsData { get; set; }
        public Calendar MainCalandar { get; set; }
        public QueueManager theQueueManager { get; set; }
        public SalesManager TheSalesRepManager { get; set; }
        public SimulationEvent ActiveEvent { get; set; }
        public Stats stats { get; set; }
        public Dice theDice { get; set; }
        double SimulationTime;
        int callArrives = 1;
        
      
        //-------------------------------------------------------------------------------------------------
        // Simulator Constructor | Parameters: SimulationDisplayDataSubject, SimulationDisplayDataSubject
        //-------------------------------------------------------------------------------------------------      
        public Simulator(SimulationDisplayDataSubject simData , SimulationDisplayDataSubject statsData)
        {
            //Initalize varrriables / classes
            this.MainCalandar = new Calendar();
            this.theQueueManager = new QueueManager();
            this.TheSalesRepManager = new SalesManager();
            this.stats = new Stats();
            this.theDice = new Dice();          
            this.simData = simData;
            this.statsData = statsData;
        }//End Constructor

        //----------------------------------------------------------------------------------------
        // Run Simulator | Parameters : N/A
        //----------------------------------------------------------------------------------------
        public void RunSimulation()
        {
            //Get the next active evvent in the calandar
            ActiveEvent = MainCalandar.GetNextEvent();
            

            // While the end simulator event is not the next active event run the simulation
            while (!(ActiveEvent.eventType.Equals(eEventType.EndSimulation)))
            {  
                //Update the simulators clock
                UpdateSimulationClock();
                //Get the active entity using the active event
                Entity activeEntity = ActiveEvent.EventEntity;

                //If the active event has the event type of call arrive enter the statment and process the call
                if (ActiveEvent.eventType.Equals(eEventType.CallArrive))
                {
                    //increment the call arrivals in the stats class
                    stats.CallsToSystem++;

                    //Process the call arvial
                    ProcessCallArrive(activeEntity);   
                 
                }//end if

                //If the active event has the event type of Switch Complete enter the statment and process the call
                if (ActiveEvent.eventType.Equals(eEventType.SwitchComplete))
                {
                    //Process the call 
                    ProcessIRV(activeEntity);

                }//end if

                //If the active event has the event type of processing Complete enter the statment and process the call
                if (ActiveEvent.eventType.Equals(eEventType.ProcessingComplete))
                {
                    //run the method to complete the call 
                    ProcessCompleteService(activeEntity);

                }//end if      
         
                ActiveEvent = MainCalandar.GetNextEvent();

                //update the system stats passing in thecurrent state of the simulator
                stats.UpdateSystemStats(this);

                //update the simulation data that the observers need to know passing in thecurrent state of the simulator
                simData.NotifyObserver(this);
                Thread.Sleep(GlobalParameters.SPEED_INTERVAL / GlobalParameters.SPEED);
               
            }//end while

            //Compute Summaries off all the stats recorded 
            stats.ComputeSummaries();

            //update the stats data that the observers (StatsDataDisplayObserver) need to know passing in thecurrent state of the simulator
            statsData.NotifyObserver(this);                                                                                                                                                                                                                                                                      
        }//End Method

        //----------------------------------------------------------------------------------------
        // Process Call Arrive | Parameters : Entity
        //----------------------------------------------------------------------------------------
        public void ProcessCallArrive(Entity activeEntity)
        {
          
            //if the max that can be on hold hasn't been reached.....
            if (theQueueManager.TotalQueueLength() < GlobalParameters.MAX_ON_HOLD)//
            {
                //...Update its start time to the current simulation time 
                activeEntity.StartSystemTime = SimulationTime;
                //...calc wait at switch time
                double waitIRVInterval = (theDice.diceRoll() * GlobalParameters.IVR_DELAY)*GlobalParameters.SEC_IN_MIN;
                double completIRVTime = SimulationTime + waitIRVInterval;

                //...Create the new event taking in the entity and Add the new event to the calandar
                SimulationEvent newCompleteSwitcheEvent = new SimulationEvent(activeEntity, eEventType.SwitchComplete, completIRVTime);
                MainCalandar.AddEvent(newCompleteSwitcheEvent);
            }
            else// if the max that can be on hold has been reashed or surpassed then...
            {
                //...increment the hangup count
                stats.HangUps++;
            }//End If

            callArrives++;
            //Compute next arrival of and entity            
            Entity nextEntity = new Entity(callArrives);
            double nextArivalInterval = (theDice.diceRoll() * GlobalParameters.CALL_ARRIVAL_RATE) * GlobalParameters.SEC_IN_MIN;
            double nextArrivalTime = SimulationTime + nextArivalInterval;

            //Add event to callander for next arrival
            SimulationEvent newArrivalEvent = new SimulationEvent(nextEntity, eEventType.CallArrive,nextArrivalTime);
            MainCalandar.AddEvent(newArrivalEvent);
        }//End Method

        //----------------------------------------------------------------------------------------
        // ProcessIRV | Parameters : Entity
        //----------------------------------------------------------------------------------------
        public void ProcessIRV(Entity activeEntity)
        {   
        
            //assign the entity a rep
            activeEntity.SalesRep = TheSalesRepManager.AssignFreeSalesRep(activeEntity.EntityCallType);

            //set the entitys start wait time
            activeEntity.StartWaitTime = SimulationTime;

            //Check to see if the active entity actually recived a rep if so...
            if (activeEntity.SalesRep != null)
            {
                //... set the end wait time for the entity
                activeEntity.EndWaitTime = SimulationTime;
                
                //set the rep assigned to the entity to be not availble 
                activeEntity.SalesRep.Avaliable = false;

               //Calculate the processing interval based on calls type 
                double processingTime = CalculateProcessingTime(activeEntity.EntityCallType);
                //create the new complete serve event passing in the calculated processing time and the active entity as well as the event type
                SimulationEvent newCompleteServiceEvent = new SimulationEvent(activeEntity, eEventType.ProcessingComplete, processingTime);
                //add the event to the calandar
                MainCalandar.AddEvent(newCompleteServiceEvent);
            }
            else//or else...
            {
                //add the entity to the queue
                theQueueManager.AddEntity(activeEntity);
            }//End outer if
            
        }//End MEthod        

        //----------------------------------------------------------------------------------------
        // Process Complete Service Method | Parameter : Entity
        //----------------------------------------------------------------------------------------
        public void ProcessCompleteService(Entity activeEntity)
        {
            //Set the active entitys end time to the simulations current time 
            activeEntity.EndSystemTime = SimulationTime;

            //update the stats for the entity passing in the active entity
            stats.UpdateEntityStats(activeEntity);
            
            //store the rep type of the current rep in a variable 
            eCallType theCallTypeofRep = activeEntity.SalesRep.RepType;

            //check the length of the queue of the call type that the active entitys rep is 
            int lengthOfQueueRepIsIn = theQueueManager.QueueLength(theCallTypeofRep);
           
            //if the queue length for that call type of the rep is null then...
            if (lengthOfQueueRepIsIn == 0)
            {
                //... make the rep avalible
                activeEntity.SalesRep.Avaliable = true;
            }
            else//or else...
            {
                //... get the next entity from thequeue that correspons to the rep type of the rep that was assigned to active entity
                Entity nextEntity = theQueueManager.GetNextEntity(theCallTypeofRep);
                //pass the rep from the active entity to the next entity
                nextEntity.SalesRep = activeEntity.SalesRep;
                //set the simulation end time for the next entity
                nextEntity.EndWaitTime = SimulationTime;

                //calculate how long it will take the next entity to comple the service call
                double processingTime = CalculateProcessingTime(nextEntity.EntityCallType);

                //create and add the new complete service event to the clandar passing the next entity, the processing complete event and the processing time
                SimulationEvent newCompleteServiceEvent = new SimulationEvent(nextEntity, eEventType.ProcessingComplete, processingTime);                
                MainCalandar.AddEvent(newCompleteServiceEvent);
                
            }//End if            
            
        }//End Method 

        //----------------------------------------------------------------------------------------
        // Calculate Processing Time Method | Parameter : eCallType
        //----------------------------------------------------------------------------------------
        private double CalculateProcessingTime(eCallType entityCallType)
        {
            double processingInterval = 0;
            //compute the processing interval which is calculated difrently dependant on the call type 
            switch (entityCallType)
            {
                case eCallType.StereoCall:
                    processingInterval = (theDice.diceRoll() * GlobalParameters.CAR_STEREO_CALL_PROCESSING_TIME) * GlobalParameters.SEC_IN_MIN;
                    break;

                case eCallType.OtherCall:
                    processingInterval = (theDice.diceRoll() * GlobalParameters.OTHER_PRODUCT_CALL_PROCESSING_TIME) * GlobalParameters.SEC_IN_MIN;
                    break;

            }

            //take the simulation time and add the tprocessing interval to get the time it will take to process
            double processingTime = SimulationTime + processingInterval;

            //return the time to process 
            return processingTime;
        }//End MEthod

        //----------------------------------------------------------------------------------------
        // Initalize Method | Parameters : N/A
        //----------------------------------------------------------------------------------------
        public void Initialize()
        {
            //create first entity
            Entity lastEntity = new Entity(0);
            //create first event passsin in the first entity
            SimulationEvent lastEvent = new SimulationEvent(lastEntity, eEventType.EndSimulation, 10800);
            //create last entity
            Entity firstEntity = new Entity(callArrives);
            //create last event passsin in the last entity
            SimulationEvent firstEvent = new SimulationEvent(firstEntity, eEventType.CallArrive, 0);
            //add the first event to the calandar
            MainCalandar.AddEvent(firstEvent);
            //add the last event to the calandar
            MainCalandar.AddEvent(lastEvent);

        }//End Method 

        //----------------------------------------------------------------------------------------
        // Update Simulation Clock Method | Parameters : N/A
        //----------------------------------------------------------------------------------------
        private void UpdateSimulationClock()
        {
            //make the simulation time  = to the time of the currently active event
            SimulationTime = ActiveEvent.EventTime;

        }//End Method
    }
}
