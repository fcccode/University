// Демонстрация обработки ошибок с помощью исключительных ситуаций 
#include <iostream.h>
#include <math.h> 

	// Неполное объявление класса исключительных ситуаций, необходимое
	// для того, чтобы на него могла сослаться функция Power()
class Error; 

	// Прототипы функций (отметьте объявленную ситуацию в функции Power)
void Instruct();
void Run();
	double Pow(double b, double e);
	double Power(double b, double e) throw(Error);

	// Полное объявление класса объектов исключительной ситуации
class Error {
	double b; // Base
	    double e; // Exponent
public:
       Error()
	          { cout <<" Error in source code!"<< endl; }
	       Error(double bb, double ee)
	      : b(bb), e(ee) { }
       void Report();
};

int main()
{
   Instruct();
   for (;;) {
      try {
      Run();
	      cout << "Program is ending normally." << endl;
	      return 0; // Только если не было исключительных ситуаций
   }
   catch (...) {
	      cout << "Error detected: Try again!"<< endl;
      }
   }
}

void Instruct()
{ 

 
cout << "Power Demonstration\n\n";
cout << "This program displays the result of raising\n"; 
cout<<"a value (base) to a power (exponent). To\n";
 		cout << "force an exception, enter a negative base\n"; 
cout << "and a fractional exponent (e.g. -4 and 1.5)\n"; 
cout << "Or, enter a zero base and an exponent less than\n";
cout <<"zero.\n\n";
}
// Выполнить программ (повторно вызывается из main ())
void Run() {
  try {
double base, exponent, result;
cout << "base? ";
cin >> base;
cout << "exponent? ";
cin >> exponent;
result = Power(base, exponent);
cout << "result == " << result << endl;
  }
  catch (Error& e) { 
e.Report(); // Отобразить сообщение об ошибке 
throw e; // Передать исключительную ситуацию в место вызова
 }
}
// Подфункция для Power
double Pow(double b, double e) 
{
return exp(e * log(b));
}
// Возвести b в степень e 
double Power(double b, double e) throw(Error) 
{
if (b > 0.0) return Pow(b, e); 
if (b < 0.0) { 
double ipart;
double fpart = modf(e, &ipart); 
if (fpart == 0) { 
if (fmod(ipart, 2) != 0) // т.о. ipart - дополнение
return -Pow(-b, e); 
else
return Pow(-b, e); 
} else 
throw Error(b, e); 
} else { 
if (e == 0.0) return 1.0; 
if (e < 1.0) throw Error(b, e); 
return 0.0;
}
}
// Реализация функции-члена Report() класса Error() 
// Отобразить значения, вызвавшие исключительную ситуацию 
void
Error:: Report() 
{
cout << "Domain error:" 
<< " base:" << b 
<< " exponent:" << e 
<< endl;
}




