#ifndef __DB_H
#define __DB_H

template<class T>
class TDatabase
{
private:
T *rp;
int num;
public:
TDatabase(int n)
{
rp = new T[num = n];
}
~TDatabase()
{
delete[] rp;
}
void DoNothing(void);
T &GetRecord(int recnum);
};

template<class T>
T &TDatabase<T>::GetRecord(int recnum)
{
T *crp = rp;
if (0 <= recnum && recnum<num)
while (recnum--> 0)
crp++;
return *crp;
}
#endif 

