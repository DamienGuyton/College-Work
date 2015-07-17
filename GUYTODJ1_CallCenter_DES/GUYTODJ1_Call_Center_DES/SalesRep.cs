using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: SalesRep.cs                                                             ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||                   The sales rep class define the sales rep by two propeties the rep type and avalablity                        ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class SalesRepresentative
    {
        //Avalible property of Sales Rep

        public bool Avaliable { get; set; }

        //Type property of Sales Rep

        public eCallType RepType { get; set; }

        //----------------------------------------------------------------------------------------
        // Sales Rep COnstructer | Parameters : eCallType
        //----------------------------------------------------------------------------------------
        public SalesRepresentative(eCallType repType)
        {
            //Initalize the Avalablity of the rep
            this.Avaliable = true;
            //set the rep type to be the rep type passed in as the parameter
            this.RepType = repType;
        }//End Constructor
    }
}
