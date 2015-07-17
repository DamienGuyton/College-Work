using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

#pragma once
ref class Node
{

private:
	int data;

public:
	Node^ Left;
	Node^ Right;
	Node^ Next; 
	Node(int startData);
	
	int	getData(){return data;}
	Node^ getLeft(){return Left;}
	Node^ getRight(){return Right;}

	
	void setData(int newData){data = newData;}
	bool isLeaf();
	virtual String^ ToString() override {return data.ToString();};
};

 