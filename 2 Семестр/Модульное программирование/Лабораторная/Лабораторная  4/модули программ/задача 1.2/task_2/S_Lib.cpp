#include <iostream>
#include <cmath>
#include <clocale>

using namespace std;
double S;
double S_Lib(double x, double y, double z)
{
    setlocale(LC_ALL, "rus");                                       // �����������
    if ((cos(z+z*y)+ pow(x,2))<=0)                              // ������� ��� ��������� ������������ �������������� ��������
    cout << "����������� ��������� �������� ���� �������������\n\n";
    else
    S = z+3.14*(pow((2*z+1),2)-sqrt(abs(y-(z/2)))/sqrt(cos(z+z*y)+ pow(x,2)));
    return S;
}
