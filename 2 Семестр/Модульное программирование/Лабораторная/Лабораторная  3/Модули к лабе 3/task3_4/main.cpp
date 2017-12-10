#include <iostream>
#include <clocale>
#include  <conio.h>
#include <Personal_Datas.h>
#include <Q_Lib.h>
#include <S_Lib.h>
#include <task3_1.h>
#include <task3_2.h>
#include <transfer.h>
#include <cstdlib>

using namespace std;

int main()
{   setlocale(LC_ALL, "rus");
    Personal_Datas();
    char ch,t;
    int clk;
do {
        system ("cls");
cout << "\tВыберите действие для выполнения\n\n"
         << "№ 1 Нахождения     \"Q\"нажмите \"u\":\n"
         << "№ 2 Нахождения     \"S\"нажмите \"y\":\n"
         << "№ 3 Рещение задачи 3.1  нажмите \"t\":\n"
         << "№ 4 Рещение задачи 3.2  нажмите \"r\":\n"
         << "№ 5 Рещение задачи 3.3  нажмите \"e\":\n\n";
ch=getch();
switch (ch){
    case 'u' : Q_Lib();   break;
    case 'y' : S_Lib();   break;
    case 't' : task3_1(); break;
    case 'r' : task3_2(); break;
    case 'e' : transfer();break;
    default  : cout << "**** Неправильный выбор ****\n\n"; };
    cout << "\tПродолжить работу программы?\n Да: нажмите \"Y\"\n Нет : нажмите любую клавишу\n\n ";
t=getch();
cout << t;
switch (t)
{   case 'Y' : clk=0; break;
    default  : clk=1; }
    cin.get();
} while (clk!=1);
    return 0; }


