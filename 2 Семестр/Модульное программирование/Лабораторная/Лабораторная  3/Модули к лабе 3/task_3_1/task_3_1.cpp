#include <iostream>
#include <clocale>

using namespace std;

double task_3_1()
{   setlocale(LC_ALL, "rus");
    cout << "������ �1" << endl;
    cout << "������� ����� ��������������� ����" << endl;
    double x,y;
    int mat=9;
while (!(cin>>x))
{   cin.clear();
    cin.ignore(mat, '\n');
    cout << " ������������ �������� " << endl; };
if (x == 0)   cout << "�������� ������ ���� ������ ����" << endl;
else if (x<0) cout << "�������� �� ������ ���� �������������" << endl;
else
{     if ((x>0)&&(x<208))    y=x*1.299;
else  if ((x>=208)&&(x<500)) y=x*1.798;
else  if (x>=500)            y=x*3.645;
}
    return y;
}
