#include <iostream.h>
#include <math.h>
#include <conio.h>
#include <except.h>
class Error {};
float msqrt(float a) throw (const char *)
{
  if (a<0) throw "Error!\n";
  if (a>20) throw  Error();
  return sqrt(a);
}
void nvc() {
cout << "Error! Number out of range!";
getch();
}
void main ()
{
  set_unexpected(nvc);
  float c;
  int i;
  for (i=0;i<5;i++)
  try
  {
	 cout<<"Input value> ";
	 cin>>c;
	 cout<<msqrt(c)<<"\n";
  }
  catch (const char *mess)
  {
	 cout<<mess;
  }
}
