
#include "Rectangle.h"
#include <iostream>

using namespace std;

Rectangle::Rectangle()
{
}

Rectangle::Rectangle(int length, int height) : Tower(length, height)
{
}

void Rectangle::RectangularTower()
{
    if (this->GetLength() == this->GetHeight() || abs(this->GetLength() - this->GetHeight() > 5))
        cout << "The area of the rectangle is:" << CalculatingAreaRectangle() << endl;
    else
        cout << "The perimeter of the rectangle is:" << CalculatingPerimeterRectangle() << endl;
}

int Rectangle::CalculatingPerimeterRectangle()
{
    return (this->GetLength() + this->GetHeight()) * 2;
}

int Rectangle::CalculatingAreaRectangle()
{
    return this->GetLength() * this->GetHeight();
}
