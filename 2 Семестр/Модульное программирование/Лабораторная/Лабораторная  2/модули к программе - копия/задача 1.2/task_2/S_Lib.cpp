#include <iostream>
#include <cmath>
#include <clocale>

using namespace std;

void S_Lib()
{   setlocale(LC_ALL, "rus");
    double x,y,z,S;
    double mat=9;
        cout << "\t������ � 2_2 ���������� \"S\"\n\n" << endl;
        cout << "\t������� �������� ��� x" << endl;
while(!(cin >> x))
    {   cin.clear();
        cin.ignore(mat, '\n'); //���������� �� ����������� ��������
        cout << "\t| ������������ ��������, ��������� ������� : |\n "; };
        cout << "\t������� �������� ��� y" << endl;
while(!(cin >> y))
    {   cin.clear();
        cin.ignore(mat, '\n'); //���������� �� ����������� ��������
        cout << "\t| ������������ ��������, ��������� ������� : |\n "; };
        cout << "\t������� �������� ��� z" << endl;
while(!(cin >> z))
    {   cin.clear();
        cin.ignore(mat, '\n'); //���������� �� ����������� ��������
        cout << "\t| ������������ ��������, ��������� ������� : |\n "; };
if      ((cos(z+z*y)+ pow(x,2))<=0)
        cout << "����������� ��������� �������� ���� �������������\n\n";
else    {S = z+3.14*(pow((2*z+1),2)-sqrt(abs(y-(z/2)))/sqrt(cos(z+z*y)+ pow(x,2)));
        cout << "����� : " << S << endl;}
}
