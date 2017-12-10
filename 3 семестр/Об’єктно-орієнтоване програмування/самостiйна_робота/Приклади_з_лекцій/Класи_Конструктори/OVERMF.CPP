#include <iostream.h>
#include <stdio.h>
#include "time4.h"

main()
{
 TTime appointment;
 
 appointment.SetTime();
 appointment.Display();
 appointment.SetTime(8);
 appointment.Display();
 appointment.SetTime(8, 1);
 appointment.Display();
 appointment.SetTime(8, 1, 1996);
 appoint ment.Display();
 appointment.SetTime(8, 1, 1996, 8);
 appointment.Display();
 appointment.SetTime(8, 1, 1996, 8, 30);
 appointment.Display();
 return 0;
}