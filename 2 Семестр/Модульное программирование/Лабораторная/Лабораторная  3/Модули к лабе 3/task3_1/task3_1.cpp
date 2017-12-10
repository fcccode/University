#include <iostream>
#include <clocale>


using namespace std;

void task3_1()
{   setlocale(LC_ALL, "rus");
    cout << "\t\t***Задача №3_1" << endl;
    cout << "\t***Введите объем использованного газа" << endl;
    double x;
    int mat=9;
while (!(cin>>x))
{   cin.clear();
    cin.ignore(mat, '\n');
    cout << " Некорректное значение " << endl; };
if (x == 0)   cout << "Значение должно быть больше нуля" << endl;
else if (x<0) cout << "Значение не должно быть отрицательным" << endl;
else
{     if ((x>0)&&(x<208))    cout << (x*1.299)<< " гр. \n";
else  if ((x>=208)&&(x<500)) cout << (x*1.798)<< " гр. \n";
else  if (x>=500)            cout << (x*3.645)<< " гр. \n";}
}
