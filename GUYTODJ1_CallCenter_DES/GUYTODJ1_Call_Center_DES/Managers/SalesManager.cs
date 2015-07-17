using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: SalesManager.cs                                                         ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||   SalesManager class looks after list of sales reps computing information such as who is busy and  assiging them to entitys    || 
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class SalesManager
    {

        public List<SalesRepresentative> StereoSalesReps { get; set; }
        public List<SalesRepresentative> OtherSalesReps { get; set; }
        //--------------------------------------------------------------------------------------
        // SalesManager Constructor | Parameter : N/A
        //---------------------------------------------------------------------------------------------
        public SalesManager()
        {
            //intitalize the reps lists 
            this.StereoSalesReps = new List<SalesRepresentative>();
            this.OtherSalesReps = new List<SalesRepresentative>();

            //Grabs the global varrable integer NUM_OTHER_REPS, which iterate NUM_OTHER_REPS time and aading a new rep to the list
            for (int o = 0; o < GlobalParameters.NUM_OTHER_REPS; o++)
            {
                SalesRepresentative theOtherSalesRep = new SalesRepresentative(eCallType.OtherCall);
                OtherSalesReps.Add(theOtherSalesRep);
            }

            //Grabs the global varrable integer NUM_STEREO_REPS, which iterate NUM_STEREO_REPS time and aading a new rep to the list
            for (int s = 0; s < GlobalParameters.NUM_STEREO_REPS; s++)
            {
                SalesRepresentative theStereoRep = new SalesRepresentative(eCallType.StereoCall);
                StereoSalesReps.Add(theStereoRep);
            }

        }//End Method        

        //---------------------------------------------------------------------------------------------
        // Get Free Rep | Parameters : List<SalesRepresntative> | Return : SalesRepresentative
        //----------------------------------------------------------------------------------------------
        private SalesRepresentative GetFreeRep(List<SalesRepresentative> theListOfReps)
        {
            //Iterate through each rep checking their avalablity returning a rep or null
            foreach (SalesRepresentative rep in theListOfReps)
            {
                if (rep.Avaliable == true)
                {
                    return rep;
                }
            }
            return null;

        }//End Method 

        //---------------------------------------------------------------------------------------------
        // Compute Busy Calls | Parameters : List<SalesRepresntative> | Return : int
        //---------------------------------------------------------------------------------------------       
        private int ComputeBusyCalls(List<SalesRepresentative> theRepsList)
        {
            int count = 0;
            //Itterate through each rep in the rep list incrementing count if the rep is avalible
            foreach (SalesRepresentative rep in theRepsList)
            {
                if (rep.Avaliable == false)
                    count++;
            }

            return count;

        }//End Method

        //---------------------------------------------------------------------------------------------
        // Number of Busy reps | Parameters : eCallType | Return : int
        //---------------------------------------------------------------------------------------------  
        public int NumberOfBusyReps(eCallType theCallType)
        {
            int numBusy = 0;

            //switch to compute number of busy reps on the reps list corresponding to the call type passed in
            switch (theCallType)
            {
                case eCallType.OtherCall:
                    numBusy = ComputeBusyCalls(OtherSalesReps);
                    break;

                case eCallType.StereoCall:
                    numBusy = ComputeBusyCalls(StereoSalesReps);
                    break;
            }
            //Return the number of reps busy
            return numBusy;

        }//End Method

        //----------------------------------------------------------------------
        //Assign Free Sales Rep | Parameters : eCallType | Return : SalesRepresentative
        //-------------------------------------------------------------------------
        public SalesRepresentative AssignFreeSalesRep(eCallType theCallType)
        {
            SalesRepresentative rep = null;
            //switch to assign a rep depending on the call type passed in using the GetFreeRep method
            switch (theCallType)
            {
                case eCallType.OtherCall:
                    rep = GetFreeRep(OtherSalesReps);
                    break;

                case eCallType.StereoCall:
                    rep = GetFreeRep(StereoSalesReps);
                    break;

            }
            //returns the rep 
            return rep;

        }//End Method

        //---------------------------------------------------------------------------------
        //Compute Number Of Reps | Parameters : List<SalesRepresentative> | Returns : int
        //---------------------------------------------------------------------------------
        private int ComputeNumberOfReps(List<SalesRepresentative> theRepList)
        {
            //return the count of the list
            int numberOfReps = theRepList.Count;
            return numberOfReps;

        }//End Method

        //---------------------------------------------------------------------------------
        //Number Of Rep | Parameters : eCallType | Returns : int
        //----------------------------------------------------------------------------------
        public int NumberOfReps(eCallType theCallType)
        {
            int count = 0;
            //switch to assign a rep depending on the call type passed in using the GetFreeRep method
            switch (theCallType)
            {
                case eCallType.OtherCall:
                    count = ComputeNumberOfReps(OtherSalesReps);
                    break;

                case eCallType.StereoCall:
                    count = ComputeNumberOfReps(StereoSalesReps);
                    break;

            }
            //returns the rep 
            return count;

        }//End Method

        //-------------------------------------------------------------------------------
        //Total Number Of Reps | Parameters : N/A | Returns : Int
        //-----------------------------------------------------------------------------------
        public int TotalNumberOFReps()
        {
            int total;
            //Compute the toatl by adding together both lists
            total = NumberOfReps(eCallType.StereoCall) + NumberOfReps(eCallType.OtherCall);
            return total;

        }//End Method
    }
}
