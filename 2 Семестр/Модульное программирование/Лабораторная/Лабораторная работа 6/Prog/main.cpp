#include <iostream>
#include <clocale>
#include <Personal_Datas.h>

using namespace std;

int main()
{
    conus abstract;
    setlocale(LC_ALL, "rus");
       cout << "������ ___\n" << endl;

    double dob_obm;
    double dob_rad;
    double dob_vys;
    double dob_plos;
    char vyh;
   int vyb,mat=50,c;
   do {
   cout << "#1 ����� ���������� ��� ������������ � ����������� ��� �� ������" << endl;
   cout << "#2 ����� ���������� ��� �������� ��������� ���������� " << endl;
   cout << "#3 ����� ���������� ��� ���� ����� " << endl;
   cout << "#4 ��������� ��������� ������\n\n" << endl;

   cout << "�������� �������� ��� ���������� ��������� "; cin >> vyb;

   switch (vyb)
   {
   case 1:  abstract.PrintDatas();
        break;
   case 2:  abstract.PrintAtributes();
        break;
   case 3:  abstract.PrintObm();
        break;
   case 4:  {
        cout << "������� �������� ��� �������\n";
    do{
    while (!(cin>>dob_rad))
{       cin.clear();
        cin.ignore(mat,'\n');
        cout << "������������ ��������\n\n";};
        cout << "������� �������� ��� ������\n";
    while (!(cin>>dob_vys))
{       cin.clear();
        cin.ignore(mat,'\n');
        cout << "������������ ��������\n\n";};
        cout << "������� �������� ��� �������\n";
    while (!(cin>>dob_plos))
{       cin.clear();
        cin.ignore(mat,'\n');
        cout << "������������ ��������\n\n";};
        if (!(dob_rad<=0)&&(dob_vys<=0)&&(dob_plos<=0))
        {
            cout << "�������� ��������� �� ������ ���� ��������������\n";
            c=0;
        }
        else {
              abstract.ChangeAtributes( dob_rad,  dob_vys,  dob_plos);
              c=1;
            }
              } while(c!=1);}
        break;
   default: cout << "��������� �������\n"<< "������������ �����\n";
    }
   cout << "��������� ���������?\n"
        << "(Y) or (N)" << endl;

   cin>> vyh;
   } while (vyh!='Y');
   return 0;
}



