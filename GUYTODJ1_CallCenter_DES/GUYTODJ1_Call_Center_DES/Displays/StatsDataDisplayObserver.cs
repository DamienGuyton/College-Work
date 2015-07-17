using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: StatsDataDisplayObserver.cs                                             ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * || StatsDataDisplayObserver Class displays the the stats as it receives  the data from the subjects method notification           ||                                                                                                        ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class StatsDataDisplayObserver : SimulationDisplays
    {
        DataGridView statsGV;
        
        public StatsDataDisplayObserver(Object displayObject, ISimulationDataSubject simData)
            : base(displayObject, simData)
        {
            //Initalize variables

            //cast the object to a data grid view
            this.statsGV = (DataGridView)displayObject;
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
            //create a new data grid row
            DataGridViewRowCollection rows = statsGV.Rows;

            //fetch the statstics
            string numberOfCalls = simCurrentState.stats.CallsToSystem.ToString();
            string hangUps = simCurrentState.stats.HangUps.ToString() + " (" +
                   simCurrentState.stats.HangupPercentage + ")";
            string stereoCompletions = simCurrentState.stats.CompleteStereoCalls.ToString()  ;
            string otherCompletions = simCurrentState.stats.CompleteOtherCalls.ToString();
            string exessiveWaitStereo = simCurrentState.stats.ExcessiveWaitStereoCount.ToString() +" ("+
                   simCurrentState.stats.ExcesssiveWaitStereoPercentage.ToString()+")";
            string excessiveWaitOther = simCurrentState.stats.ExcessiveWaitOtherCount.ToString() + " (" +
                   simCurrentState.stats.ExcesssiveWaitOtherPercentage.ToString() + ")";
            string utalisationStereo = simCurrentState.stats.AvgUtilisationStereo.ToString();
            string utalisationOther = simCurrentState.stats.AvgUtilisationOther.ToString();
            string avgStereoQLength = simCurrentState.stats.AvgQueueLengthStereo.ToString();
            string avgOtherQLength = simCurrentState.stats.AveQueueLengthOther.ToString();
            string avgTimeInQueue = simCurrentState.stats.AvgTimeInQueue.ToString();
            string avgTimeInSystem = simCurrentState.stats.AvgTimeInSystem.ToString();

            //pass the fetched statistics into an array 
            string[] newRow = {numberOfCalls, hangUps,stereoCompletions, otherCompletions, exessiveWaitStereo, excessiveWaitOther,utalisationStereo,
                                  utalisationOther,avgStereoQLength,avgOtherQLength,avgTimeInQueue, avgTimeInSystem};

            //take the array of strings and add it to the row
            rows.Add(newRow);
        }//End MEthod

    }
}
