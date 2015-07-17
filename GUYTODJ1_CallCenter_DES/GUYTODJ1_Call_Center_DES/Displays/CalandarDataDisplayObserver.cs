using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: CalandarDataDisplayObserver.cs                                          ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * || CalandarDataDisplayObserver Class displays the events in the calander as it receives the data from the subjects notification   ||
 * || method                                                                                                                         ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class CalandarDataDisplayObserver:SimulationDisplays
    {
        DataGridView calandarGV = null;
        public CalandarDataDisplayObserver(Object displayObject, ISimulationDataSubject simData)
            : base(displayObject, simData)
        {
            //Initalize variables

            //cast the object to a data grid view
            calandarGV = (DataGridView)displayObject;
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
            calandarGV.Refresh();
            //Clear the data grid view
            calandarGV.Rows.Clear();
            //Get the calandar list from the simulator
            List<SimulationEvent> CalanderList = simCurrentState.MainCalandar.EventList;
            //create a new data grid row
            DataGridViewRowCollection rows = calandarGV.Rows;
            //itterate over each entity in the calander buliding an array of string values 
            foreach (SimulationEvent se in CalanderList)
            {
                string entityID = se.EventEntity.EntityID.ToString();
                string simEvent = se.eventType.ToString();
                string eventTime = se.EventTime.ToString();
                string productType = se.EventEntity.EntityCallType.ToString();
                string startTime = se.EventEntity.StartSystemTime.ToString();
                string beginWait = se.EventEntity.StartWaitTime.ToString();

                //take the string values and add them to an array
                string[] newRow = { entityID, simEvent, eventTime, productType, startTime, beginWait };

                //add the row to the data grid passing in the string array
                rows.Add(newRow);
            }//End Foreach
        }//End Method
    }
}
