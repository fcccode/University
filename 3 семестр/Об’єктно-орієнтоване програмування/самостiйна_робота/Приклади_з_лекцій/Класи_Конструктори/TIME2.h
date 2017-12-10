//time2.h -- Обьявление класа TTime

#ifndef _ _TIME2_H
#define _ _TIME2_H 1 //Поедотвращение нескольких #include

class TTime {
private:
 long dt;         //Дата и время - в секундах от 1 января 1970 года
 public:
 void Display(void);
 void GetTime(int &m, int &d, int &y, int &hr, int &min);
 void SetTime(int m, int d, int y, int hr, int min);
 void *GetSTime(void);
 void ChangeTime(long nminutes);
};

 #endif    // __TIME2_H