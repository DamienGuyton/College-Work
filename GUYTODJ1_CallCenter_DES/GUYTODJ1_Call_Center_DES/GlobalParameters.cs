using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: GlobalParameters.cs                                                     ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||The Global Parameters Class Defines all the constant values to be used within the simulator ranging from probablities to system ||
 * ||Parameters                                                                                                                      ||
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    static class GlobalParameters
    {

        //Random Number Probablities
        public static double CALL_ARRIVAL_RATE { get; set; }
        public static double CAR_STEREO_CALL_PROCESSING_TIME { get; set; }
        public static double OTHER_PRODUCT_CALL_PROCESSING_TIME { get; set; }
        public static double IVR_DELAY { get; set; }

        //System Parameters                                                                                                                                                                                                                                                                                                                                  
        public static int MAX_ON_HOLD { get; set; }
        public static double CALL_TYPE_RATIO { get; set; }
        public static int NUM_OTHER_REPS { get; set; }
        public static int NUM_STEREO_REPS { get; set; }

        //World Constants
        public static double SEC_IN_MIN = 60;

        //Random Number Static Values
        public static int PROB_LOW_LIMIT = 1;
        public static int PROB_HIGH_LIMIT = 7;

        public static int CALL_TYPE_LOW_LIMIT = 1;
        public static int CALL_TYPE_HIGH_LIMIT = 100;

        public static int SPEED { get; set; }
        public static int SPEED_INTERVAL = 100;




    }
}
