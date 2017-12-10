// db.h -- Объявление шаблонного класса TDatabase 
   #ifdef 	__DB_H
#define __DB_H 1	// Предотвращение нескольких #include
Template<class T> 
class TDatabase { 
private:
T *rp;	// Указатель на записи
int num;	// Число записей
public: 
TDatabase(int n)
{ rp = new T[num = n]; } 
~TDatabase ()
{ deleted rp; } 
void DoNothing(void); 
T &GetRecord(int recnum);
};
template<class T>
void TDatabase<T>::DoNothing(void)
{
}
template<class T>
T &TDatabase<T>::GetRecord(int recnum)
{
T *crp = rp; // Указатель на текущую запись = указатель на записи 
if (0 <= recnum && recnum < num) 
while (recnum-- > 0) crp++; 
return *crp;
}
#endif //	DB_H
