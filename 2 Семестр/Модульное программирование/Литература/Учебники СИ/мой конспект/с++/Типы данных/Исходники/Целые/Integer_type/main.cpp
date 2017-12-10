/*/////////////////////////////////////////////
Целочисленные типы даных/////////
////////////////////////////////////////////////
Аннаев Арслан/////////////////////////
///////////////////////////////////////////////
////////////////////////////////////////////*/
#include <iostream>
#include <climits>
int fun();
using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
     // Примеры инициализации целочисленные данные
    int counts=25;
     //int counts = {25};
     //int counts {25};
     // int counts (2);
     //int counts ={}; // устанавливает значение нуля в переменую
     //int counts {};//устанавливает значение нуля в переменую

    // проверка работоспособности способов инициализации переменной
    cout << "Переменная  counts содержит значение :  "<< counts << endl;

// для определения размера переменной
int a=3;
cout <<"Переменная  содержит  значение "<<a<<""<<endl;
cout<< "Переменная  а  имеет размер "<< sizeof a <<"  байт"<<endl;
cout<<"Переменная типа integer :"<<sizeof (int )<<" байт"<<endl;
cout<<"Переменная типа short :"<<sizeof (short)<<" байт"<<endl;
cout<<"Переменная типа long :"<<sizeof (long )<<" байт"<<endl;
cout<<"Переменная типа long long :"<<sizeof (long long)<<" байт"<<endl;
cout<<"Переменная типа char :"<<sizeof (char)<<" байт"<<endl;
cout<<"Переменная типа double :"<<sizeof (double)<<" байт"<<endl;

// Пример определения максимального и минимального значения


short  b  = SHRT_MAX;
int c= INT_MAX;
long d= LONG_MAX;
long long e =LLONG_MAX;

 //Минимальное значен
short B=SHRT_MIN;
int C= INT_MIN;
long D= LONG_MIN;
long long E =LLONG_MIN;
cout<<"Типы и их максимальное значения \n\n"<<endl;

cout<<"Тип short "<<b<<endl<<endl;
cout<<"Тип long "<<d<<endl<<endl;
cout<<"Тип  integer"<<c<<endl<<endl;
cout<<"Тип  long long"<<e<<endl<<endl;
cout<<"Типы и их минимальные значения \n\n\n"<<endl;

cout<<"Тип  short"<<B<<endl<<endl;
cout<<"Тип  integer"<<C<<endl<<endl;
cout<<"Тип  long"<<D<<endl<<endl;
cout<<"Тип  long long"<<E<<endl<<endl;

// Примеры беззнаковых типов
unsigned short  t  = USHRT_MAX;
unsigned int g= UINT_MAX;
unsigned long l= ULONG_MAX;
unsigned long long ll =ULLONG_MAX;

cout<<"Тип  без знаковый short"<<t<<endl<<endl;
cout<<"Тип без знаковый   integer"<<g<<endl<<endl;
cout<<"Тип   без знаковый long"<<l<<endl<<endl;
cout<<"Тип   без знаковый  long long"<<ll<<endl<<endl;

    return 0;

}
