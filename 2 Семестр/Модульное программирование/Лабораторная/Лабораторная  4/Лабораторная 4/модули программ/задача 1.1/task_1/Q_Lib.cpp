#include <iostream>
#include <cmath>
#include <clocale>

using namespace std;
double Q;
double Q_Lib(double x, double y, double z)
{   setlocale(LC_ALL, "rus");                                        // �����������
   if ((x!=0) && (y!=0) && (z!=0)&& (z>0))                           // ������ ��� ��������� �������������� ����������
   if ((abs((pow(z,2))*(exp(x))))/(12*x+(pow(y,2)-3.14*sqrt(z)))<=0) // ����������
   cout << "����������� ��������� �������� ���� �������������";
   else Q = pow(x,z)-pow(y,3)+(sqrt(abs((pow(z,2))*(exp(x))))/(12*x+(pow(y,2)-3.14*sqrt(z))));
   else  cout<< " ����� : ������ �� ���� ������ ";                   // ���� �� ���������� ������ �������  �� ��������� ���������
return Q;
}
