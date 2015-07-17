using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: SimulationDisplayDataSubject.cs                                         ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||SimulationDisplayDataSubject controls the flow of information from the simulation to the displays upating the infomation they   ||
 * ||need                                                                                                                            ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class SimulationDisplayDataSubject:ISimulationDataSubject
    {
        private List<IDisplayObserver> simulationDisplayObserverList;

        //----------------------------------------------------------------------------------------
        // Simulation Display Data Subject Constructer | Parameters : N/A
        //----------------------------------------------------------------------------------------
        public SimulationDisplayDataSubject()
        {
            //initalize the list of display observers 
            simulationDisplayObserverList = new List<IDisplayObserver>();
        }//End Constructer

        //----------------------------------------------------------------------------------------
        // Add Observer Method | Parameters : IDisplayObserver
        //----------------------------------------------------------------------------------------
        public void AddObserver(IDisplayObserver o)
        {
            //Add the display observer to the simulationDisplayObserverList
            simulationDisplayObserverList.Add(o);
        }//End Method

        //----------------------------------------------------------------------------------------
        // Remove Observer Method | Parameters : Object, ISImulationDataSubject
        //----------------------------------------------------------------------------------------
        public void RemoveObserver(IDisplayObserver o)
        {
            //Remove the display observer to the simulationDisplayObserverList
            simulationDisplayObserverList.Remove(o);

        }//End Method

        //----------------------------------------------------------------------------------------
        // NotifyObserver Method | Parameters : Object, ISImulationDataSubject
        //----------------------------------------------------------------------------------------
        public void NotifyObserver(Simulator sim)
        {
            //Iterate over the list of obserbers updating the data they need
            foreach (IDisplayObserver currentObserver in simulationDisplayObserverList)
            {
                currentObserver.Update(sim);
            }

        }//End Method

    }
}
