//time5.h -- Обьявление класа TTime

#ifndef __TIME5_H
#define __TIME5_H 1 //Поедотвращение нескольких #include

#include <iostream.h>
#include <time.h>
#include <string.h>

class TTime {
private:
 long dt;        //Дата и время - в секундах от 1 января 1970 года
public:
 void Display(void);   {cout << ctime(&dt); }
 void GetTime(int &m, int &d, int &y, int &hr, int &min);
 void SetTime(int m = -1, int d = -1, int y = -1,
 int hr = -1, int min = -1);
 void *GetSTime(void);
{
 char *cp = strdup(ctime(&dt));  
 return cp;
}
 void ChangeTime(long nminutes);  { dt += (nminutes * 60); }
};

 #endif    // __TIME5_H