using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                              InterFace:IDisplayObserver.cs                                                     ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||  IDisplayObserver is the interface that the display observers implement allowing  for easy extension to add more displays      ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    interface IDisplayObserver
    {
        void Update(Simulator anObject);
        void DisplayData();
    }
}
