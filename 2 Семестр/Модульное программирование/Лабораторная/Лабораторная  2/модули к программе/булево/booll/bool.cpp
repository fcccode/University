#include <iostream>
#include <iomanip>
#include <clocale>

using namespace std;

void bool_1()
 {  setlocale(LC_ALL, "rus");
        cout << "\t��������� ���� ��������\n"
         << "\ta+1>=b" << endl;
    double a,b;
    bool c;
        cout << " \a������� �������� a : \n";
        cin >> a;
        cout << " \a������� �������� b : \n";
        cin >> b;
            c = a+1>=b ? 1 : 0;
        cout << boolalpha << c << endl;
  }

