#include<iostream.h>
#include<stdio.h>
#include "time1.h"

main()
{
 TTime appointment;
 
 appointment.SetTime(7, 21,1996, 8, 30);
 for (int slots = 1; slots <= 17; slots++){
 appointment.Display();
 appointment.ChangeTime(30);
 }
 return 0;
}
