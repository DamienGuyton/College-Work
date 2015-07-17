#pragma once
#include "Gene.h"


using namespace System;

ref class Chromosome : IComparable<Chromosome^>
{
private:
	bool elite;
	float cost;
	int mutateAmount;
	String^ solution;
	array<Gene^>^ genes;
	Random^ rGen;
public:
	Chromosome(int nGenes, int startMutateAmount, String^ startSolution, Random^ startRGen, int minVal, int maxVal);
	Chromosome(array<Gene^>^ startGenes, int startMutateAmount, String^ startSolution, Random^ startRGen, int minVal, int maxVal);
	void calcFitness();
	String^ print();
	void mutateGenes(Random^ rGen);
	int getNGenes()					{return genes->Length;}
	float getCost()					{return cost;}
	array<Gene^>^ getGenes()		{return genes;}
	virtual int CompareTo(Chromosome^ otherChromosome);
	void setElite(bool eliteVal)	{elite = eliteVal;}
};
