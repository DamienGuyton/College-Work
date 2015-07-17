using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: SimulationDisplay.cs                                                    ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||                    SimulationDisplay class is the base class that all displays inherit from                                    ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    abstract class SimulationDisplays:IDisplayObserver
    {
        protected ISimulationDataSubject simData;
        protected Object displayObject;
        protected Simulator simCurrentState;
        //----------------------------------------------------------------------------------------
        // SimulationDisplays Constructer | Parameters : Object, ISImulationDataSubject
        //----------------------------------------------------------------------------------------
        public SimulationDisplays(Object displayObject,ISimulationDataSubject simData)
        {
            //Initalize variables
            this.simData = simData;
            this.displayObject = displayObject;
            simCurrentState = null;
            
        }//End Constructer

        //----------------------------------------------------------------------------------------
        // DisplayData Method | Parameters :N/A
        //----------------------------------------------------------------------------------------
        public abstract void DisplayData();

        //----------------------------------------------------------------------------------------
        // Update Method | Parameters : Simulator
        //----------------------------------------------------------------------------------------
        public abstract void Update(Simulator sim);



    }
}
