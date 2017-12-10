#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;
int x,y,z;
int mat=9;
void  hex_oct ()
{       setlocale(LC_ALL, "rus");
        cout << "\tПеревод системы счисления" << endl;
        cout << "\tВведите значения для x" << endl;
while(!(cin >> x))
    {   cin.clear();
            cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
        cout << "\t\\Некорректное значение, повторите попытку:\\ \n "; };
            cout << "\tВведите значения для y" << endl;
while(!(cin >> y))
    {   cin.clear();
            cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
        cout << "\t\\Некорректное значение, повторите попытку:\\ \n "; };
            cout << "\tВведите значения для z" << endl;
while(!(cin >> z))
    {       cin.clear();
        cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
            cout << "\t\\Некорректное значение, повторите попытку:\\ \n ";  };
        cout << hex << uppercase << "Значение x в шестнадцатеричной системе счислении :"  << x << endl;
            cout << hex << uppercase << "Значение y в шестнадцатеричной системе счислении :" << y << endl;
        cout << hex << uppercase << "Значение z в шестнадцатеричной системе счислении :" << z << endl;
            cout << oct << "Значение x в восьмеричной системе счислении :" << x << endl;
        cout << oct << "Значение y в восьмеричной системе счислении :" << y << endl;
            cout << oct << "Значение z в восьмеричной системе счислении :" << z << endl;
}
