#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    struct c {double vlk, ukr, es;};
    setlocale(LC_ALL, "rus");
    cout << "\t������ � 2" << endl;
    cout << "������� ������ ����� � �����������" << endl;
    double x;
    int mat=9;
    c ver;
while (!(cin>>x))
{   cin.clear();
    cin.ignore(mat, '\n');
    cout << "�� ���������� ��������";}

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
