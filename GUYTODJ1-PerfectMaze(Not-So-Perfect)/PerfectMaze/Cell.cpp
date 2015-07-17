#include "stdafx.h"
#include "Cell.h"

//Pre:takes in a graphics object the start point the row and col
//Post:initalizes all variables and sets all walls to not being broken
Cell::Cell(Graphics^ startGraphics, Point^ startPosition, int newRow, int newCol)
{
	graphics = startGraphics;
	col = newCol;
	row = newRow;
	position = startPosition;
	visited = false;
	brokenWall = gcnew array<bool>(WALLS);
	//loop setting walls to not broken
	for(int i = 0; i < WALLS; i++)
		brokenWall[i] = false;
}
//Pre:takes in the side (direction)
//Post: use he direction to remove  that particular wall
void Cell::DeleteWall(int side)
{
	brokenWall[side] = true;//set the side of the wall to broke
}//End Delete wall

//Pre: takes in no arguments 
//Post: checks each wall before the cell draws to check which walls not to draw
void Cell::Draw()
{
	Pen^ p = Pens::Black;//create the pen to draw the walls 
	//if north cell wall isn't broken draw it 
	if (brokenWall[NORTH] == false)
	{
		int x1 = position->X;
		int y1 = position->Y;
		int x2 = x1 + SIZE;
		int y2 = position->Y;

		graphics->DrawLine(p,x1,y1,x2,y2);//draw 
	}//end if 

	//if south cell wall isn't broken draw it 
	if (brokenWall[SOUTH] == false)
	{
		int x1 = position->X;
		int y1 = position->Y + SIZE;
		int x2 = position->X + SIZE;
		int y2 = position->Y + SIZE;

		graphics->DrawLine(p,x1,y1,x2,y2);//draw
	}//end if 

	//if east cell wall isn't broken draw it 
	if (brokenWall[EAST] == false)
	{
		int x1 = position->X + SIZE;
		int y1 = position->Y;
		int x2 = position->X + SIZE;
		int y2 = position->Y + SIZE;

		graphics->DrawLine(p,x1,y1,x2,y2);//draw
	}//end if 

	//if west cell wall isn't broken draw it 
	if(brokenWall[WEST] == false)
	{
		int x1 = position->X;
		int y1 = position->Y;
		int x2 = position->X;
		int y2 = position->Y + SIZE;

		graphics->DrawLine(p,x1,y1,x2,y2);//draw
	}//end if 
}//end draw 
