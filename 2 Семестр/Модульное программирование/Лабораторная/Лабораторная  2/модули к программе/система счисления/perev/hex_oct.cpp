#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;
int x,y,z;
int INT_MAX=9;
void  hex_oct (int, int ,int)
{
    cout << "\t������� �������� ��� x" << endl;

while(!(cin >> x))
    {
        cin.clear();
        cin.ignore(INT_MAX, '\n'); //���������� �� ����������� ��������
        cout << "\t\\������������ ��������, ��������� �������:\\ \n ";
    };

cout << "\t������� �������� ��� y" << endl;
while(!(cin >> y))
    {
        cin.clear();
        cin.ignore(INT_MAX, '\n'); //���������� �� ����������� ��������
        cout << "\t\\������������ ��������, ��������� �������:\\ \n ";
    };

cout << "\t������� �������� ��� z" << endl;
while(!(cin >> z))
    {
        cin.clear();
        cin.ignore(INT_MAX, '\n'); //���������� �� ����������� ��������
        cout << "\t\\������������ ��������, ��������� �������:\\ \n ";
    };
cout << hex << uppercase << "�������� x � ����������������� ������� ��������� :"  << x << endl;
cout << hex << uppercase << "�������� y � ����������������� ������� ��������� :" << y << endl;
cout << hex << uppercase << "�������� z � ����������������� ������� ��������� :" << z << endl;
cout << oct << "�������� x � ������������ ������� ��������� :" << x << endl;
cout << oct << "�������� y � ������������ ������� ��������� :" << y << endl;
cout << oct << "�������� z � ������������ ������� ��������� :" << z << endl;
}
int main()
{
    setlocale(LC_ALL, "rus");
    hex_oct(x,y,z);
    return 0;
}
