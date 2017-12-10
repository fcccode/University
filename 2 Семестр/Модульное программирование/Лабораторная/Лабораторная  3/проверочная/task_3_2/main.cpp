#include <iostream>
#include <clocale>

using namespace std;

int main()
{
    struct c {double vlk, ukr, es;};
    setlocale(LC_ALL, "rus");
    cout << "\tЗадача № 2" << endl;
    cout << "Введите размер обуви в сантиметрах" << endl;
    double x,y;
    int mat=9;
while (!(cin>>x))
{   cin.clear();
    cin.ignore(mat, '\n');
    cout << "Не корректное значение";};
    double a,b,u;
    c ver;
switch (x){
    case 20.5 : ver {vlk=1, ukr=0, es=33}; break
    case 21   : ver {vlk=1.5, ukr=0 , es=33-}; break
    case 21.5 : ver{vlk=2, ukr=0, es=34- };break
    case 22   : ver{vlk=2.5, ukr=0, es=35}; break
    case 22.5 : ver{vlk=3, ukr=0, es=36}; break
    case 23   : ver{vlk=4, ukr=35, es=36-}; break
    case 23.5 : ver{vlk=4.5, ukr=36, es=37-}; break
    case 24   : ver{vlk=5, ukr=36.5, es=38} break
    case 24.5 : ver{vlk=5.5, ukr=37, es=39}; break
    case 25   : ver{vlk=6, ukr=38 , es=39-}; break
    case 25.5 : ver{vlk=6.5, ukr=38-, es=40-}; break
    case 26   : ver{vlk=7.5, ukr=40.5, es=41}; break
    case 26.5 : ver{vlk=8, ukr=41, es=42}; break
    case 27   : ver{vlk=8.5, ukr=41.5, es=42-}; break
    case 27.5 : ver{vlk=9, ukr= 42, es=43-}; break
    case 28   : ver{vlk=9.5, ukr=42-43, es=44}; break
    case 28.5 : ver{vlk=10, ukr=43, es=45}; break
    case 29   : ver{vlk=11, ukr=44, es=45-}; break
    case 29.5 : ver{vlk=11.5, ukr=45, es=46-}; break
    case 30   : ver{vlk=12, ukr=46, es=47}; break
    case 30.5 : ver{vlk=12.5, ukr=47, es=48}; break
    case 31   : ver{vlk=13, ukr=47.5, es=48-}; break
    case 31.5 : ver{vlk=14, ukr=48, es=49-}; break
    case 50   : ver{vlk=14.5, ukr=48.5, es=50}; break
    default   : cout << "Error";
}
cout << ver.vlk<< endl;
cout << ver.ukr<< endl;
cout << ver.es<< endl;
    return 0;
}
