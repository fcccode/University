//time2.h -- ���������� ����� TTime

#ifndef _ _TIME2_H
#define _ _TIME2_H 1 //�������������� ���������� #include

class TTime {
private:
 long dt;         //���� � ����� - � �������� �� 1 ������ 1970 ����
 public:
 void Display(void);
 void GetTime(int &m, int &d, int &y, int &hr, int &min);
 void SetTime(int m, int d, int y, int hr, int min);
 void *GetSTime(void);
 void ChangeTime(long nminutes);
};

 #endif    // __TIME2_H