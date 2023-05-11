#pragma once
#include "Tower.h"
class Rectangle : Tower {
public:
	Rectangle();
	Rectangle(int length, int height);
	void  RectangularTower();
	int CalculatingPerimeterRectangle();
	int CalculatingAreaRectangle();
};