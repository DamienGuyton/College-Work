#include "StdAfx.h"
#include "Node.h"

Node::Node(int startData)
{
	data = startData;
}
//pre: takes in no argumetns 
//post: returns true or false depending on wheter its a leaf
bool Node::isLeaf()
{
	if(Left == nullptr && Right == nullptr)
	{
		return true;
	}

	return false;
}

