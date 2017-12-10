//time6.h -- Обьявление класа TTime

#ifndef __TIME6_H
#define __TIME6_H 1 //Поедотвращение нескольких #include

#include <iostream.h>
#include <time.h>
#include <string.h>

class TTime {
private:
 long dt;        //Дата и время - в секундах от 1 января 1970 года
 char *dts;      //Представление даты и времени в виде строки
 void DeleteDts(void);    //Удаляет указатель dts
public:
 TTime();              //Конструктор
 TTime(int m, int d = -1, int y = -1,         //Конструктор
 int hr = -1, int min = -1);
 ~TTime();            //Деструктор
 void Display(void);   {cout << ctime(&dt); }
 void GetTime(int &m, int &d, int &y, int &hr, int &min);
 void SetTime(int m = -1, int d = -1, int y = -1,
 int hr = -1, int min = -1);
 const char *GetSTime(void);
 void ChangeTime(long nminutes)
 { dt += (nminutes * 60); DeleteDts(); }
};

 #endif    // __TIME6_H