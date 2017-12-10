//time2.cpp -- реализация класса TTime

#include <iostream.h>
#include <time.h>
#include <dos.h>
#include <string.h>
#include "time2.h"

//Отображение даты и времени
void TTime::Display(void)
{
  cout << ctime(&dt);
}

//Возвращает текушие данные-члены (дату и время)
void TTime::GetTime(int &m, int &d, int &y, int &hr, int &min)
{
 struct date ds;
 struct time ts;
 
 unixtodos(dt, &ds, &ts);
 y = ds.da_year;
 m = ds.da_mon;
 d = ds.da_day;
 hr = ts.ti_hour; 
 min = ts.ti_min; 
}

//Устанавливает член dt
void TTime::SetTime(int m, int d, int y, int hr, int min)
{
 struct date ds;
 struct time ts;
 
 ds.da_year = y;
 ds.da_mon = m;
 ds.da_day = d;
 ts.ti_hour = hr;
 ts.ti_min = min;
 ts.ti_sec = 0;
 ts.ti_hund = 0;
 dt = dostounix(&ds, &ts);
}

//Возвращает дату и время в виде строки
char *TTime::GetSTime(void)
{
 char *cp = strdup(ctime(&dt));  
 return cp;
}

//Добавление nminutes (может быть отрицательным) к текущему времени
void TTime::ChangeTime(long nminutes)
{
 dt += (nminutes + 60);
}









 
 
