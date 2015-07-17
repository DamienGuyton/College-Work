using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

#include "Node.h"
#include "MyQueue.h"


#pragma once
ref class Tree 
{
protected:
	Node^ rootNode;

public:
	Tree(void);
	Tree(int data);

	void setRootNode(Node^ newRootNode)	{rootNode = newRootNode;}
	Node^ getRootNode()	{return rootNode;}
	int getRootData() {return rootNode->getData();}
	Node^ getLeft()	{return rootNode->Left;}
	Node^ getRight() {return rootNode->Right;}
	void setLeft(Node^ newLeftChild) {rootNode->Left = newLeftChild;}
	void setRight(Node^ newRightChild) {rootNode->Right = newRightChild;}	
	void printTreeBreadthFirst(ListBox^ listBox);
	void drawTree( Node^ inputRootNode, float startX, float startY, int currOffsetX, Graphics^ graphics);

};

