#include <iostream>
#include <iomanip>
#include <clocale>
#include <conio.h>
#include <booll.h>
#include <Q_Lib.h>
#include <S_Lib.h>
#include <hex_oct.h>
#include <Personal_Datas.h>
using namespace std;
int main()
{   setlocale(LC_ALL, "rus");
    Personal_Datas();
        int per,cl;
        char ch;
        int mat=9;
do {    cout << "\n\t�������� �������� ��� ����������\n\n"
         << " �1   -��������� ���� ��������   : \n"
         << " �2   -������� ������� ��������� : \n"
         << " �3   -������ � 1                : \n"
         << " �4   -������ � 2                : \n";
 while(!(cin >> per))
    {   cin.clear();
        cin.ignore(mat, '\n');
        cout << "\a\t\\������������ ��������, �������� �� 1 �� 4 :\\ \n ";  };
switch (per)
    {   case 1 : bool_1();  break;
        case 2 : hex_oct(); break;
        case 3 : Q_Lib();  break;
        case 4 : S_Lib();  break;
        default : cout << "������������ ����\n";}
        cout << "��������� ���������?\n ��:  ������� \"Y\"\n ���: ������� \"N\"\n";
        ch = getch();
switch (ch)
    {   case 'Y' : cl=1; break;
        default : cout << "����������� ����\n";}
} while(cl!=1);
return 0;
}
