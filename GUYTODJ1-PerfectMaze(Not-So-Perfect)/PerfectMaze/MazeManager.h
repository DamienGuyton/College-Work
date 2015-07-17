#pragma once
#include "Cell.h"
using namespace System::Collections::Generic;
#define SIZE_OF_MAZE 20
ref class MazeManager
{
private:
	Graphics^ graphics;
	Random^ rand;
	array<Cell^,2>^ cells;
	List<Cell^>^ FindUnvisitedNeighbours(Cell^ aCell);
	bool IsLegalMove(Cell^ theCell);
	System::Collections::Generic::Stack<Cell^>^ cellStack;
	int visitedCount;

public:
	MazeManager(Graphics^ startGraphics, Random^ startRandom);
	void DrawTheMaze();
	void BuildTheMaze();
	void SmashWalls(Cell^ currCell, Cell^ nextCell);
};

