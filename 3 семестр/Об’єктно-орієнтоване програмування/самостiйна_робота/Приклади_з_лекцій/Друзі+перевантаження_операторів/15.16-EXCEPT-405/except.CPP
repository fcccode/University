// Демонстрация исключительных ситуаций ANSI С++
#include <iostream.h>
#include <math.h>
// Прототипы функций
void Instruct(); 
double Pow(double b, double e);
double Power(double b, double e);
// Классы исключительных ситуаций
class Error { 
double b; // Основание 
double e; // Показатель степени 
public: 
Error()
{ cout<< " Error in source code!" << endl; }
Error(double bb, double ee)
: b(bb), e(ee) { }
void Report();
};
int main() 
{
Instruct();
 	try {
double base, exponent, result;
cout<< "base? ";
cin>> base;
cout << "exponent? ";
cin >> exponent;
result = Power(base, exponent);
cout << "result == " << result<< endl;
}
catch (Error& e) { 
e.Report(); 
return -1;
}
return 0;
}
void Instruct() 
{
cout<< "Power Demonstration\n\n";
cout << "This program displays the result of raising\n"; 
cout << "a value (base) to a power (exponent). To\n";
 	cout << "force an exception, enter a negative base\n";
 	cout << "and a fractional exponent (e.g. -4 and 1.5)\n";
 	cout <<" Or, enter a zero base and an exponent less than\n";
 	cout << "zero.\n\n";
}
// Подфункция возведения в степень
double Pow(double b, double e) 
{
return exp(e * log(b));
}
// Результирующий b возведенный в степень e
double Power(double b, double e) 
{
if (b > 0.0) return Pow(b, e);
 	if (b < 0.0) { 
double ipart;
double fpart = modf(e, &ipart); 
if (fpart == 0) { 
  if (fmod(ipart, 2) != 0) // Таким образом, ipart - нечетное число
return -Pow(-b, e);
 	  else
return Pow(-b, e); 
 } else 
   throw Error(b, e);  
}else { 
if (e == 0.0) return 1.0; 
if (e < 1.0) throw Error(b, e); 
return 0.0;
}
throw Error(); // В этом месте будет предупреждение
}
// Отображение значений, вызвавших исключительную ситуацию 
void
Error::Report() 
{
cout << "Domain error:"
<< " base:" << b
<< " exponent:" << e
<< endl;
}
