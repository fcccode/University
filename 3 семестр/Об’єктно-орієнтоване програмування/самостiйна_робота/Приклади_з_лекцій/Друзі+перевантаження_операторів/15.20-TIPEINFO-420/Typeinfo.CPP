#include <iostream.h>
#include <string.h>
#include <typeinfo.h> 

class AnyClass {
public:
	   AnyClass(int c) { count = c; }
private:
  int count;
}; 

#pragma warn -use 

int main()
{
   char c;
   int i;
   double d;
   AnyClass a(1);
	   AnyClass *pa = new AnyClass(2);

	   cout << "Name : " << typeid(c).name()<<endl;
	   cout << "Name : " << typeid(i).name()<< endl;
	   cout <<"Name : " << typeid(d).name()<< endl;
	   cout << "Name : " << typeid(a).name()<< endl;
	   cout << "Name : " << typeid(pa).name()<< endl;
	   cout << "Name : " << typeid(*pa).name()<< endl;
	   cout << "Name : " << typeid(typeid(i)).name() << endl;

	   cout << endl; // Начать с новой строки 

	// Следующие строки не выводят корректные имена типов,
	// это следствие ошибки в ВС++ 4.
/*
   if (typeid(c) != typeid(d))
	      cout << typeid(c).name()<< " and"
	           << typeid(d).name() << " are not equivalent." << endl;
*/

	// Очевидно, необходимо использовать name() только один раз в
// операторе вывода в поток. Следующие строки работают правильно. 

	if (typeid(c) != typeid(d)) {
	   cout << typeid(c).name()<< " and ";
	   cout << typeid(d).name() << " are not equivalent." << endl;
}

	// Сравнить обычный и динамический объекты одного и того же типа
	if (typeid(a) == typeid(*pa))
	   cout << "a and *pa are objects of the same types" << endl; 

	// Демонстрация обработки исключительной ситуации Bad_typeid
try {
       cout << endl;
	    cout << "Using a dereferenced null pointer typeid" << endl;
	    int *p; // Define a pointer
    p = 0; // Assign null to the pointer
    cout << "Name : " <<typeid(*p).name()<< endl;
    cout << "Borland C++ bug. This should not appear." << endl;
    p = new int; // Never executes
    delete p; // Never executes
}
catch (Bad_typeid x) { 
    cout << "Error: typeid exception thrown" << endl;
    //... exit program or take other action here
}
 delete pa;
 return 0;
}









