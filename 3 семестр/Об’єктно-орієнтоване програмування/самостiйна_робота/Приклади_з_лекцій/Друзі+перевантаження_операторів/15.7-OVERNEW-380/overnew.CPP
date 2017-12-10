#include <iostream.h>

// —ледующа€ директива "pragma" выключает предупреждение компил€тора о том,что
//в программе объ€вл€ютс€ и не используютс€ демонстрационные переменные

#pragma warn -aus

class BrandNew {
private:
int x;
public:
BrandNew();
void * operator new(size_t size);
};

char buf[512];
int index;

main()
{
cout << "\nCreating local instance";
BrandNew b1;

cout << "\nAllocating space via new";
BrandNew *b2=new BrandNew;
BrandNew *b3=new BrandNew;
BrandNew *b4=new BrandNew;
BrandNew *b5=new BrandNew;
return 0;
}
BrandNew::BrandNew()
{
cout<<"\nInside constructor" ;
x=index;
}
void *BrandNew::operator new(size_t size)
{
cout << "\nInside overloaded new. Size=="<<size;
 if (index >= 512 - sizeof(BrandNew))
return 0;
else {
int k = index;
index += sizeof(BrandNew);
return &buf[k];
}
 }