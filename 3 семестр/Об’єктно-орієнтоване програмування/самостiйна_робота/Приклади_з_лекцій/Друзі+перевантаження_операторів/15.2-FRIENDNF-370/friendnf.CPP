#include <iostream.h>
class Two;	// Неполное объявление класса
class One {
friend void Show(One& c1, Two &c2);
private:
char *s1;	// Доступен классу One и функции Show()
public:
 One() { s1 = "Testing "; }
};
class Two {
friend void Show(One &c1, Two &c2);
 private:
char *s2;	// Доступен классу Two и функции Show()
public:
Two() { s2 = "one, two, three"; }
};
main() 
{
One c1; 
Two c2;
Show(c1, c2); 
return 0;
}
void Show(One &c1, Two &c2)
{
cout <<c1.s1 << c2.s2 << '\n';
}
