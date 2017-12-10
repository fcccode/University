#include <iostream.h>
#include <stdio.h>
#include "time6.h"

main()
{
 TTime t1;
 TTime t2(8);
 TTime t3(8, 1);
 TTime t4(8, 1, 1996);
 TTime t5(8, 1, 1996, 8);
 TTime t6(8, 1, 1996, 8, 30);
 
 t1.Display();
 t2.Display();
 t3.Display();
 t4.Display();
 t5.Display();
 t6.Display();
 return 0;
}
