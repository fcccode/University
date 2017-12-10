#include<iostream.h>
#include<stdio.h>

class TTime{
 public:        //Спецификатор доступа
 int year;      //Данные-члены
 int month;     //" "
 int day;       //" "
 int hour;      //" "
 int minute;    //" "
 void Display(void);    //Функция-член
};

main()
{
 TTime appointment;     //Обьект типа TTime
 
 appointment.month=7;   //Инициализация данных-членов обьекта 
 appointment.day=14;
 appointment.year=1996;
 appointment.hour=8;
 appointment.minute=30;
 cout << "Appointment == ";
 appointment.Display();     //Вызов функции-члена
 cout << '\n';
 return 0;
}

void TTime::Display(void)
{
 char s[32];
 sprintf(s, "Date: %02d/%02d/%04d Time: %02d:%02d\n",
 month, day, year, hour, minute);
 cout <<s;
}

 
 
 
 
 
 