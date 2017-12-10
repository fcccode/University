#include<iostream.h>
#include<stdio.h>

class TTime {
private:
 int year;
 int month;
 int day;
 int hour;
 int minute;
public:
 void Display(void);
 void GetTime(int &m, int &d, int &y, int &hr, int &min);
 void SetTime(int m, int d, int y, int hr, int min);
 };
 
main()
{ 
 TTime appointment;
 int month, day, year, hour, minute;
 
 appointment.SetTime(7, 14, 1996, 8, 30);
 cout << "Appointment == ";
 appointment.Display();
 appointment.GetTime(month, day, year, hour, minute);
 appointment.SetTime(month, day, year, ++hour, minute);
 cout << "Next hour == ";
 appointment.Display();
 return 0;
} 

void TTime::Display(void)
{
 char s[32];
 sprintf(s, "Date: %02d/%02d/%04d Time: %02d:%02d\n",
 month, day, year, hour, minute);
 cout << s;
}

void TTime::GetTime(int &m, int &d, int &y, int &hr, int &min)
{
 m = month;       //Возвращение данных-членов тому, кто вызвал функцию
 d = day;
 y = year;
 hr = hour;
 min = minute;
}

void TTime::SetTime(int m, int d, int y, int hr, int min)
{
 month = m;
 day = d;
 year = y;
 hour = hr;
 minute = min;
}






  