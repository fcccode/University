#include <iostream>
#include <bitset>
#include <clocale>

using namespace std;

int main()
{   setlocale(LC_ALL, "rus");
    int n, mat;
    mat=20;
    int i = 0, r = 0, d = 0;
    cout << "\t\t\"������ � 3_1\"\n"
         << "\t=������� ������� ���������=\n\n";
cout << "������� ����� ��� �������� � �������� ������� ���������\n";
while (!(cin>>n))
{       cin.clear();
        cin.ignore(mat,'\n');
        cout << "������������ ��������\n";};
if (n<=15)
{   cout << bitset<8> (n)<<endl;
    for(; i<8; i++, n>>=1)
        {if(n&1) r++;
         else d++;  };
         cout << "���������� �����:"<< d<< endl;
         cout << "���������� ������:"<< r<< endl;}
else  if (n<127)
        {cout << bitset<16>(n)<<endl;
         for(; i<16; i++, n>>=1){
            if(n&1) r++;
            else d++;};
            cout << "���������� �����:"<< d<< endl;
            cout << "���������� ������:"<< r<< endl;}
else
    if (n<1000)
        {cout << bitset<24>(n)<<endl;
            for(; i<32; i++, n>>=1){
                if(n&1) r++;
                else d++;};
                cout << "���������� �����:"<< d<< endl;
                cout << "���������� ������:"<< r<< endl; }
else
 if (n>1000)
{cout << bitset<32>(n)<<endl;
            for(; i<32; i++, n>>=1){
                if(n&1) r++;
                else d++;};
                cout << "���������� �����:"<< d<< endl;
                cout << "���������� ������:"<< r<< endl; };

 cin.get();
   return 0;
}

