#include <iostream>
#include <cmath>
#include <clocale>


using namespace std;

void Q_Lib()
{   setlocale(LC_ALL, "rus");
    double x,y,z,Q;
    double mat=9;
            cout << "\t������ � 2_1 ���������� \"Q\"\n\n" << endl;
            cout << "������� �������� ��� x" << endl;
while(!(cin >> x))
        {   cin.clear();
            cin.ignore(mat, '\n'); //���������� �� ����������� ��������
            cout << "\t\\������������ ��������, ��������� �������:\\ \n "; };
            cout << "������� �������� ��� y" << endl;
while(!(cin >> y))
        {   cin.clear();
            cin.ignore(mat, '\n'); //���������� �� ����������� ��������
            cout << "\t\\������������ ��������, ��������� �������:\\ \n "; };
            cout << "������� �������� ��� z" << endl;
while(!(cin >> z))
        {   cin.clear();
            cin.ignore(mat, '\n'); //���������� �� ����������� ��������
            cout << "\t\\������������ ��������, ��������� �������:\\ \n "; };
if ((x!=0) && (y!=0) && (z!=0)&& (z>0))
    if ((abs((pow(z,2))*(exp(x))))/(12*x+(pow(y,2)-3.14*sqrt(z)))<=0)
            cout << "����������� ��������� �������� ���� �������������";
else {   Q = pow(x,z)-pow(y,3)+(sqrt(abs((pow(z,2))*(exp(x))))/(12*x+(pow(y,2)-3.14*sqrt(z))));
            cout << "����� " << Q << endl; }
else        cout<< " ����� : ������ �� ���� ������ ";
}
