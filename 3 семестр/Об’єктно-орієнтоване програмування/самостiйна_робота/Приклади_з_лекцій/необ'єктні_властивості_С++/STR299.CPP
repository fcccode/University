#include <iostream.h>
#include <stdlib.h>
#include <stdio.h>
#include <conio.h>

double GetDouble(const char *prompt);
void GetData(double &paid, double &rate);
void Calculate(const double paid, const double rate, double &list, double &tax);

main()
{
clrscr();
double paid, rate, list, tax;
GetData(paid, rate);
Calculate( paid, rate, list, tax);
printf("List pride = $%8.2f\n", list);
printf("Tax paid = $%8.2f\n", tax);
getch();
return 0;
}

//
double GetDouble(const char *prompt)
{
 char s[20];//
 printf(prompt);//
 scanf("%20s", s); //
 return atof(s); //
}
//
//
void GetData(double &paid, double &rate)
{
 paid = GetDouble("Price paid?");
 rate = GetDouble("Tax rate (ex: .06)?");
}
//
//
void Calculate(const double paid, const double rate, double &list, double &tax)
{
 list = paid / (1 + rate);
 tax = paid - list;
}