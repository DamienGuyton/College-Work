#pragma once
#define EMPTY -99999
ref class Node
{
private:
	int nodeData;

public:
	Node^ Next;

	Node();
	Node(int startData);
	int getNodeData()  {return nodeData;}
	void setNodeData(int nodeData) {this->nodeData = nodeData;}
};

