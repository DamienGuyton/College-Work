#include "LinkedList.h"
#include "Node.h"
#pragma once
ref class MyQueue
{
private:
	LinkedList^ queueNode;

public:
	MyQueue(void);
	void Push(Node^ node);
	Node^ Pop();
	int Count() {return queueNode->GetNodeCount();}
};

