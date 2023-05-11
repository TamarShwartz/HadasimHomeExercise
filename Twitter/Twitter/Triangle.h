#pragma once

#include "Tower.h"
class Triangle : Tower {
public:
	Triangle();
	Triangle(int length, int height);
	void  TriangleTower();
	int CalculatePerimeterTriangle();
	void PrintTriangle();
	void PrintStarts(int NumSpace);
};
