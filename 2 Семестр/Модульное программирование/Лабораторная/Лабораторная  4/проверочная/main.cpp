#include <iostream>
#include <task4_1_1.h>
#include <task4_2.h>
#include <task4_3.h>
#include <clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL,"rus");
    cout << "\t����������� ��������� ��� �������\n\n";
    cout << "������ 4_1: " << endl;
    cout << "������ 4_2: " << endl;
    cout << "������ 4_3: " << endl;

    int i=0;
    cin >> i;
    switch (i)
    {
        case 1 : task4_1_1(); break;
        case 2 : task4_2(); break;
        case 3 : task4_3(); break;
        default: cout << "\n�� ���������� �����\n\n";
    }
    cin.get();
    cout << "\a\t����������\n";

    cin.get();
        return 0;
}
