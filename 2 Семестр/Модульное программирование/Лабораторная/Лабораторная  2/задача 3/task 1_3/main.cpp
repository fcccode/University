#include <iostream>
#include <iomanip>
#include <clocale>
#include <task_1.h>
#include <task1_2.h>
#include <bool_1.h>
#include <Personal_Datas.h>
#include <hex_oct.h>
#include <conio.h>

using namespace std;


int main()
{
    setlocale(LC_ALL, "rus");
    Personal_Datas();
    int per,cl;
    char ch;
    int mat=9;
          cout << "\n\t�������� �������� ��� ����������\n\n"
         << " �1   -��������� ���� ��������   : \n"
         << " �2   -������� ������� ��������� : \n"
         << " �3   -������ � 1                : \n"
         << " �4   -������ � 2                : \n";
 while(!(cin >> per))
    {
        cin.clear();
        cin.ignore(mat, '\n');
        cout << "\a\t\\������������ ��������, �������� �� 1 �� 4 :\\ \n ";
    };
    switch (per)
    {   case 1 : bool_1 (); break;
        case 2 : hex_oct(); break;
        case 3 : task_1();  break;
        case 4 : task1_2(); break;
        default : cout << "������������ ����";}
cout << "��������� ���������?\n ��:  ������� \"Y\"\n ���: ������� \"N\"\n";
do { ch = getch();
    switch (ch)
    {   case 'Y' : cl=1; break;
        case 'N' : {cl=0;
                    cout << "��������� ����\n";
                    break;}
        default :  cout << "����������� ����\n";}
   } while(cl!=1);
    return 0;
}


