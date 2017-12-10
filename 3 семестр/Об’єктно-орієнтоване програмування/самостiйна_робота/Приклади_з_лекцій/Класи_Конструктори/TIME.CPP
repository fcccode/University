//time1.cpp -- реализация класса TTime

#include<iostream.h>
#include<stdio.h>
#include<dos.h>
#include<string.h>
#include"time1.h"

//Отображение даты и времени
void TTime::Display(void)
{
 char s[30];
 sprintf(s, "Date: %02d/%02d/%04d Time: %02d:%02d",
 month, day, year, hour, minute );
 cout << s << '\n';
}

//Возвращает текушие данные-члены дату и время
void TTime::GetTime(int &m, int &d, int &y, int &hr, int &min)
{
 m = month;       //Возвращение данных-членов тому, кто вызвал функцию
 d = day;
 y = year;
 hr = hour;
 min = minute;
}

//Устанавливает данные-члены дату и время
void TTime::SetTime(int m, int d, int y, int hr, int min)
{
 month = m;  //Присваивание аргументов данным-членам
 day = d;
 year = y;
 hour = hr;
 minute = min;
}

//Возвращает дату и время в виде строки
char *TTime::GetSTime(void)
{
 char buffer[40];  //Поольше пространства
 char *cp;         //Указатель на результат, возвращаемый функцией
 
 sprintf(buffer, "Date: %02d/%02d/%04d Time: %02d:%02d\n",
 month, day, year, hour, minute);
 cp=strdup(buffer);  //Копирование с наименьшим возможным размером
 return cp;
}

//Добавление nminutes (может быть отрицательным) к текущему времени
void TTime::ChangeTime(long nminutes)
{
 struct date ds;
 struct time ts;
 long timeinsecs;
 
 ds.da_year = year;
 ds.da_mon = month;
 ds.da_day = day;
 ts.ti_hour = hour;
 ts.ti_min = minute;
 ts.ti_sec = 0;
 ts.ti_hund = 0;
 timeinsecs = dostounix(&ds, &ts);
 timeinsecs += (nminutes * 60);
 unixtodos(timeinsecs, &ds, &ts);
 year = ds.da_year;
 month = ds.da_mon;
 day = ds.da_day;
 hour = ts.ti_hour; 
 minute = ts.ti_min; 
}









 
 
