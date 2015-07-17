#pragma once
#include "FizzBuzzManager.h"
namespace FizzBuzz {

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
	private: System::Windows::Forms::ListBox^  lBoxFizzBuzz;
	protected: 
	private: System::Windows::Forms::Button^  btnRun;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

		FizzBuzzManager^ FBM;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->lBoxFizzBuzz = (gcnew System::Windows::Forms::ListBox());
			this->btnRun = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// lBoxFizzBuzz
			// 
			this->lBoxFizzBuzz->FormattingEnabled = true;
			this->lBoxFizzBuzz->Location = System::Drawing::Point(23, 12);
			this->lBoxFizzBuzz->Name = L"lBoxFizzBuzz";
			this->lBoxFizzBuzz->Size = System::Drawing::Size(163, 407);
			this->lBoxFizzBuzz->TabIndex = 0;
			// 
			// btnRun
			// 
			this->btnRun->Location = System::Drawing::Point(23, 434);
			this->btnRun->Name = L"btnRun";
			this->btnRun->Size = System::Drawing::Size(163, 23);
			this->btnRun->TabIndex = 1;
			this->btnRun->Text = L"RUN";
			this->btnRun->UseVisualStyleBackColor = true;
			this->btnRun->Click += gcnew System::EventHandler(this, &Form1::btnRun_Click);
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(212, 468);
			this->Controls->Add(this->btnRun);
			this->Controls->Add(this->lBoxFizzBuzz);
			this->Name = L"Form1";
			this->Text = L"FizzBuzz";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
				 
			 }
	private: System::Void btnRun_Click(System::Object^  sender, System::EventArgs^  e) {
				 int min =1;
				 int max =100;
				 FBM = gcnew FizzBuzzManager(min,max);
				 FBM->Run(lBoxFizzBuzz);
			 }
	};
}

