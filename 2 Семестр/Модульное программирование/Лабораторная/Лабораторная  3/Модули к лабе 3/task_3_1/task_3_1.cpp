#include <iostream>
#include <clocale>

using namespace std;

double task_3_1()
{   setlocale(LC_ALL, "rus");
    cout << "Задача №1" << endl;
    cout << "Введите объем использованного газа" << endl;
    double x,y;
    int mat=9;
while (!(cin>>x))
{   cin.clear();
    cin.ignore(mat, '\n');
    cout << " Некорректное значение " << endl; };
if (x == 0)   cout << "Значение должно быть больше нуля" << endl;
else if (x<0) cout << "Значение не должно быть отрицательным" << endl;
else
{     if ((x>0)&&(x<208))    y=x*1.299;
else  if ((x>=208)&&(x<500)) y=x*1.798;
else  if (x>=500)            y=x*3.645;
}
    return y;
}
