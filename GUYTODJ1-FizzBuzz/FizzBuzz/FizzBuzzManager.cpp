#include "stdafx.h"
#include "FizzBuzzManager.h"

//Pre:  takes in an integer for min and an integer for max
//Post: sets the min and max
FizzBuzzManager::FizzBuzzManager(int min, int max)
{
	this->min = min;
	this->max = max;
}//End FizzBuzzManager

//Pre:  takes list box 
//Post: outpust a number, fiz, buzz or fizbuzz in the list box dependin upon the number
void FizzBuzzManager::Run(ListBox^ displayListBoz)
{
	for (int i = min; i < max; i++)
	{
		//bool to hold weather or not print num 
		bool x = false;

		String^ textToPrint = "";

		//if its a multiple of three append fizz to string 
		if (i%3 == 0)
		{
			textToPrint += "fizz";
			x = true;
		}

		//if its a multiple of 5 append to string 
		if (i%5==0)
		{
			textToPrint += "buzz";
			x = true;
		}
		//if its not a multiple of 3 or 5 then output number 
		if(!x)
		{
			textToPrint += i;
		}
		//add to listbox
		displayListBoz->Items->Add(textToPrint);
	}//end for loop
}//end run
