#include <iostream.h>
#include <stdio.h>
#include "time6.h"

void f(void);

main()
{
 f();
 return 0;
}

void f(void)
{
 TTime today;
 const char *sp;
 
 sp = today.GetSTime();
 cout << "First time: " << sp;
 sp = today.GetSTime();
 cout << "Second time: " << sp;
}