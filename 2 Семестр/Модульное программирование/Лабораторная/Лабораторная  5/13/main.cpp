#include <iostream>
#include <fstream>
#include <clocale>
#include <struct.h>
#include <cstring>


using namespace std;

int main()
{
   struct directory_elem
{
    unsigned int index;
    char region[20] {'\n'};
    char district[20] {'\n'};
    char city[20] {'\n'};
    char post_office[20] {'\n'};
    directory_elem *next;
};



    setlocale(LC_ALL,"rus");
    directory_elem p1;
    cout << "\tПрограммный модуль сохранения справочника \n"
         << "\tв текстовом формате\n";
    cout << "Введите имя для файла";
    /*
    char gname[20],fil[5]= ".txt";
    cin.get(gname, 20);
    */
    ofstream fout;
    fout.open("put.txt", ios_base::out| ios_base::app);
    if (!(fout.is_open()))
        cout << "Возникла проблемма с открытием файла\n";
    ifstream fin;
    fin.open("C:\\Users\\Арслан\\Desktop\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная  5\\Prover\\files.dat", ios_base::in | ios_base::binary);
    if (!(fin.is_open()))
        cout << "Возникла проблема с открытием файла\n";
    else
    {
        while (fin.read((char*)&p1, sizeof p1))
    {
        cout<< "| Индекс   :" << p1.index << "|\n"
            << "| Область  :" << p1.region << "|\n"
            << "| Регион   :" << p1.district << "|\n"
            << "| Нас\\пункт:" << p1.city << "|\n"
            << "| ВПЗ      :" << p1.post_office << "|\n";
    }
}

fout.close();
fin.close();
    return 0;
}

