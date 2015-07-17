#include "StdAfx.h"
#include "Population.h"

Population::Population(int size, double mutationChance, double startKeepProb, int nElite, int costThreshold, String^ startSolution, int startNGenes, int startMutationAmount, int startMinVal, int startMaxVal, Random^ startRGen)
{
	chromosomes = gcnew array<Chromosome^>(size);
	cumProb = gcnew array<double>(size);
	popSize = size;
	mutationProb = mutationChance;
	mutateAmount = startMutationAmount;
	minVal = startMinVal;
	maxVal = startMaxVal;
	keepProb = startKeepProb;
	eliteCount = nElite;
	costThresh = costThreshold;
	solution = startSolution;
	rGen = startRGen;
	nGenes = startNGenes;

	genNewChromosomes();
	calcCumProb();
	calcChromosomeFitness();
	rankPopulation();
}

void Population::calcCumProb()
{
	array<double>^ inverseRanks = gcnew array<double>(popSize);
	//calc cumulative sum of ranks
	double total = (popSize * (popSize + 1)) / 2;

	//insert ranks
	for(int i = 0; i < popSize; i++)
		inverseRanks[i] = popSize - i;

	cumProb[0] = inverseRanks[0] / total;

	for(int i = 1; i < popSize; i++)
		cumProb[i] = (inverseRanks[i] / total) + cumProb[i - 1];
}

Point Population::selectBreedingPair()
{
	Point p;

	double prob = rGen->NextDouble();
	for(int i = 0; i < cumProb->Length; i++)
		if(prob < cumProb[i])
		{
			p.X = i;
			break;
		}

	do
	{
	prob = rGen->NextDouble();
	for(int i = 0; i < cumProb->Length; i++)
		if(prob < cumProb[i])
		{
			p.Y = i;
			break;
		}
	}while (p.X == p.Y);

	return p;
}

array<Chromosome^>^ Population::reproduce(Chromosome^ male, Chromosome^ female)
{
	int nGenes = male->getNGenes();
	int crossOver = rGen->Next(nGenes);	

	array<Gene^>^ maleGenes = male->getGenes();
	array<Gene^>^ femaleGenes = female->getGenes();
	array<Gene^>^ child1Genes = gcnew array<Gene^>(nGenes);
	array<Gene^>^ child2Genes = gcnew array<Gene^>(nGenes);

	for(int i = 0; i < crossOver; i++)
	{
		child1Genes[i] = gcnew Gene(maleGenes[i]->getValue(), maleGenes[i]->getMinVal(), maleGenes[i]->getMaxVal(), rGen);
		child2Genes[i] = gcnew Gene(femaleGenes[i]->getValue(),femaleGenes[i]->getMinVal(), femaleGenes[i]->getMaxVal(), rGen);
	}

	for(int i = crossOver; i < nGenes; i++)
	{
		child1Genes[i] = gcnew Gene(femaleGenes[i]->getValue(), femaleGenes[i]->getMinVal(), femaleGenes[i]->getMaxVal(), rGen);
		child2Genes[i] = gcnew Gene(maleGenes[i]->getValue(), maleGenes[i]->getMinVal(), maleGenes[i]->getMaxVal(), rGen);
	}

	array<Chromosome^>^ children = gcnew array<Chromosome^>(2);
	children[0] = gcnew Chromosome(child1Genes, mutateAmount, solution, rGen, minVal, maxVal);
	children[1] = gcnew Chromosome(child2Genes, mutateAmount, solution, rGen, minVal, maxVal);

	return children;
}

void Population::rankPopulation()
{
	Array::Sort(chromosomes);
}

String^ Population::printChromosomes()
{
	String^ output = "";
	output += chromosomes[0]->print() + "\r\n";
	return output;
}

void Population::calcChromosomeFitness()
{
	for each(Chromosome^ c in chromosomes)
		c->calcFitness();	
}

void Population::genNewChromosomes()
{
	for(int i = 0; i < popSize; i++)
		chromosomes[i] = gcnew Chromosome(nGenes, mutateAmount, solution, rGen, minVal, maxVal);
}

void Population::runOneGen()
{
	for(int i = 0; i < eliteCount; i++)
		chromosomes[i]->setElite(true);

	int keepAmount = Math::Floor(popSize * keepProb);
	/*for(int i = chromosomes->Length - 1; i > keepAmount; i -= 2)
	{
		Point parents = selectBreedingPair();
		array<Chromosome^>^ children = reproduce(chromosomes[parents.X], chromosomes[parents.Y]);
		chromosomes[i] = children[0];
		chromosomes[i-1] = children[1];
	}*/
	for(int i = keepAmount + 1; i < popSize - 1; i += 2)
	{
		Point parents = selectBreedingPair();
		Chromosome^ parent1 = chromosomes[parents.X];
		Chromosome^ parent2 = chromosomes[parents.Y];
		array<Chromosome^>^ children = reproduce(parent1, parent2);
		chromosomes[i] = children[0];
		chromosomes[i + 1] = children[1];
	}
	mutate();

	for(int i = 0; i < eliteCount; i++)
		chromosomes[i]->setElite(false);

	calcChromosomeFitness();
	rankPopulation();
}

void Population::run(RichTextBox^ rtbOutput)
{
	while(getFittestChromosome()->getCost() > costThresh)
	{
		runOneGen();
		rtbOutput->Text = rtbOutput->Text + printChromosomes();
	}
}

void Population::mutate()
{
	for(int i = 0; i < popSize; i++)
	{
		double mut = rGen->NextDouble();
		if(mut <= mutationProb)
			chromosomes[i]->mutateGenes(rGen);	
	}
}

Chromosome^ Population::getFittestChromosome()
{
	return chromosomes[0];
}
