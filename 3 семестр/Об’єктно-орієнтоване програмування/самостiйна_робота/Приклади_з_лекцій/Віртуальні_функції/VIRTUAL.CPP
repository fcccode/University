#include <iostream.h>

class TValue{
protected:
  int value;
public:
  TValue(int n)  { value = n; }
  virtual int GetValue(void)   {return value; }
};

class TMult: public TValue{  
protected:
 int multiplier;
public:
 TMult(int n, int m):  TValue(n) {multiplier = m;}
 virtual int GetValue(void) {return value * multiplier; }
};

main()
{
 TValue *basep;
 
 basep = new TValue(10);
 cout << basep->GetValue() << '\n';     //Выведет 10
 delete basep;
 
 basep = new TMult(10,2);               //!!!
 cout << basep->GetValue() << '\n';     //!!! Вывведет 20
 delete basep;
 
 return 0;
}
 
 
 
 
 
 
 
       
 