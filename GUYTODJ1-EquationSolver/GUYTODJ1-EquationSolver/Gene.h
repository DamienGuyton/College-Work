#pragma once
using namespace System;
ref class Gene
{
private:
	int value;
	int minVal;
	int maxVal;
	Random^ rGen;
public:
	Gene(int startMinVal, int startMaxVal, Random^ startRGen);
	Gene(int startValue, int startMinVal, int startMaxVal, Random^ startRGen);
	void mutate();
	int getValue()				{return value;}
	void setValue(int nValue)	{value = nValue;}
	int getMaxVal()				{return maxVal;}
	void setMaxVal(int v)		{maxVal = v;}
	int getMinVal()				{return minVal;}
	void setMinVal(int v)		{minVal = v;}
};

