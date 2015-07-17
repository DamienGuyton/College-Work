#include "StdAfx.h"
#include "MyQueue.h"

//constructor
MyQueue::MyQueue(void)
{
	queueNode = gcnew LinkedList();
}

//push  queue node
void MyQueue::Push(Node^ node)
{
	queueNode->AddNode(node);
}//End Push

//Deque queue  node  from myquueue
Node^ MyQueue::Pop()
{
	return queueNode->Dequeue();
}//End Pop