using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: Stats.cs                                                                ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * || The Stats class Computes both entity stats as the entitys flow through the system. I also gathers/computes stats on the queues ||
 * || and also the system as a whole                                                                                                 ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class Stats
    {
        //Proverties for values
        public int CallsToSystem { get; set; }
        public int HangUps { get; set; }
        public int CompleteStereoCalls { get; set; }
        public int CompleteOtherCalls { get; set; }
        public double AvgQueueLengthStereo { get; set; }
        public double AveQueueLengthOther { get; set; }
        public double AvgTimeInQueue { get; set; }
        public double AvgTimeInSystem { get; set; }
        public double ExcesssiveWaitStereoPercentage { get; set; }
        public double ExcesssiveWaitOtherPercentage { get; set; }
        public int ExcessiveWaitStereoCount { get; set; }
        public int ExcessiveWaitOtherCount { get; set; }
        public double AvgUtilisationStereo { get; set; }
        public double AvgUtilisationOther { get; set; }
        public double HangupPercentage { get; set; }

        //Properties for lists
        public List<int> NumInOtherQueue { get; set; }
        public List<int> NumInStereoQueue { get; set; }
        public List<double> TimeInStereoQueue { get; set; }
        public List<double> TimeInOtherQueue { get; set; }
        public List<double> TimeInSystem { get; set; }
        public List<double> OtherQueueExcessiveWait { get; set; }
        public List<double> StereoQueueExcessiveWait { get; set; }
        public List<double> StereoUtilisation { get; set; }
        public List<double> OtherUtilisation { get; set; }

        //----------------------------------------------------------------------------------------
        // Stats Constructor | Parameters : N/A
        //----------------------------------------------------------------------------------------
        public Stats()
        {
            //Initalize the values
            this.CallsToSystem = 0;
            this.HangUps = 0;
            this.CompleteStereoCalls = 0;
            this.CompleteOtherCalls = 0;
            this.ExcesssiveWaitStereoPercentage = 0;
            this.ExcesssiveWaitOtherPercentage = 0;
            this.ExcessiveWaitOtherCount = 0;
            this.ExcessiveWaitStereoCount = 0;
            this.AvgTimeInQueue = 0;
            this.AvgUtilisationOther = 0;
            this.AvgUtilisationStereo = 0;
            this.HangupPercentage = 0;

            //Initalize the lists 
            this.TimeInSystem = new List<double>();
            this.TimeInStereoQueue = new List<double>();
            this.TimeInOtherQueue = new List<double>();
            this.NumInOtherQueue = new List<int>();
            this.NumInStereoQueue = new List<int>();
            this.OtherQueueExcessiveWait = new List<double>();
            this.StereoQueueExcessiveWait = new List<double>();
            this.StereoUtilisation = new List<double>();
            this.OtherUtilisation = new List<double>();
        }//End Constructor

        //----------------------------------------------------------------------------------------
        // Compute Summaries | Paramerters : N/A
        //----------------------------------------------------------------------------------------
        public void ComputeSummaries()
        {
            //Compute completed calls
            CompleteOtherCalls = TimeInOtherQueue.Count;
            CompleteStereoCalls = TimeInStereoQueue.Count;

            //Compute Excessive wait counts 
            ExcessiveWaitOtherCount = OtherQueueExcessiveWait.Count;
            ExcessiveWaitStereoCount = StereoQueueExcessiveWait.Count;

            //Compute Excessive wait percentages 
            ExcesssiveWaitOtherPercentage = (double)OtherQueueExcessiveWait.Count /(double) CompleteOtherCalls;
            ExcesssiveWaitOtherPercentage = Math.Round(ExcesssiveWaitOtherPercentage, 2);

            ExcesssiveWaitStereoPercentage = (double)StereoQueueExcessiveWait.Count / (double)CompleteStereoCalls;
            ExcesssiveWaitStereoPercentage = Math.Round(ExcesssiveWaitStereoPercentage, 2);

            //Compute hangup Perecentage
            HangupPercentage = (double)HangUps / (double)CallsToSystem;
            HangupPercentage = Math.Round(HangupPercentage,2);

            //Compute average rep utalizations
            AvgUtilisationOther = OtherUtilisation.Average()/GlobalParameters.NUM_OTHER_REPS;
            AvgUtilisationOther = Math.Round(AvgUtilisationOther, 2);

            AvgUtilisationStereo = StereoUtilisation.Average();
            AvgUtilisationStereo = Math.Round(AvgUtilisationStereo, 2);
            
            //Compute Average Queue Lengths
            AveQueueLengthOther = NumInOtherQueue.Average();
            AveQueueLengthOther = Math.Round(AveQueueLengthOther, 2);
            AvgQueueLengthStereo = NumInStereoQueue.Average();
            AvgQueueLengthStereo = Math.Round(AvgQueueLengthStereo, 2);

            //Compute Average Queue Lenths
            AvgTimeInQueue = CalcAverageTimeInQueue();
            AvgTimeInQueue = Math.Round(AvgTimeInQueue, 2);
            AvgTimeInSystem = TimeInSystem.Average();
            AvgTimeInSystem = Math.Round(AvgTimeInSystem, 2);
        }//End Method

        //----------------------------------------------------------------------------------------
        // UpdateSystemStats | Parameters : Simulator
        //----------------------------------------------------------------------------------------
        public void UpdateSystemStats(Simulator theSim)
        {
            //Update list of stereo calls in queue at that poin in time by adding it to NumInStereoQueue
            int stereoQueueLength = theSim.theQueueManager.QueueLength(eCallType.StereoCall);
            NumInStereoQueue.Add(stereoQueueLength);

            //Update list of other calls in queue at that poin in time by adding it to NumInOtherQueue
            int otherQueueLength = theSim.theQueueManager.QueueLength(eCallType.OtherCall);
            NumInOtherQueue.Add(otherQueueLength);

            //Update list of other reps who are busy by adding the ammount at that time to OtherUtilisation
            int busyOtherRep = theSim.TheSalesRepManager.NumberOfBusyReps(eCallType.OtherCall);
            OtherUtilisation.Add(busyOtherRep);

            //Update list of stereo reps who are busy by adding the ammount at that time to StereoUtilisation
            int busyStereoRep = theSim.TheSalesRepManager.NumberOfBusyReps(eCallType.StereoCall);
            StereoUtilisation.Add(busyStereoRep);

        }//End Method

        //----------------------------------------------------------------------------------------
        // Calc Average Time In Queue | Parameters : N/A | Return : double
        //----------------------------------------------------------------------------------------
        public double CalcAverageTimeInQueue()
        {
            double average = 0;
            //create a new list to hold both time  in queue lists
            List<double> combinedList = new List<double>();
            //Add stereo time in queue to the new list 
            combinedList.AddRange(TimeInStereoQueue);
            //Add other time in queue to the new list 
            combinedList.AddRange(TimeInOtherQueue);
            //Average the new list  
            average = combinedList.Average();
            return average;

        }//End Method

        //----------------------------------------------------------------------------------------
        // Updates Entity Stats | Parameters : Entity
        //----------------------------------------------------------------------------------------
        public void UpdateEntityStats(Entity theEntity)
        {
            //get  the time in system for the entity 
            double sysTime = theEntity.CalcTimeInSystem();

            //get  the time in queue for the entity 
            double queueTime = theEntity.CalcTimeInQueue();

            //get the entitys call type
            eCallType entityCallType = theEntity.EntityCallType;

            //add the time to the system times list
            TimeInSystem.Add(sysTime); 

            //Add the queue time to the appropiate TimeInQueue list depending on the call type
            switch (entityCallType)
            {
                case eCallType.OtherCall:
                    TimeInOtherQueue.Add(queueTime);
                    break;

                case eCallType.StereoCall:
                    TimeInStereoQueue.Add(queueTime);
                    break;
            }          

            //try incrementing excessive wait count
            IncrementExcessiveWait(entityCallType, queueTime);

        }//End Method 

        
        //----------------------------------------------------------------------------------------
        // Increment Excessive Wait | Parameters : eCallType, double
        //----------------------------------------------------------------------------------------
        public void IncrementExcessiveWait(eCallType entityCallType, double queueTime)
        {
            //If the queue tim is greater than 60 seconds than add the the queue time to the Other/Stereo QueueExcessiveWait 
            if (queueTime > GlobalParameters.SEC_IN_MIN)
            {
                //determines what list to add the time to
                switch (entityCallType)
                {
                    case eCallType.OtherCall:
                        OtherQueueExcessiveWait.Add(queueTime);
                        break;

                    case eCallType.StereoCall:
                        StereoQueueExcessiveWait.Add(queueTime);
                        break;
                }      
                
            }
        }
    }
}
