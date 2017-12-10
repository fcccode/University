#include <iostream>
#include <clocale >

using namespace std;

int main ()
{   setlocale (LC_ALL, "rus");
    int mat=20;
    double y;
    int i,clk;
    clk=0;
struct structura {double ukr; double vel;double es;};
structura reestr[24];
    reestr[0]={0,1,33};
        reestr[1]={0,1.5,33.7};
            reestr[2]={0,2,34.4};
                reestr[3]={0,2.5,35};
            reestr[4]={0,3,36};
        reestr[5]={35,4,36.7};
    reestr[6]={36,4.5,37.4};
reestr[7]={36.5,5,38};
    reestr[8]={37,5.5,39};
        reestr[9]={38,6,39.7};
            reestr[10]={38-39,6.5,40.4};
                reestr[11]={40.5,7.5,41};
            reestr[12]={41,8,42};
        reestr[13]={41.5,8.5,42.7};
    reestr[14]={42,9,43.4};
reestr[15]={42-43,9.5,44};
    reestr[16]={43,10,45};
        reestr[17]={44,11,45.7};
            reestr[18]={45,11.5,46.4};
                reestr[19]={46,12,47};
            reestr[20]={47,12.5,48};
        reestr[21]={47.5,13,48.7};
    reestr[22]={48,14,49.4};
reestr[23]={48.5,14.5,50};

do {
 cout << "\tПеревод размера обуви" << endl;
cout << "\tЗадача №3_2" << endl;
while (!(cin>>y))
    {   cin.clear();
        cin.ignore();
        cout<< "Не корректное значение\n"; };
if ((y>=20.5) && (y<=32))
    {
if (y==20.5) i=0;
else
if (y==21) i=1;
    else if (y==21.5) i=2;
        else if (y==22) i=3;
            else if (y==22.5) i=4;
                else if (y==23) i=5;
            else if (y==23.5) i=6;
        else if (y==24) i=7;
    else if (y==24.5) i=8;
else if (y==25) i=9;
    else if (y==25.5) i=10;
        else if (y==26) i=11;
            else if (y==26.5) i=12;
                else if (y==27) i=13;
            else if (y==27.5) i=14;
        else if (y==28) i=15;
    else if (y==28.5) i=16;
else if (y==29) i=17;
    else if (y==29.5) i=18;
        else if (y==30) i=19;
            else if (y==30.5) i=20;
                else if (y==31) i=21;
            else if (y==31.5) i=22;
        else if (y==32) i=23;
cout << "Размер обуви в системе Украины: "<<reestr[i].ukr << endl;
cout << "Размер обуви в системе Великобритании: "<<reestr[i].vel << endl;
cout << "Размер обуви в Европейской системе: "<<reestr[i].es << endl;
clk=1;}
else cout << "\tВведите корректный размер\n";
cin.get();

} while (clk!=1);
return 0;
}

