//time1.h -- Обьявление класа TTime

#ifndef _ _TIME1_H
#define _ _TIME1_H 1 //Поедотвращение нескольких #include

class TTime {
private:
 int month;
 int day;
 int year;
 int hour;
 int minute;
public:
 void Display(void);
 void GetTime(int &m, int &d, int &y, int &hr, int &min);
 void SetTime(int m, int d, int y, int hr, int min);
 void *GetSTime(void);
 void ChangeTime(long nminutes);
};

 #endif    // __TIME1_H