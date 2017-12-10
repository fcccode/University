#include <iostream.h>
#include <conio.h>
inline int max(int a, int b)
{
  if (a>=b)
  return a;
  else
  return b;
}
main()
{
clrscr();
int x, y, z;
cout<<"X? ";
cin>>x;
cout<<"Y? ";
cin>>y;
z=max(x, y);
cout<< "max(a, b) == " << z << '\n';
getch();
return 0;
}
