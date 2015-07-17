#pragma once
using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;
#define NORTH 0
#define SOUTH 1
#define EAST 2
#define WEST 3
#define SIZE 20
#define WALLS 4
ref class Cell
{
private:
	Graphics^ graphics;		
	bool visited;	
	array<bool>^ brokenWall;
	Point^ position;
	int col;
	int row;
public:
	
	Cell(Graphics^ startGraphics, Point^ startPosition, int row, int col);
	void DeleteWall(int direction);
	void SetVisited(bool value){ visited = value;}  bool GetVisited(){return visited;}
	int GetCol(){return col;}
	int GetRow(){return row;}
	array<bool>^ GetWallsBroken(){ return brokenWall;}
	Point^ GetPosition(){return position;}
	void Draw();
};

