using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: CarStereoQueueDataDisplayObserver.cs                                    ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||  CarStereoQueueDataDisplayObserver Class displays the events in the car stereo queue as it receives the data from the subjects ||
 * ||  method notification                                                                                                           ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class CarStereoQueueDataDisplayObserver:SimulationDisplays
    {
        DataGridView carStereoQueueGV = null;
        public CarStereoQueueDataDisplayObserver(object displayObject, ISimulationDataSubject simData)
            : base(displayObject, simData)
        {
            //Initalize variables

            //cast the object to a data grid view
            carStereoQueueGV = (DataGridView)displayObject; 
            simData.AddObserver(this);
        }

        //----------------------------------------------------------------------------------------
        // Update Method | Parameters : Simulator
        //----------------------------------------------------------------------------------------
        public override void Update(Simulator sim)
        {
            //make the simCurrenState = to the simulate at the current moment upadte is called
            simCurrentState = sim;

            //displaythe data
            DisplayData();

        }//End Method

        //----------------------------------------------------------------------------------------
        // DisplayData Method | Parameters : N/A
        //----------------------------------------------------------------------------------------
        public override void DisplayData()
        {
            //refresh the data grid view
            carStereoQueueGV.Refresh();
            //Clear the data grid view
            carStereoQueueGV.Rows.Clear();
            //Get the stereo queue from the simulator
            Queue<Entity> entitysInQueue = simCurrentState.theQueueManager.StereoQueue;
            //create a new data grid row
            DataGridViewRowCollection rows = carStereoQueueGV.Rows;
            //itterate over each entity in the queue buliding an array odf string values 
            foreach (Entity e in entitysInQueue)
            {
                string entityID = e.EntityID.ToString();
                string productType = e.EntityCallType.ToString();
                string startTime = e.StartSystemTime.ToString();
                string beginWait = e.StartWaitTime.ToString();

                //take the string values and add them to an array
                string[] newRow = { entityID, productType, startTime, beginWait };

                //add the row to the data grid passing in the string array
                rows.Add(newRow);
            }//End Foreach
        }//End Method
    }
}
