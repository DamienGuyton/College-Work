#include "StdAfx.h"
#include "Tree.h"


Tree::Tree(void)
{

}

Tree::Tree(int data)
{
	rootNode = gcnew Node(data);
}
//Pre: takes in list box
//post outputs the traversal to list box 
void Tree::printTreeBreadthFirst(ListBox^ listBox)
{
	
	Node^ nodeWalker;

	MyQueue^ myQueue = gcnew MyQueue();

	myQueue->Push(rootNode);

	// while the queue is greater than 0 
	while (myQueue->Count() > 0)
	{

		nodeWalker = (Node^)myQueue->Pop();//make node walker = node at head of queue
		listBox->Items->Add(nodeWalker->ToString()); // add to list box the vaue of node walker
		Node^ leftChild = nodeWalker->getLeft();
		if(leftChild != nullptr)		
			myQueue->Push(leftChild);

		Node^ rightChild = nodeWalker->getRight();
		if(rightChild != nullptr)
			myQueue->Push(rightChild);
	}


}//End printTreeBreadthFirst

//Pre: takes in root node, start x, start y , currOffSet x, curr offset y and a graphics objec
//Post: drawa the tree
void Tree::drawTree(Node^ inputRootNode, float startX, float startY, int currOffsetX, Graphics^ graphics )
{
	//if the input node is not null recursivly call draw
	if(inputRootNode != nullptr)
	{
		
		String^ inputData = inputRootNode->ToString();		
		Font^ font = gcnew Font("Courier New", 10);
		Brush^ brush = Brushes::Black;
		Pen ^ pen = Pens::Black;

		//Calc offset
		int stringOffSetY = startY + 30 / 2 - 13;

		//Draw the node
		graphics->DrawString(inputData, font, brush, startX, stringOffSetY);
		graphics->DrawEllipse(pen,(int)startX,(int)startY,30,30);

		//calc left node position and right node position
		float leftChildX = startX - currOffsetX;
		float leftChildY = startY + currOffsetX;
		float rightChildX = startX + currOffsetX;
		float rightChildY = startY + currOffsetX;

		
		Point lineStart = Point((int)startX + 30 / 2,startY + 30); 
		Point lineEnd;
		
		if(inputRootNode->Left!=nullptr)
		{	
			lineEnd = Point(leftChildX + 30 / 2,leftChildY); 
			graphics->DrawLine(pen,lineStart,lineEnd);
		}
		
		if(inputRootNode->Right != nullptr)
		{
			lineEnd = Point(rightChildX + 30 / 2,rightChildY); 
			graphics->DrawLine(pen,lineStart,lineEnd);
		}

		drawTree(inputRootNode->Left,leftChildX,leftChildY,currOffsetX,graphics);
		drawTree(inputRootNode->Right,rightChildX,rightChildY,currOffsetX,graphics);
	}
}
