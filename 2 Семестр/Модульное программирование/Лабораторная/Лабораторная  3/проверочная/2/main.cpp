#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    struct c {double vlk, ukr, es;};
    setlocale(LC_ALL, "rus");
    cout << "\t������ � 2" << endl;
    cout << "������� ������ ����� � �����������" << endl;
    double y;
    int x, mat=20;
while (!(cin>>x))
{   cin.clear();
    cin.ignore(mat,'\n');
    cout << "�� ���������� ��������";};
    c ver;
switch (x){
    case 20 : cout << "1"; break;
    case 21   : cout << "2"; break;
    case 22 : cout << "3";break;
    default   : cout << "Error";
}
cout << ver.vlk<< endl;
cout << ver.ukr<< endl;
cout << ver.es<< endl;
    return 0;
}
