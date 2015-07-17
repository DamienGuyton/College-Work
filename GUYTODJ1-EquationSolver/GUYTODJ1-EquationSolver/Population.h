#pragma once
#include "Chromosome.h"

using namespace System;
using namespace System::Drawing;
using namespace System::Windows::Forms;

ref class Population
{
private:
	array<Chromosome^>^ chromosomes;
	double mutationProb;
	int popSize;
	int nGenes;
	int minVal;
	int maxVal;
	int mutateAmount;
	double keepProb;
	int eliteCount;
	int costThresh;
	Random^ rGen;
	String^ solution;
	array<double>^ cumProb;
	void calcCumProb();
	Point selectBreedingPair();
	array<Chromosome^>^ reproduce(Chromosome^ male, Chromosome^ female);
	void rankPopulation();
	void calcChromosomeFitness();
	void genNewChromosomes();
	void mutate();	
	Chromosome^ getFittestChromosome();
public:
	Population(int size, double mutationChance, double startKeepProb, int nElite, int costThreshold, String^ startSolution, int startNGenes, int startMutationAmount, int startMinVal, int startMaxVal, Random^ startRGen);
	void run(RichTextBox^ rtbOutput);
	String^ printChromosomes();
	void runOneGen();
};
