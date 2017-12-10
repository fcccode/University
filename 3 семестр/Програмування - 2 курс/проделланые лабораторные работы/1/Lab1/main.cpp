#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    setlocale (LC_ALL, "rus");
    int n=0,z=1;
    cout << "Программа вычисления факториала n-ого числа" << endl;

    cout << "Введите значение n :  ";
    cin >> n;

    if (!(n==0) )
    {
        for (int i = 1; i<=n; i++)
        {
            z*=i;
        }

         cout << "Результат выполнения программы "  << z << endl;
    } else
    {

         cout << "Значение должно быть больше нуля "  << endl;
    }

    return 0;
}
