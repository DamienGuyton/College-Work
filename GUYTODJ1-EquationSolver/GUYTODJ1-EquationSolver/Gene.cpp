#include "stdafx.h"
#include "Gene.h"

//Pre: takes in a start min x and y values and a random object
//Post: intilaizes the variables
Gene::Gene(int startMinVal, int startMaxVal, Random^ startRGen)
{
	rGen = startRGen;
	minVal = startMinVal;
	maxVal = startMaxVal;
	value = rGen->Next(minVal, maxVal);
}//End constructor

//Pre: takes in a start min x and y values, start value and a random object
//Post: intilaizes the variables
Gene::Gene(int startValue, int startMinVal, int startMaxVal, Random^ startRGen)
{
	rGen = startRGen;
	minVal = startMinVal;
	maxVal = startMaxVal;
	value = startValue;
}//End constructor

//Pre:takes in no arguments
//Post: mutates the gene by changing its value between the min and max value
void Gene::mutate()
{
	value = rGen->Next(minVal, maxVal);
}//end mutate
