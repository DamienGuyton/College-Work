#include "stdafx.h"
#include "LinkedList.h"


LinkedList::LinkedList()
{
	head = nullptr;
	tail = nullptr;
	nodeCount = 0;
}

Node^ LinkedList::addNode(int startValue)
{
	//create the node
	Node^ newNode = gcnew Node(startValue);

	
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
	return newNode;
} // end addNode

bool LinkedList::deleteNode(Node^ nodeToDelete)
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

		
		return true;
} // end deleteNode

Node^ LinkedList::findNode(int findValue)
{
	Node^ nodeWalker;
	Node^ foundNode;

	foundNode = nullptr;
	nodeWalker = head;

	while (nodeWalker != nullptr)
	{
		if (nodeWalker->getNodeData() == findValue)
		{
			foundNode = nodeWalker;
			break;
		}
		nodeWalker = nodeWalker->Next;
	}

	return foundNode;
} // end findNode

int LinkedList::getNodeCount()
{
	return nodeCount;
}

bool LinkedList::isEmpty()
{
	if (nodeCount == 0)
		return true;
	else
		return false;
}

void LinkedList::displayNodes(ListBox^ theListBox)
{
	
	Node^ nodeWalker;
	int currNodeValue;
	int count = 0;
	nodeWalker = head;

	while (nodeWalker != nullptr)
	{
		count++;
		currNodeValue = nodeWalker->getNodeData();
		theListBox->Items->Add(currNodeValue);
		nodeWalker = nodeWalker->Next;
	}

}

void LinkedList::clearLinkedList()
{
	
	head = nullptr;
	tail = nullptr;
	nodeCount = 0;
}

void LinkedList::reverseLinkedList()
{
	
	Node^ previous = head;
	Node^ curr = previous->Next;
	Node^ next = curr->Next;
	previous->Next = nullptr;
	head = tail;
	tail = previous;
	while(next != nullptr)
	{
		curr->Next = previous;
		previous = curr;
		curr = next;
		next = curr->Next;
	}
	curr->Next = previous;

}
