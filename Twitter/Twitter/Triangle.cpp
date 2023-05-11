#include "Triangle.h"
#include <iostream>
using namespace std;

Triangle::Triangle()
{
}

Triangle::Triangle(int length, int height) : Tower(length, height)
{
}

void Triangle::TriangleTower()
{
	int choice;
	cout << "If you want to calculate the perimeter of the building insert 1 if you want to print the triangle insert 2" << endl;
	cin >> choice;
	if (choice == 1) {
		cout << "The perimeter of the triangle is:" << CalculatePerimeterTriangle() << endl;
	}
	else
		if (choice == 2)
			PrintTriangle();
		else
			cout << "Wrong choice" << endl;
}

int Triangle::CalculatePerimeterTriangle()
{
	return this->GetLength() + (this->GetHeight() * 2);
}

void Triangle::PrintTriangle()
{
	if (this->GetLength() % 2 == 0 || (this->GetHeight() * 2) < this->GetLength())
		cout << "Unable to print the triangle" << endl;
	else
		//A program that ran with a large runtime
		
		{ 
			int OddNumbers = (this->GetLength() - 2) / 2; 
			int lines = this->GetHeight() - 2; 
			int AmountLines = lines / OddNumbers; 
			int rest = lines-( AmountLines * OddNumbers);
		
			int NumSpace = (this->GetLength() -1)/ 2  ;  ///Print the first line
			PrintStarts(NumSpace);
			cout << endl;
			for (int i = 0; i < rest; i++) { //Print the rows of the rest
				int NumSpace = (this->GetLength() - 3) / 2;
				PrintStarts(NumSpace);
				cout << endl;
			}
			for (int i = 3; i < this->GetLength(); i = i + 2) { // Print lines
				int NumSpace = (this->GetLength() - i) / 2;
				for (int j = 0; j < AmountLines; j++) {
					PrintStarts(NumSpace);
					cout << endl;
				}
			}
			for (int x = 1; x <= this->GetLength(); x++) { // Print the last line
				cout << "*" ;
			}
			cout << endl;
		}
	
		//A program that uses more memory space
	
	/*{
		int OddNumbers = (this->GetLength() - 2) / 2;
		int lines = this->GetHeight() - 2;
		int AmountLines = lines / OddNumbers;
		int rest = lines - (AmountLines * OddNumbers);
		char* stars = new char[this->GetLength() - 1];

		for (int i = 0; i < this->GetLength(); i++)
			stars[i] = '*';
		int indexI =this->GetLength() / 2;
		int indexJ = this->GetLength() / 2;


	}*/


}

void Triangle::PrintStarts(int NumSpace)
{
	for (int i = 1; i <= this->GetLength(); i++) {
		if (i > NumSpace && i < this->GetLength() - NumSpace + 1)
			cout << "*";
		else
			cout << " ";
	}
}

