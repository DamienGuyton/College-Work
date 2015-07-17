#include "StdAfx.h"
#include "LinkedList.h"

LinkedList::LinkedList()
{
	head = nullptr;
	tail = nullptr;
	nodeCount = 0;
}
//Pre: takes in a node
//Post: adds to linked list 
void LinkedList::AddNode(Node^ newNode)
{
	
	if (head == nullptr)
	{
		head = newNode;
		tail = newNode;
	}
	else
	{
		tail->Next = newNode;
		tail = newNode;
	}

	nodeCount++;
} // end 

//Pre: takes in no arguments 
//Post: removes node fom head of linked list
Node^ LinkedList::Dequeue()
{
	
	Node^ returnNode = head;

	
	DeleteNode(head);

	
	return returnNode;
}//end 

//Pre: takes in a node
//Post: deletes that node from linked list
void LinkedList::DeleteNode(Node^ nodeToDelete)
{
		
		if (head == tail)
		{
			head = nullptr;
			tail = nullptr;
		}		
		else if (head == nodeToDelete)
		{
			head = head->Next;
		}
		else
		{
			
			Node^ nodeWalker = head;
			while(nodeWalker->Next != nodeToDelete)
				nodeWalker = nodeWalker->Next;			
			nodeWalker->Next = nodeToDelete->Next;
		}
		
		nodeCount--;
} //End DeleteNode



int LinkedList::GetNodeCount()
{
	return nodeCount;
}//End GetNodeCount

bool LinkedList::IsEmpty()
{
	if (nodeCount == 0)
		return true;


	else
		return false;
}//End IsEmpty



