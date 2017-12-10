#include <iostream.h>
#include <stdio.h>
#include "time6.h"

main()
{
 TTime *tarrayP;
 
 tarrayP = new TTime[6];      //Создание динамического массива
 for (int i = 0; i < 6; i++)
 tarrayP[i].Display();
 delete[] tarrayP;        //Обратите внимание на особую форму delete
 return 0;
} 