#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;

void bool_1()
 {  setlocale(LC_ALL, "rus");
        cout << "\tСравнение двух значений\n"
         << "\ta+1>=b" << endl;
    double a,b;
    bool c;
        cout << " \aВведите значения a : \n";
        cin >> a;
        cout << " \aВведите значения b : \n";
        cin >> b;
            c = a+1>=b ? 1 : 0;
        cout << boolalpha << c << endl;
  }

