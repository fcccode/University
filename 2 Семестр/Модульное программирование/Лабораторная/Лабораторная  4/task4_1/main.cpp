#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
  setlocale(LC_ALL, "rus"); // локализация
    char *p = "D:\\KNTU\\предметы\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная  4\\Exit";
    char *v = "D:\\KNTU\\предметы\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная  4\\Стихи";

    ofstream outfile,files;  // обьявление обьекта класса ofstream
    outfile.open("p"); //  ассоциация файла с обьектом опен
    if (outfile.is_open()) cout << "Open\n";
    else cout << "close \n";

    files.open("v");

        if (files.is_open()) cout << "Open\n";
    else cout << "close \n";

    outfile << "\n --------------------------\n"
         << "| Arslan Annaev, KNTU |\n"
         << "| Арслан Аннаев, КНТУ |\n"
         << "| copyright © |"
         << "| 2016 год    |"
         << "\n --------------------------\n";


         srand(time(NULL));
         outfile << 10+rand()%100;



    // блок проверки двух текстов
    int i = system("fc v p " );
	if(i==0)
        outfile << "\n\nТексты разные";
    else
        if(i==1)
            outfile << "\n\nТексты разные";
        else outfile << "\n\nОшибка";

// закрытие выходного файла
    outfile.close();

    return 0;
}
