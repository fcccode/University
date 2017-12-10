#include <iostream.h>
class One; // Неполное объявление класса
class Two { 
private:
char *s2; // Доступен членам класса Two 
public:
Two() { s2 = "one, two,three"; } 
void Show(One &c1);
};
class One {
friend void Two::Show(One &c1);
private:
char *s1; // Доступен s классе One и в Two::Show
public:
One() { s1 = "Testing "; }
};
main()
{
One c1; 
Two c2;
c2.Show(c1); 
return 0;
}
void Two::Show(One &c1)
{
 cout << c1.s1 <<s2<< '\n';
}

