
#include <iostream>
#include "Tower.h"
#include "Rectangle.h"
#include "Triangle.h"
using namespace std;

int main()
{

    string choice;
    int l, w;
    while (choice != "exit")
    {
        cout << "Which tower do you want, rectangle or triangle? If you want to exit, write exit " << endl;
        cin >> choice;
        if (choice == "exit")
            continue;
        if (choice != "rectangle" && choice != "triangle")
        {
            cout << "Wrong choice" << endl;
            continue;
        }
        cout << " Please enter tower length and height" << endl;
        cin >> l;
        cin >> w;
        if (choice == "rectangle") {
            Rectangle* tower = new Rectangle(l, w);
            tower->RectangularTower();
        }
        else {
            Triangle* tower = new Triangle(l, w);
            tower->TriangleTower();
        }
    }

}
