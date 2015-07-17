#pragma once
#include "Node.h"
using namespace System::Windows::Forms;
ref class LinkedList
{
private:
	Node^ head;
	Node^ tail;
	int nodeCount;

public:
	LinkedList();
	Node^ addNode(int startValue);
	bool deleteNode(Node^ nodeToDelete);
	Node^ findNode(int findValue);
	int getNodeCount();
	bool isEmpty();
	void displayNodes(ListBox^ theListBox);
	void clearLinkedList();
	void reverseLinkedList();
};

