#include <iostream>
#include <cmath>
#include <clocale>

using namespace std;

void S_Lib()
{   setlocale(LC_ALL, "rus");
    double x,y,z,S;
    double mat=9;
        cout << "\tЗадача № 2_2 Нахождение \"S\"\n\n" << endl;
        cout << "\tВведите значения для x" << endl;
while(!(cin >> x))
    {   cin.clear();
        cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
        cout << "\t| Некорректное значение, повторите попытку : |\n "; };
        cout << "\tВведите значения для y" << endl;
while(!(cin >> y))
    {   cin.clear();
        cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
        cout << "\t| Некорректное значение, повторите попытку : |\n "; };
        cout << "\tВведите значения для z" << endl;
while(!(cin >> z))
    {   cin.clear();
        cin.ignore(mat, '\n'); //удерживаем от дальнейшего выполнен
        cout << "\t| Некорректное значение, повторите попытку : |\n "; };
if      ((cos(z+z*y)+ pow(x,2))<=0)
        cout << "Подкоренное выражение недолжно быть отрицательным\n\n";
else    {S = z+3.14*(pow((2*z+1),2)-sqrt(abs(y-(z/2)))/sqrt(cos(z+z*y)+ pow(x,2)));
        cout << "ОТВЕТ : " << S << endl;}
}
