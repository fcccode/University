#include <iostream>
#include <bitset>
#include <clocale>

using namespace std;

void task3_3()
{   setlocale(LC_ALL, "rus");
    int n, mat;
    mat=20;
    int i = 0, r = 0, d = 0;
    cout << "\t\t\"Задача № 3_1\"\n"
         << "\t=Перевод системы счисления=\n\n";
cout << "Введите число для перевода в двоичную систему счисления\n";
while (!(cin>>n))
{       cin.clear();
        cin.ignore(mat,'\n');
        cout << "Некорректное значение\n\n";};
if (n<0) cout << "Значение не должно быть отрицательным"<< endl;
{if (n<=15)
{   cout << bitset<8> (n)<<"\n\n";
    for(; i<8; i++, n>>=1)
        {if(n&1) r++;
         else d++;  };
         cout << "**Количество нулей:"<< d<< endl;
         cout << "**Количество единиц:"<< r<< endl;}
else  if (n<=127)
        {cout << bitset<16>(n)<<"\n\n";
         for(; i<16; i++, n>>=1){
            if(n&1) r++;
            else d++;};
            cout << "**Количество нулей:"<< d<< endl;
            cout << "**Количество единиц:"<< r<< endl;}
else
    if (n<=1000)
        {cout << bitset<24>(n)<<"\n\n";
            for(; i<32; i++, n>>=1){
                if(n&1) r++;
                else d++;};
                cout << "**Количество нулей:"<< d<< endl;
                cout << "**Количество единиц:"<< r<< endl; }
else
 if (n>1000)
{cout << bitset<32>(n)<<"\n\n";
            for(; i<32; i++, n>>=1){
                if(n&1) r++;
                else d++;};
                cout << "**Количество нулей:"<< d<< endl;
                cout << "**Количество единиц:"<< r<< endl; };
 cin.get();
};
   }

