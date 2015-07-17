#include "stdafx.h"
#include "MazeManager.h"

//Pre: takes in a graphics object and a Random object
//Post:intailizes the varibles within the constructor of the MazeManager class
MazeManager::MazeManager(Graphics^ startGraphics, Random^ startRandom)
{
	graphics =startGraphics;
	rand = startRandom;
	cellStack = gcnew System::Collections::Generic::Stack<Cell^>();
	cells = gcnew array<Cell^,2>(SIZE_OF_MAZE,SIZE_OF_MAZE);
	
	// nesteted for loops generate the 2D array of cells 
	for (int row = 0 ; row < SIZE_OF_MAZE; row++)//rows driver 
	{
		for(int col = 0; col < SIZE_OF_MAZE; col++)//cols driver
		{
			Point^ cellPosition = gcnew Point(row * SIZE, col * SIZE);//point for cell constructor
			Cell^ cell = gcnew Cell(graphics, cellPosition,row,col);//generate the cell to sit at that position in the array
			cells[row,col] = cell;// add to array
		}
	}
	
}//End constructor

//Pre: takes in no arguments 
//Post: builds the maze and tehn draws it
void MazeManager::BuildTheMaze()
{
	visitedCount = 0;

	Cell^ currCell = cells[0,0];//set intial cell
	currCell->SetVisited(true);	
	visitedCount++;


	Brush^ b = gcnew SolidBrush(Color::Red);
	graphics->FillRectangle(b,currCell->GetPosition()->X,currCell->GetPosition()->Y,SIZE,SIZE);//hilight the starting cell

	//while loop to itterate through every cell of the maze
	while (visitedCount < SIZE_OF_MAZE * SIZE_OF_MAZE )
	{
		//create a list to hold avalable cells
		List<Cell^>^ availableCells = FindUnvisitedNeighbours(currCell);	
		
		if(availableCells->Count >= 1)//if there are avalible cells 
		{
			cellStack->Push(currCell);//push the current cell to stack 			
			int numCellsAvalible = availableCells->Count;
			int nextCellDirection = rand->Next(numCellsAvalible);//generate the number to associate to a random cell in list
			Cell^ nextCell = availableCells[nextCellDirection];//get the cell out of the list at the random position
			SmashWalls(currCell,nextCell);//smash shit
			currCell = nextCell;//make current cell = to the next 
			currCell->SetVisited(true);	//set the current cell as visited 
			visitedCount++;//increment visited count 
		}
		else
		{	
			//pop the current cell off the stack
			currCell = cellStack->Pop();
		}//End If
		
	}//End While 
	
	//Draw maze
	DrawTheMaze();
}//End BuildTheMaze

//Pre:takes in two cels, the current and the next
//Post: breaks the walls within the cell depending on the direction moved
//NOTE: Directions are muddled, but works (this is a stocastic algorthim... i don't know what is happening)
void MazeManager::SmashWalls(Cell^ currCell, Cell^ nextCell)
{
	// if you have moved South
	if(currCell->GetRow() > nextCell->GetRow())
	{
		currCell->DeleteWall(WEST);
		nextCell->DeleteWall(EAST);
	}//End if

	//if you have moved north
	if(currCell->GetRow() < nextCell->GetRow())
	{
		currCell->DeleteWall(EAST);
		nextCell->DeleteWall(WEST);
	}//End if

	//if you have moved west
	if(currCell->GetCol() > nextCell->GetCol())
	{
		currCell->DeleteWall(NORTH);
		nextCell->DeleteWall(SOUTH);
	}//End if

	//if you have moved east
	if(currCell->GetCol() < nextCell->GetCol())
	{
		currCell->DeleteWall(SOUTH);
		nextCell->DeleteWall(NORTH);
	}//End if
}//End SmashWall

//Pre: takes in a cell 
//Post: checks wheter the cell has been visited or has any broken wals and returns true if it has or false if it hasn't
bool MazeManager::IsLegalMove(Cell^ theCell)
{
	
	if ( theCell->GetVisited()!=true )//check if the cell has been visited 
	{
		bool noBrokenWalls = true;
		//check each wall and if any are broken return false
		for each(bool b in theCell->GetWallsBroken())
		{
			if(b == true)
				return false;
		}//end foreach
		return true;
	}
	else
	{
		return false;
	}//END if 
}//End IsLegalMove

//Pre:takes in no arguments 
//Post: itterates trough every cell drawing it to the screen
void MazeManager::DrawTheMaze()
{
	for (int row= 0; row < SIZE_OF_MAZE; row++)//row driver
	{
		for (int col = 0; col < SIZE_OF_MAZE; col++)//col driver 
		{
			cells[row,col]->Draw();//draw at row col
		}//End For

	}//End For

}//End DrawTheMaze

//Pre: takes in a Cell
//Post: works out the cells aroud the current cell that are able to moved into and returns a list of them
List<Cell^>^ MazeManager::FindUnvisitedNeighbours(Cell^ aCell)
{
	Cell^ currCell = aCell;
	List<Cell^>^ availableCells = gcnew List<Cell^>();
	
	//if cell isn't going of the top of the panel
	if(currCell->GetRow()-1 > 0)
	{
		Cell^ northCell = cells[currCell->GetRow()-1,currCell->GetCol()];//create north cell
		if (IsLegalMove(northCell))//if cell can be moved into add to list 
			availableCells->Add(northCell);
	}
	//if cell isn't going of the bottom of the panel
	if (currCell->GetRow()+1 < SIZE_OF_MAZE)
	{
		Cell^ southCell = cells[currCell->GetRow()+1,currCell->GetCol()];//create south cell 
		if (IsLegalMove(southCell))//if cell can be moved into add to list 
			availableCells->Add(southCell);
	}

	//if cell isn't going of the top of the left of panel
	if(currCell->GetCol()-1 > 0)
	{
		Cell^ westCell =  cells[currCell->GetRow(),currCell->GetCol()-1];//create east cell
		if(IsLegalMove(westCell))//if cell can be moved into add to list 
			availableCells->Add(westCell);
	}
	//if cell isn't going of the right of the panel
	if(currCell->GetCol()+1 < SIZE_OF_MAZE)
	{
		Cell^ eastCell =  cells[currCell->GetRow(),currCell->GetCol()+1];//create west cell
		if(IsLegalMove(eastCell))//if cell can be moved into add to list 
			availableCells->Add(eastCell);
	}
	//retuns the list of availableCells
		return availableCells;
}//End FindUnvisitedNegibours 





