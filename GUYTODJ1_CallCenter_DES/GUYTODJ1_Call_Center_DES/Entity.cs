using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: Entity.cs                                                               ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||The Entity Class Represents an entity in the system where the simulator set and gets times, call type and sales representatives || 
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    //Enum to distinguish the Call type 
    enum eCallType { StereoCall = 0, OtherCall = 1 };
    class Entity
    {

        //Entiy ID

        public int EntityID { get; set; }

        //Entity Starts
        public double StartWaitTime { get; set; }

        //Entity Starts Wait
        public double StartSystemTime { get; set; }

        //Entity End Waits
        public double EndWaitTime { get; set; }

        //End System Time
        public double EndSystemTime { get; set; }

        //The Sales Rep
        public SalesRepresentative SalesRep { get; set; }

        //Entity Type
        public eCallType EntityCallType { get; set; }

        Dice entityProbablity;

        //----------------------------------------------------------------------------------------
        // Entity Constructor | Parameters : EntityID
        //----------------------------------------------------------------------------------------
        public Entity(int EntityID)
        {
            //set the entityID to the one passed in as a parameter
            this.EntityID = EntityID;
            //Initalize the Dice 
            entityProbablity = new Dice();
            //Compute the entitys type
            EntityCallType = ComputeEntityType(); // should be 16% stereo  
            StartWaitTime = 0;
            EndWaitTime = 0;
            StartSystemTime = 0;
            EndSystemTime = 0;
        }//End Constructor

        //----------------------------------------------------------------------------------------
        // ComputeEntityType | Parameters : N/A | Return : eCallType
        //----------------------------------------------------------------------------------------
        private eCallType ComputeEntityType()
        {
            //Initialize the random number
            Random rand = new Random();

            int num = rand.Next(GlobalParameters.CALL_TYPE_LOW_LIMIT, GlobalParameters.CALL_TYPE_HIGH_LIMIT);
            //Compute Whether or not the num is greater than the call type ratio and if so it is an other call else it is a stereo call
            if (num > GlobalParameters.CALL_TYPE_RATIO)
                return eCallType.OtherCall;
            else
                return eCallType.StereoCall;
        }//End Method

        //----------------------------------------------------------------------------------------
        // Calc Time In System Method | Parameters : N/A | Return : double
        //----------------------------------------------------------------------------------------
        public double CalcTimeInSystem()
        {
            //take the time the entity left the system and minus the time it started to get the time in system
            double sysTime = EndSystemTime - StartSystemTime;
            //return the time in system
            return sysTime;
        }//End Method

        //----------------------------------------------------------------------------------------
        // Calc Time In Queue | Parameters : N/A | Return : double
        //----------------------------------------------------------------------------------------
        public double CalcTimeInQueue()
        {
            //take the time the entity finished wait  and minus the time it started wait to get the time in queue
            double queueTime = EndWaitTime - StartWaitTime;
            //return the time in queue
            return queueTime;
        }//End Method



    }
}
