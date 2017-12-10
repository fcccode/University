#include <iostream>
#include <cmath>
#include <clocale>


using namespace std;

void Q_Lib()
{   setlocale(LC_ALL, "rus");
    double x,y,z,Q;
    double mat=9;
            cout << "\tЗадача № 2_1 Нахождение \"Q\"\n\n" << endl;
            cout << "Введите значения для x" << endl;
while(!(cin >> x))
        {   cin.clear();
            cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
            cout << "\t\\Некорректное значение, повторите попытку:\\ \n "; };
            cout << "Введите значения для y" << endl;
while(!(cin >> y))
        {   cin.clear();
            cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
            cout << "\t\\Некорректное значение, повторите попытку:\\ \n "; };
            cout << "Введите значения для z" << endl;
while(!(cin >> z))
        {   cin.clear();
            cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
            cout << "\t\\Некорректное значение, повторите попытку:\\ \n "; };
if ((x!=0) && (y!=0) && (z!=0)&& (z>0))
    if ((abs((pow(z,2))*(exp(x))))/(12*x+(pow(y,2)-3.14*sqrt(z)))<=0)
            cout << "Подкоренное выражение недолжно быть отрицательным";
else {   Q = pow(x,z)-pow(y,3)+(sqrt(abs((pow(z,2))*(exp(x))))/(12*x+(pow(y,2)-3.14*sqrt(z))));
            cout << "ОТВЕТ " << Q << endl; }
else        cout<< " Ответ : Делить на ноль нельзя ";
}
