using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;

#include "Node.h"

#pragma once
ref class LinkedList
{
private:
	Node^ head;
	Node^ tail;
	int nodeCount;

public:
	LinkedList();

	void AddNode(Node^ newNode);
	void DeleteNode(Node^ nodeToDelete);	
	int GetNodeCount();
	bool IsEmpty();	
	Node^ Dequeue();
};