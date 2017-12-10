#include <iostream.h>
#include <iomanip.h>

class TFirstClass {
private:
int count;
public:
TFirstClass() { count = 0; }
int Access(void);
};

int (TFirstClass::*myfnptr)(void);

main()
{
int i;
TFirstClass fc;
cout << "\nCall Access the normal way:\n"; 
for (i = 0; i < 9; i++)
cout << setw(8) << dec << fc.Access(); 
cout << "\n\nCall Access via the member function pointer\n"; 
myfnptr = &TFirstClass::Access; 
for (i = 0; i < 9; i++)
cout << setw(8) << dec << (fc.*myfnptr)(); 
cout << "\n\nMember function pointer and a dynamic instance\n"; 
TFirstClass *fp = new TFirstClass; 
for (i = 0; i < 9; i++)
cout << setw(8) << dec << (fp->*myfnptr)(); 
return 0;
}
int TFirstClass::Access(void)
{
return count++;
}
