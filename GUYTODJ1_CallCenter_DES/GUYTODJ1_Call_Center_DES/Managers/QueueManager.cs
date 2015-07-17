using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: QueueManager.cs                                                         ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||  QueueManage Classs manages the queues containg methods to add entitys to the queue or getting the next entity from the queue  ||
 * ||  It can also compute the lenghts of the queues.                                                                                ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class QueueManager
    {
        public Queue<Entity> OtherQueue { get; set; }
        public Queue<Entity> StereoQueue { get; set; }

        //----------------------------------------------------------------------------------------
        // QueueManger Constructor | Parameters | N/A
        //----------------------------------------------------------------------------------------
        public QueueManager()
        {
            //Initialize the queues
            this.OtherQueue = new Queue<Entity>();
            this.StereoQueue = new Queue<Entity>();

        }//End Constructor

        //----------------------------------------------------------------------------------------
        //Add Entity Method | Parameters : Entity
        //----------------------------------------------------------------------------------------
        public void AddEntity(Entity theEntity)
        {
            //Add the entity to the appropriate queue that matches the entitys call type
            switch (theEntity.EntityCallType)
            {
                case eCallType.StereoCall:
                    StereoQueue.Enqueue(theEntity);
                    break;

                case eCallType.OtherCall:
                    OtherQueue.Enqueue(theEntity);
                    break;

            }//End Switch

        }//End method

        //----------------------------------------------------------------------------------------
        // Get Next Entity Method | Parameters : eCallType | Return : Entity
        //----------------------------------------------------------------------------------------
        public Entity GetNextEntity(eCallType entityCallType)
        {
            Entity theEntity = null;
            //return the next entity from the queue that matches the eCallType passed in 
            switch (entityCallType)
            {
                case eCallType.StereoCall:
                    theEntity = StereoQueue.Dequeue();
                    break;


                case eCallType.OtherCall:
                    theEntity = OtherQueue.Dequeue();
                    break;

            }//End Switch

            //retunr the entity
            return theEntity;

        }//End Method

        //----------------------------------------------------------------------------------------
        // Compute Queue Length | Parameters : Queue<Entity> | Return : int
        //----------------------------------------------------------------------------------------
        public int ComputeQueueLength(Queue<Entity> queue)
        {
            //return the count of the queue passed into the method
            return queue.Count;

        }//End Method 

        //----------------------------------------------------------------------------------------
        // QueueLength | Parameters : eCallType | Return : int
        //----------------------------------------------------------------------------------------
        public int QueueLength(eCallType repType)
        {
            int queueLength = 0;
            //calculate the length of the queue of the queue that represent the call type that matche eCallTpe
            switch (repType)
            {
                case eCallType.StereoCall:
                    queueLength = ComputeQueueLength(StereoQueue);
                    break;


                case eCallType.OtherCall:
                    queueLength = ComputeQueueLength(OtherQueue);
                    break;
            }

            //Return the queues length
            return queueLength;

        }//End Method

        //----------------------------------------------------------------------------------------
        // TotalQueueLength | Parameters : N/A | Return : int
        //----------------------------------------------------------------------------------------
        public int TotalQueueLength()
        {
            int total;
            //calculate the length of both the stereo and other queues and sum them
            total = QueueLength(eCallType.OtherCall) + QueueLength(eCallType.StereoCall);
            //return the total
            return total;
        }//End Method
    }
}
