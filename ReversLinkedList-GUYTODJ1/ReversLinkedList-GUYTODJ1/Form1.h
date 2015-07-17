#pragma once
#include "LinkedList.h"
namespace ReversLinkedListGUYTODJ1 {

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
	private: System::Windows::Forms::ListBox^  lBoxOutput;
	protected: 
	private: System::Windows::Forms::Button^  btnRun;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;
		LinkedList^ linkedList;
#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->lBoxOutput = (gcnew System::Windows::Forms::ListBox());
			this->btnRun = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// lBoxOutput
			// 
			this->lBoxOutput->FormattingEnabled = true;
			this->lBoxOutput->Location = System::Drawing::Point(1, 0);
			this->lBoxOutput->Name = L"lBoxOutput";
			this->lBoxOutput->Size = System::Drawing::Size(120, 251);
			this->lBoxOutput->TabIndex = 0;
			// 
			// btnRun
			// 
			this->btnRun->Location = System::Drawing::Point(25, 257);
			this->btnRun->Name = L"btnRun";
			this->btnRun->Size = System::Drawing::Size(75, 23);
			this->btnRun->TabIndex = 1;
			this->btnRun->Text = L"run";
			this->btnRun->UseVisualStyleBackColor = true;
			this->btnRun->Click += gcnew System::EventHandler(this, &Form1::btnRun_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(246, 399);
			this->Controls->Add(this->btnRun);
			this->Controls->Add(this->lBoxOutput);
			this->Name = L"Form1";
			this->Text = L"Form1";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
				 linkedList = gcnew LinkedList();
				 for ( int i = 0 ; i < 10 ; i++)
				 {
					 linkedList->addNode(i);
				 }
				 linkedList->displayNodes(lBoxOutput);
			 }
	private: System::Void btnRun_Click(System::Object^  sender, System::EventArgs^  e) {
				 lBoxOutput->Items->Clear();
				 linkedList->reverseLinkedList();
				 linkedList->displayNodes(lBoxOutput);
			 }
	};
}

