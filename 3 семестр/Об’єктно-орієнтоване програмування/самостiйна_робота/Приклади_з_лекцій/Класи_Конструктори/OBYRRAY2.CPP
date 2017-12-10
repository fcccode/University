#include <iostream.h>
#include <stdio.h>
#include "time6.h"

main()
{
 TTime tarray[6] = {
 TTime(),
 TTime(8),
 TTime(8, 1),
 TTime(8, 1, 1996),
 TTime(8, 1, 1996, 8),
 TTime(8, 1, 1996, 8 ,30),
 };
 for (int i = 0; i < 6; i++)
 tarray[i].Display();
 return 0;
}