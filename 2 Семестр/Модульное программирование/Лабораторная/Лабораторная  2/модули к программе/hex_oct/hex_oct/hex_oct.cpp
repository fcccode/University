#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;
int x,y,z;
int mat=9;
void  hex_oct ()
{       setlocale(LC_ALL, "rus");
        cout << "\t������� ������� ���������" << endl;
        cout << "\t������� �������� ��� x" << endl;
while(!(cin >> x))
    {   cin.clear();
            cin.ignore(mat, '\n'); //���������� �� ����������� ��������
        cout << "\t\\������������ ��������, ��������� �������:\\ \n "; };
            cout << "\t������� �������� ��� y" << endl;
while(!(cin >> y))
    {   cin.clear();
            cin.ignore(mat, '\n'); //���������� �� ����������� ��������
        cout << "\t\\������������ ��������, ��������� �������:\\ \n "; };
            cout << "\t������� �������� ��� z" << endl;
while(!(cin >> z))
    {       cin.clear();
        cin.ignore(mat, '\n'); //���������� �� ����������� ��������
            cout << "\t\\������������ ��������, ��������� �������:\\ \n ";  };
        cout << hex << uppercase << "�������� x � ����������������� ������� ��������� :"  << x << endl;
            cout << hex << uppercase << "�������� y � ����������������� ������� ��������� :" << y << endl;
        cout << hex << uppercase << "�������� z � ����������������� ������� ��������� :" << z << endl;
            cout << oct << "�������� x � ������������ ������� ��������� :" << x << endl;
        cout << oct << "�������� y � ������������ ������� ��������� :" << y << endl;
            cout << oct << "�������� z � ������������ ������� ��������� :" << z << endl;
}
