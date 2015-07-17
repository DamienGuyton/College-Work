#pragma once
#include "MazeManager.h"
#include "Cell.h"
namespace PerfectMaze {

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
	private: System::Windows::Forms::Button^  btnGenerate;
	private: System::Windows::Forms::Panel^  panel1;
	protected: 

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
			this->btnGenerate = (gcnew System::Windows::Forms::Button());
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->SuspendLayout();
			// 
			// btnGenerate
			// 
			this->btnGenerate->Location = System::Drawing::Point(240, 459);
			this->btnGenerate->Name = L"btnGenerate";
			this->btnGenerate->Size = System::Drawing::Size(75, 23);
			this->btnGenerate->TabIndex = 0;
			this->btnGenerate->Text = L"generate";
			this->btnGenerate->UseVisualStyleBackColor = true;
			this->btnGenerate->Click += gcnew System::EventHandler(this, &Form1::btnGenerate_Click);
			// 
			// panel1
			// 
			this->panel1->Location = System::Drawing::Point(12, 12);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(527, 441);
			this->panel1->TabIndex = 1;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(587, 513);
			this->Controls->Add(this->panel1);
			this->Controls->Add(this->btnGenerate);
			this->Name = L"Form1";
			this->Text = L"GUYTODJ1 - MAZE";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);

		}
		Graphics^ graphics;
		Random^ random;
		MazeManager^ maze;
		
#pragma endregion
	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) {
				graphics = panel1->CreateGraphics();
				random = gcnew Random();
				maze = gcnew MazeManager(graphics, random);
			 }
	private: System::Void btnGenerate_Click(System::Object^  sender, System::EventArgs^  e) {
				 maze->BuildTheMaze();
				 maze->DrawTheMaze();			

			 }

			
	};
}

