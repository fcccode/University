#include <iostream.h>
#include <conio.h>

main()
{
 clrscr();
 int ivar = 1234; // змінній привласнено значення
 int *iptr = &ivar; // вказівнику привласнена адреса ivar
 int &iref = ivar; // посилки асоційована з ivar
 int *p = &iref; // вказівнику привласнено адресу іref

 cout << "ivar == " << ivar <<endl;
 cout << "*iptr == " << *iptr <<endl;
 cout << "*p == " << *p <<endl;
 getch();
 return 0;
} 