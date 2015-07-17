#include "stdafx.h"
#include "Node.h"


Node::Node()
{
	nodeData = EMPTY;
	Next = nullptr;
}

Node::Node(int startData)
{
	nodeData = startData;
	Next = nullptr;
}
