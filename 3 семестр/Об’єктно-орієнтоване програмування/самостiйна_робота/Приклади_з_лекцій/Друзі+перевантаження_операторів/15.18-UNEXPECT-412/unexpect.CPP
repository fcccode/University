	#include <iostream.h>
	#include <except.h> 

	#define MAXERR 10 

	// Класс, используемый, когда число ошибок превышает допустимое
	class MaxError
	{
	};

	// Обычный класс исключительных ситуаций
	class Error {
	public:
Error(); // Конструктор
void Say(); // Функция, сообщающая о числе ошибок
private:
 	static int count; // Доступен только в этом классе
	};

	// Прототипы функций, возбуждающих исключительные ситуации
	void Run() throw(Error);
    void trapper();
	void zapper();
// Глобальный статический счетчик числа объектов класса Error 
int Error::count;
void main() 
{
set_unexpected(trapper); 
set_terminate(zapper);
for (;;) 
{
try { 
Run();
}
catch (Error e) { 
e.Say();
}
}
}
// Функция, возбуждающая исключительную ситуацию
void Run() throw(Error) 
{
// throw Error(); 
throw "An unknown exception object";
}
// Пользовательский обработчик непредвиденных ошибок
void trapper() 
{
cout << endl << "Inside trapper function" << endl;
 	throw Error();
}
// Пользовательский обработчик завершения ошибки
void zapper() 
{
cout << endl << "Inside terminate function" << endl;
cout << endl << "Exiting program with error code -1" 
<< endl;
exit(-1);
}
// Конструктор класса Error
Error:: Error()
{
count++;
if (count > MAXERR) 
   throw MaxError();
}
// Функция класса Error, выводящая сообщения
void Error::Say() 
{
cout << "Error: count = " << count << endl;
} 

