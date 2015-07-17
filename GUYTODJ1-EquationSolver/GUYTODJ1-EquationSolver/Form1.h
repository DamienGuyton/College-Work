#pragma once
#include "Population.h"
namespace GUYTODJ1EquationSolver {

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
	private: System::Windows::Forms::RichTextBox^  output;
	protected: 
	private: System::Windows::Forms::Button^  btnRun;

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
			this->output = (gcnew System::Windows::Forms::RichTextBox());
			this->btnRun = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// output
			// 
			this->output->Location = System::Drawing::Point(90, 12);
			this->output->Name = L"output";
			this->output->Size = System::Drawing::Size(188, 250);
			this->output->TabIndex = 0;
			this->output->Text = L"";
			// 
			// btnRun
			// 
			this->btnRun->Location = System::Drawing::Point(140, 279);
			this->btnRun->Name = L"btnRun";
			this->btnRun->Size = System::Drawing::Size(75, 23);
			this->btnRun->TabIndex = 1;
			this->btnRun->Text = L"Run";
			this->btnRun->UseVisualStyleBackColor = true;
			this->btnRun->Click += gcnew System::EventHandler(this, &Form1::btnRun_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(353, 341);
			this->Controls->Add(this->btnRun);
			this->Controls->Add(this->output);
			this->Name = L"Form1";
			this->Text = L"GUYTODJ1 - EquationSolver";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void btnRun_Click(System::Object^  sender, System::EventArgs^  e) {
				 output->Clear();
				  Population^ pop = gcnew Population(30, 0.1, 0.5, 0, 0, "42", 4, 1, 1, 0, gcnew Random());
				pop->run(output);
			 }
	};
}

