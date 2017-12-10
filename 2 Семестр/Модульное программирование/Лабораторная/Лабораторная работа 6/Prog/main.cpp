#include <iostream>
#include <clocale>
#include <Personal_Datas.h>

using namespace std;

int main()
{
    conus abstract;
    setlocale(LC_ALL, "rus");
       cout << "Задача ___\n" << endl;

    double dob_obm;
    double dob_rad;
    double dob_vys;
    double dob_plos;
    char vyh;
   int vyb,mat=50,c;
   do {
   cout << "#1 Вывод информации про разработчика и университет где он учится" << endl;
   cout << "#2 Вывод информации про значения атрибутов абстракции " << endl;
   cout << "#3 Вывод информации про свой объем " << endl;
   cout << "#4 Изменение атрибутов конуса\n\n" << endl;

   cout << "Выберите значение для выполнения программы "; cin >> vyb;

   switch (vyb)
   {
   case 1:  abstract.PrintDatas();
        break;
   case 2:  abstract.PrintAtributes();
        break;
   case 3:  abstract.PrintObm();
        break;
   case 4:  {
        cout << "Введите значение для радиуса\n";
    do{
    while (!(cin>>dob_rad))
{       cin.clear();
        cin.ignore(mat,'\n');
        cout << "Некорректное значение\n\n";};
        cout << "Введите значение для высоты\n";
    while (!(cin>>dob_vys))
{       cin.clear();
        cin.ignore(mat,'\n');
        cout << "Некорректное значение\n\n";};
        cout << "Введите значение для площади\n";
    while (!(cin>>dob_plos))
{       cin.clear();
        cin.ignore(mat,'\n');
        cout << "Некорректное значение\n\n";};
        if (!(dob_rad<=0)&&(dob_vys<=0)&&(dob_plos<=0))
        {
            cout << "Значения атрибутов не должны быть отрицательными\n";
            c=0;
        }
        else {
              abstract.ChangeAtributes( dob_rad,  dob_vys,  dob_plos);
              c=1;
            }
              } while(c!=1);}
        break;
   default: cout << "Повторите попытку\n"<< "Некорректный выбор\n";
    }
   cout << "Завершить программу?\n"
        << "(Y) or (N)" << endl;

   cin>> vyh;
   } while (vyh!='Y');
   return 0;
}



