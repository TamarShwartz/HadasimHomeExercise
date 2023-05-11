#include "Tower.h"

Tower::Tower()
{
}

Tower::Tower(int length, int height)
{
	this->Length = length;
	this->Height = height;
}

int Tower::GetLength()
{
	return this->Length;
}

int Tower::GetHeight()
{
	return this->Height;
}

void Tower::SetLength(int length)
{
	this->Length = length;
}

void Tower::SetHeight(int height)
{
	this->Height = height;
}
