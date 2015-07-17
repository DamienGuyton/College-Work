using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: Calandar.cs                                                             ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||  Simulation Event Class has an eEvent type defining what event it is as well as knowing how to sort its self when in a list    || 
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class Calendar
    {
        public List<SimulationEvent> EventList {get;set;}

        //----------------------------------------------------------------------------------------
        //Calandar Constructor | Partameters : N/A
        //----------------------------------------------------------------------------------------
        public Calendar()
        {
            //INitalize the events list
            EventList = new List<SimulationEvent>();           
        }//End Constructor 

        //--------------------------------------------------------------------------------------------
        // Add Event | Parameters : SimulationEvent
        //---------------------------------------------------------------------------------------------
        public void AddEvent(SimulationEvent theEvent)
        {
            // add the event to the events list then sort to get the events in order as they are added
            EventList.Add(theEvent);
            SortEvents();
        }//End Method

        //----------------------------------------------------------------------------------------------
        // Get Next Event | Parameters : N/A | Return : SimulationEvent
        //---------------------------------------------------------------------------------------------
        public SimulationEvent GetNextEvent()
        {
           //get the first event in the list 
           SimulationEvent nextEvent = EventList.ElementAt(0);
           //Remove the event from the list 
           EventList.RemoveAt(0);
           // return the event 
           return  nextEvent;

        }//End Method 

        //----------------------------------------------------------------------------------------
        // SortEvents | Parameters : N/A
        //----------------------------------------------------------------------------------------
        public void SortEvents()
        {
            EventList.Sort();

        }//End Method 
    }
}
