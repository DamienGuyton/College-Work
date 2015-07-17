using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*HEADER 
 * ||================================================================================================================================||
 * ||                                                PROGRAM: CALL CENTER - DISCRETE EVENT SIMULATOR                                 ||
 * ||                                                 CLASS: Dice.cs                                                                 ||
 * ||                                                AUTHOR: DAMIEN GUYTON (GUYTODJ1)                                                ||
 * ||                                                 DATE: 14/07/2013                                                               ||
 * ||                                                                                                                                ||
 * || ______________________________________________________DESCRIPTION_____________________________________________________________ ||
 * ||                    The dice class is used to produce random numbers for the random values used in  the system                  || 
 * ||================================================================================================================================||
 */
namespace GUYTODJ1_Call_Center_DES
{
    class Dice
    {
        Random randNum;

        public Dice()
        {
            //Initalize the random number
            randNum = new Random();
        }

        public int diceRoll()
        {
            //create the first random number between 1-7 
            int dieOne = randNum.Next(GlobalParameters.PROB_LOW_LIMIT, GlobalParameters.PROB_HIGH_LIMIT);

            //create the second random number between 1-7 
            int dieTwo = randNum.Next(GlobalParameters.PROB_LOW_LIMIT, GlobalParameters.PROB_HIGH_LIMIT);

            //combine the dice and sum
            int totalValue = dieOne + dieTwo;

            return totalValue;
        }//End Method
    }
}
