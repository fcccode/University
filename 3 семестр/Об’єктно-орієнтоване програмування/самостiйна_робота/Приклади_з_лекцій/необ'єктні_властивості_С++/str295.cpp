#include <iostream.h>
#include <conio.h>

int square(int a);
double square(double a);
long double square(long double a);

main()
{
 clrscr();
 int x = 10;
 double y = 20.5;
 long double z = 30.75;

 cout << square(x) << '\n';
 cout << square(y) << '\n';
 cout << square(z) << '\n';
 getch();
 return 0;
}

int square(int a)
{
 return a * a;
}

double square(double a)
{
 return a * a;
}

long double square(long double a)
{
 return a * a;
}
 