#include <iostream.h>
#include <new.h>
#include <except.h>
#include <cstring.h>
#include <stdlib.h> 

struct q {
	   int ia[1024]; // 2048-байтовая структура
}; 

	char *pool; // Зарезервированный указатель пула памяти

int main()
{
   	struct q *qp; // Указатель на структуру q 

   try {
   	pool = new char[512]; // Зарезервировать немного памяти
   }
   catch (xalloc) {
 	        cout << "Not enough RA to run program" << endl;
      exit(-1);
   } 

	   for (;;) { // Выполнять следующие операторы "до бесконечности'
	      try { // Блок try для обработки исключительных ситуаций
	         qp = new q; // Выделить новую структуру типа q
	         cout << qp << '\n';// Отобразить адрес структуры
   }
	   catch (xalloc x) { // Обработать исключительную ситуацию из new
	      delete pool; // Освободить память для следующей строки
	      cout << "Error: " << x.why()<< endl; // Вывести сообщение
	      exit(-1); // Завершить программу (или другие действия)
      }
   }
   return 0;//В этом месте будет предупреждение "Unreachable code"
}


