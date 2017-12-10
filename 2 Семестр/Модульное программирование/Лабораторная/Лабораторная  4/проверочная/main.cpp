#include <iostream>
#include <task4_1_1.h>
#include <task4_2.h>
#include <task4_3.h>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL,"rus");
    cout << "\tПроверочная программа или драйвер\n\n";
    cout << "Задача 4_1: " << endl;
    cout << "Задача 4_2: " << endl;
    cout << "Задача 4_3: " << endl;

    int i=0;
    cin >> i;
    switch (i)
    {
        case 1 : task4_1_1(); break;
        case 2 : task4_2(); break;
        case 3 : task4_3(); break;
        default: cout << "\nНе корректный выбор\n\n";
    }
    cin.get();
    cout << "\a\tЗавершение\n";

    cin.get();
        return 0;
}
