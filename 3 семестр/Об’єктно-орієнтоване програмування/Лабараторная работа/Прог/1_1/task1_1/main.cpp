#include <iostream>
#include <clocale>
#include <iomanip>

using namespace std;



int main()
{   setlocale(LC_ALL, "rus");
    cout << "Программа    \n" << endl;
   int a [3][3];
   for(int i=1;i<=3;i++)
    for (int j=1; j<=3; j++)
   {
       cout << i <<","<< j ;
       cin>> a[j][i];
   }
for(int i=1;i<=3;i++)
    for (int j=1; j<=3; j++)
   {
       cout << i <<","<< j << " = " <<a [i][j]<<endl;

   }
    // заполнение матрицы


 int rez = a[1][1]*a[2][2]*a[3][3]-a[1][1]*a[2][2]*a[3][3];

    return 0;
}


