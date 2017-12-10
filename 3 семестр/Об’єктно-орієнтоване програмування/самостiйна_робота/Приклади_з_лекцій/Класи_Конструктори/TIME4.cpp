//time4.cpp -- реализация класса TTime

#include <dos.h>
#include "time4.h"

//Возвращает текушие данные-члены дату и время
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
 
 getdate(&ds);   //Получение текущих даты и времени
 gettime(&ts); 
 if (y >= 0) ds.da_year = y;
 if (m >= 0) ds.da_mon = m;
 if (d >= 0) ds.da_day = d;
 if (hr >= 0) ts.ti_hour = hr;
 if (min >= 0) ts.ti_min = min;
 ts.ti_sec = 0;
 ts.ti_hund = 0;
 dt = dostounix(&ds, &ts);
}

void TTime::SetTime(int m, int d, int y, int hr)
{
 SetTime(m, d, y, hr, -1);
}

void TTime::SetTime(int m, int d, int y)
{
 SetTime(m, d, y, -1, -1);
}

void TTime::SetTime(int m, int d)
{
 SetTime(m, d, -1, -1, -1);
}

void TTime::SetTime(int m)
{
 SetTime(m, -1, -1, -1, -1);
}

void TTime::SetTime(void)
{
 SetTime(-1, -1, -1, -1, -1);
}
