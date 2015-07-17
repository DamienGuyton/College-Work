#include "StdAfx.h"
#include "Chromosome.h"

Chromosome::Chromosome(int nGenes, int startMutateAmount, String^ startSolution, Random^ startRGen, int minVal, int maxVal)
{
	elite = false;
	mutateAmount = startMutateAmount;
	solution = startSolution;
	genes = gcnew array<Gene^>(nGenes);
	rGen = startRGen;
	//hard code the max values that the solver can use for each gene
	int aMax = 33;
	int bMax=17;
	int cMax=12;
	int dMax =10;
	genes[0] = gcnew Gene(1, aMax, rGen);
	genes[1] = gcnew Gene(1, bMax, rGen);
	genes[2] = gcnew Gene(1, cMax, rGen);
	genes[3] = gcnew Gene(1, dMax, rGen);

	calcFitness();
}

Chromosome::Chromosome(array<Gene^>^ startGenes, int startMutateAmount, String^ startSolution, Random^ startRGen, int minVal, int maxVal)
{
	elite = false;
	mutateAmount = startMutateAmount;
	solution = startSolution;
	genes = startGenes;
	rGen = startRGen;
	calcFitness();
}

void Chromosome::calcFitness()
{
	int product = 
		(genes[0]->getValue()) +
		(2 * genes[1]->getValue()) +
		(3 * genes[2]->getValue()) +
		(4 * genes[3]->getValue());

	int difference = Convert::ToInt32(solution) - product;

	cost = Math::Abs(difference);
}

String^ Chromosome::print()
{
	String^ output = "";
	for(int i = 0; i < genes->Length; i++)
		output += genes[i]->getValue() + ", ";
	 output += " : " +cost.ToString();
	return output;
}

void Chromosome::mutateGenes(Random^ rGen)
{
	if(!elite)
		for(int i = 0; i < mutateAmount; i++)
		{
			int gene = rGen->Next(genes->Length);
			genes[gene]->mutate();
		}
}

int Chromosome::CompareTo(Chromosome^ otherChromosome)
{
	if(cost < otherChromosome->getCost())
		return -1;
	if(cost == otherChromosome->getCost())
		return 0;
	else
		return 1;

}