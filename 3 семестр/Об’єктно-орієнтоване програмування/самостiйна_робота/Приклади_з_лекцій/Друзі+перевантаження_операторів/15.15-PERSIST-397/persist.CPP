#include <iostream.h>
class TPersist { 
private: int x, y; 
public:
TPersist(int a, int b) { x = a; y= b; }	// Конструктор
~TPersist() { x = 0; y = 0; }	// Деструктор
 void *operator new(size_t, void *p) { return p; }
friend ostream& operator<<(ostream &os, TPersist &p);
};
char object[sizeof(TPersist)]; 
main()
{
TPersist *p = new(object) TPersist(10, 20); 
cout << *p << endl;
cout << "Address of object == " << &object << endl; 
cout << "Address of *p == " " &(*p) " <<endl;
p->TPersist::~TPersist();	// Непосредственный вызов деструктора
// p->~TPersist();	// Можно в ВС++ версии 4.0; нельзя в 3.1
return 0;
}
ostream& operator<<(ostream& os, TPersist &p)
{
os << "x == " << p.x << ", у == " << p.y;
return os;
 }




