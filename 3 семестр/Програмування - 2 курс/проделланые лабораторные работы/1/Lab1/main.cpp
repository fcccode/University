#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    setlocale (LC_ALL, "rus");
    int n=0,z=1;
    cout << "��������� ���������� ���������� n-��� �����" << endl;

    cout << "������� �������� n :  ";
    cin >> n;

    if (!(n==0) )
    {
        for (int i = 1; i<=n; i++)
        {
            z*=i;
        }

         cout << "��������� ���������� ��������� "  << z << endl;
    } else
    {

         cout << "�������� ������ ���� ������ ���� "  << endl;
    }

    return 0;
}
