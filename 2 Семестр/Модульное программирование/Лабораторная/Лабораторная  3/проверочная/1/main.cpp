#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    struct c {double vlk, ukr, es;};
    setlocale(LC_ALL, "rus");
    cout << "\tЗадача № 2" << endl;
    cout << "Введите размер обуви в сантиметрах" << endl;
    double x;
    int mat=9;
    c ver;
while (!(cin>>x))
{   cin.clear();
    cin.ignore(mat, '\n');
    cout << "Не корректное значение";}

    switch ( x )
    {
    case 1 : ver={1, 0, 33};
                break;
    default   : cout << "Error";
};
cout << ver.vlk<< endl;
cout << ver.ukr<< endl;
cout << ver.es<< endl;
    return 0;
}
