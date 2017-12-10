#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    // пример применения объединения
 union aska
 {
 int int_1;
 double d_1;
 char ch_[20];
 };

 aska price;
 price.int_1=200;
 			 cout << "Hello world!" << price.int_1<< endl;
    return 0;
}
