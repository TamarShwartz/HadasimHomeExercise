#pragma once


class Tower {
private:
	int  Length;
	int  Height;

public:
	Tower();
	Tower(int length, int height);

	int GetLength();
	int GetHeight();

	void SetLength(int length);
	void SetHeight(int height);

};