#include <iostream>
#include <clocale>


using namespace std;

void task3_1()
{   setlocale(LC_ALL, "rus");
    cout << "\t\t***������ �3_1" << endl;
    cout << "\t***������� ����� ��������������� ����" << endl;
    double x;
    int mat=9;
while (!(cin>>x))
{   cin.clear();
    cin.ignore(mat, '\n');
    cout << " ������������ �������� " << endl; };
if (x == 0)   cout << "�������� ������ ���� ������ ����" << endl;
else if (x<0) cout << "�������� �� ������ ���� �������������" << endl;
else
{     if ((x>0)&&(x<208))    cout << (x*1.299)<< " ��. \n";
else  if ((x>=208)&&(x<500)) cout << (x*1.798)<< " ��. \n";
else  if (x>=500)            cout << (x*3.645)<< " ��. \n";}
}
