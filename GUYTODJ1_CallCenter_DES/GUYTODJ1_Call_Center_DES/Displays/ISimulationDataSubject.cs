using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                              InterFace:ISimulationDataSubject.cs                                               ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||  ISimulationDataSubject is the interface that the simulation data subject implements to remove dependency on a concret class   ||
 * ||  allowing to easily extend the data subjects                                                                                   ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    interface ISimulationDataSubject
    {
        void AddObserver(IDisplayObserver o);
        void RemoveObserver(IDisplayObserver o);
        void NotifyObserver(Simulator anObject);
    }
}
