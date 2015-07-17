#pragma once
#include "Tree.h"
namespace GUYTODJ1BreadthFirstTraversal {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}
		Graphics^ g;
		Tree^ tree;
	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Panel^  panel1;
	protected: 
	private: System::Windows::Forms::ListBox^  listBox1;
	private: System::Windows::Forms::Button^  btnRunBreadthFirst;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->listBox1 = (gcnew System::Windows::Forms::ListBox());
			this->btnRunBreadthFirst = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// panel1
			// 
			this->panel1->Location = System::Drawing::Point(12, 12);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(812, 498);
			this->panel1->TabIndex = 0;
			this->panel1->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &Form1::panel1_Paint);
			// 
			// listBox1
			// 
			this->listBox1->FormattingEnabled = true;
			this->listBox1->Location = System::Drawing::Point(850, 12);
			this->listBox1->Name = L"listBox1";
			this->listBox1->Size = System::Drawing::Size(120, 186);
			this->listBox1->TabIndex = 1;
			// 
			// btnRunBreadthFirst
			// 
			this->btnRunBreadthFirst->Location = System::Drawing::Point(870, 222);
			this->btnRunBreadthFirst->Name = L"btnRunBreadthFirst";
			this->btnRunBreadthFirst->Size = System::Drawing::Size(75, 23);
			this->btnRunBreadthFirst->TabIndex = 2;
			this->btnRunBreadthFirst->Text = L"Run Breadth First";
			this->btnRunBreadthFirst->UseVisualStyleBackColor = true;
			this->btnRunBreadthFirst->Click += gcnew System::EventHandler(this, &Form1::btnRunBreadthFirst_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1019, 556);
			this->Controls->Add(this->btnRunBreadthFirst);
			this->Controls->Add(this->listBox1);
			this->Controls->Add(this->panel1);
			this->Name = L"Form1";
			this->Text = L"GUYTODJ1-BreadthFirstTraversal";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void btnRunBreadthFirst_Click(System::Object^  sender, System::EventArgs^  e) {
				  listBox1->Items->Clear();

				 Refresh();
				 Random^ num = gcnew Random();
				 
				 tree = gcnew Tree(50);
				 
				 Tree^ t1 = gcnew Tree(num->Next(0,100));
				 Tree^ t2 = gcnew Tree(num->Next(0,100));
				 Tree^ t3 = gcnew Tree(num->Next(0,100));
				 Tree^ t4 = gcnew Tree(num->Next(0,100));
				 Tree^ t5 = gcnew Tree(num->Next(0,100));
				 Tree^ t6 = gcnew Tree(num->Next(0,100));
				 Tree^ t7 = gcnew Tree(num->Next(0,100));
				 Tree^ t8 = gcnew Tree(num->Next(0,100));
				 Tree^ t9 = gcnew Tree(num->Next(0,100));

				 t7->setRight(t9->getRootNode());
				 t2->setLeft(t7->getRootNode());
				 t2->setRight(t6->getRootNode());
				 tree->setRight(t2->getRootNode());

				 t4->setRight(t5->getRootNode());
				 t3->setLeft(t4->getRootNode());
				 t3->setRight(t8->getRootNode());
				 t1->setLeft(t3->getRootNode());
				 tree->setLeft(t1->getRootNode());

				 tree->drawTree(tree->getRootNode(),300,100,80,g);
				 tree->printTreeBreadthFirst(listBox1);

			 }
	private: System::Void panel1_Paint(System::Object^  sender, System::Windows::Forms::PaintEventArgs^  e) {
			 }
	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
				  g = panel1->CreateGraphics();
			 }
	};
}

