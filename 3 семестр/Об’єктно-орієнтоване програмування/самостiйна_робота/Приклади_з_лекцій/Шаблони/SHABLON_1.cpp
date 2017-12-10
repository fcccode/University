#include <iostream.h>
#include <conio.h>
#include "minmax.h"

int max(int a, int b);
double max(double a, double b);
char max(char a, char b);

main()
{
int i1 = 100, i2 = 200;
double d1 = 3.14159, d2 = 9.87654;
char c1 ='C', c2 = 'A';

cout << "max(i1, i2) == " << max(i1, i2) << '\n';
cout << "max(d1, d2) == " << max(d1, d2) << '\n';
cout << "max(c1, c2) == " << max(c1, c2) << '\n';
getch();
return 0;
}
