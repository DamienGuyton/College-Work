#pragma once
using namespace System::Windows::Forms;
using namespace System;
ref class FizzBuzzManager
{
public:
	int min;
	int max;
	FizzBuzzManager(int min, int max);
	void Run(ListBox^ displayListBox);
};

