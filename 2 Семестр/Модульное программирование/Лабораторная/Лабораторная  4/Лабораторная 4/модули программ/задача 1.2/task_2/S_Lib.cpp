#include <iostream>
#include <cmath>
#include <clocale>

using namespace std;
double S;
double S_Lib(double x, double y, double z)
{
    setlocale(LC_ALL, "rus");                                       // локализация
    if ((cos(z+z*y)+ pow(x,2))<=0)                              // условия для получения подкоренного положительного значения
    cout << "Подкоренное выражение недолжно быть отрицательным\n\n";
    else
    S = z+3.14*(pow((2*z+1),2)-sqrt(abs(y-(z/2)))/sqrt(cos(z+z*y)+ pow(x,2)));
    return S;
}
