#include <iostream>
#include <clocale>
#include <fstream>
#include <Starkina_unit_lab_5.h>

using namespace std;



const char* file = "files.dat";
directory_elem* search_elem(directory_elem *head);

int main()
{    struct directory_elem
{
    unsigned int index;
    char region[20] {'\n'};
    char district[20] {'\n'} ;
    char city[20] {'\n'};
    char post_office[20] {'\n'};
    directory_elem *next;
};
    setlocale(LC_ALL,"ukr");
    int c=0, mat=20;
    cout << "\t\a***Модуль добавления данных в справочник \n\n: " << endl; // обьявление модуля

    directory_elem *p1 = new directory_elem; // выделение памяти для одного элемента структуры
    directory_elem *p2;

    do
    {
        cout << "№ 1 Введите индекс  -";          // блог ввода значений
        while( !(cin >> p1->index))    // проверка корректности введенных значений
        {
            cin.clear();                                // освобождение потока ввода
            cin.ignore(mat, '\n');                     // игнор 20 нажатий
            cout << "Не корректное значение\n";
            cout << "**Повторите попытку!!! \n\n";         // уведомление о некорректном значении
        }
        if ((p1->index >=24500) && (p1->index < 35000) ) // условия проверки диапазона введенного значения
            c=1;
        else
        {
            cin.clear();                                      // освобождение потока ввода
            cout << "\tВведенный индекс выходит за границы\n" //  уведомление
                 << "\tдиапазона выделенного для Украины\n\n";
            cout << "**Повторите попытку!!! \n\n";
        }
    }
    while( c!= 1);
    cin.get();
    cout << "№ 2 Введите Область -";
    cin.get(p1->region,20);
    cin.get();
    cout << "№ 3 Введите Район -";
    cin.get(p1->district,20);
    cin.get();
    cout << "№ 4 Введите Населенный пункт -";
    cin.get(p1->city,20);
    cin.get();
    cout << "№ 5 Введите название ВПЗ -";
    cin.get(p1->post_office,20);
    cin.get();


    cout << p1->region << "\n"<< p1->city << "\n" << p1->index <<"\n" << p1->district<< endl;

        ofstream fout;
        fout.open(file, ios_base::out | ios_base::app | ios_base::binary);
        if (!(fout.is_open()))
            cout << "Не получилось открыть файл" <<endl;
        else
        {
            fout.write((char*)&p1, sizeof(p1));
        }
        delete p1;


    return 0;
}/*
directory_elem* search_elem(directory_elem* head)
{
    directory_elem *p;
    p = head;
    if (p!=NULL)
    {
        do
        {
            if ((p->index == index_in))
            {
                return p;
            }
            p = p->next;
        }
        while (p!=NULL);
        return NULL;
    }
    else
    {
        return p;
    }
}
*/
