#include <iostream>
#include <iomanip>
#include <clocale>


using namespace std;


double a,b;
bool c;
int srav(double, double )
{
cout << " ������� �������� a : \n";
cin >> a;
cout << " ������� �������� b : \n";
cin >> b;
c = a+1>=b ? 1 : ;
return c;
}
int main()
{
    setlocale(LC_ALL, "rus");
    srav(a,b);
    cout << boolalpha << c << endl;
    return 0;
}

