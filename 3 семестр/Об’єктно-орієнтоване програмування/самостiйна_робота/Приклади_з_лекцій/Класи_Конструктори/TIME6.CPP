//time6.cpp -- реализация класса TTime

#include <dos.h>
#include "time6.h"

//Конструктор по умолчанию
TTime::TTime()
{
 dts = NULL;     //Обнуление текущей строки
 SetTime(-1, -1, -1, -1, -1);
}

//Перегружённый конструктор
TTime::TTime(int m, int d, int y, int hr, int min)
{
 dts = NULL;     //Обнуление текущей строки
 SetTime(m, d, y, hr, min);
}

//Деструктор
TTime::~TTime()
{
 delete dts;  //Удаление строки, хранящейся в объекте
}

//Удаление указателя dts
void TTime::DeleteDts(void)
{
 delete dts;   //Удаление строки, хранящейся в объекте
 dts = NULL;   //Обнуление указателя
}

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
 
 getdate(&ds);   //Взятие текущих даты и времени
 gettime(&ts); 
 if (y >= 0) ds.da_year = y;
 if (m >= 0) ds.da_mon = m;
 if (d >= 0) ds.da_day = d;
 if (hr >= 0) ts.ti_hour = hr;
 if (min >= 0) ts.ti_min = min;
 ts.ti_sec = 0;
 ts.ti_hund = 0;
 dt = dostounix(&ds, &ts);
 DeleteDts();     //Удаление текущей строки
}

const char *TTime::GetSTime(void)
{
 if (dts)                     //Возвращает текущую строку, если она инициализирована
 return dts;
 dts = strdup(ctime(&dt));
 return dts;
}

