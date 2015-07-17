using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: SimulationEvent.cs                                                      ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||  Simulation Event Class has an eEvent type defining what event it is as well as knowing how to sort its self when in a list    || 
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    //Enum defines the types of events within the simulation
    enum eEventType { CallArrive = 0, SwitchComplete = 1, ProcessingComplete = 2, EndSimulation = 3 };
    class SimulationEvent:IComparable<SimulationEvent>
    {
        private double  eventTime;
        private Entity eventEntity;
        public Entity EventEntity { get { return eventEntity; } set { eventEntity = value; } }
        public double EventTime { get { return eventTime; } set { eventTime = value; } }
        public eEventType eventType;

        //----------------------------------------------------------------------------------------
        // SimulationEvent Constructor | Parameters : Entity, EventType, Double 
        //----------------------------------------------------------------------------------------
        public SimulationEvent(Entity eventEntity, eEventType eventType, double eventTime)
        {
            this.eventEntity = eventEntity;
            this.eventType = eventType;
            this.eventTime = eventTime;
         }//End Constructor

         //----------------------------------------------------------------------------------------
        //Compare To | Parameters : SimulationEvent | Return : int
        //----------------------------------------------------------------------------------------
        public int CompareTo(SimulationEvent other)
        {
            if (this.eventTime > other.EventTime) return 1;
            else if (this.eventTime < other.EventTime) return -1;
            else return 0;

        }//End Method 

      

    
    }
   
}
