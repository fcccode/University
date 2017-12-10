#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>

using namespace std;

void task4_1()
{
    setlocale(LC_ALL, "rus"); // локализация

    ofstream outfile;  // обьявление обьекта класса ofstream

    outfile.open("D:\\KNTU\\предметы\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная  4\\Exit.txt"); //  ассоциация файла с обьектом опен
    outfile << "\n --------------------------\n"
         << "| Arslan Annaev, KNTU |\n"
         << "| Арслан Аннаев, КНТУ |\n"
         << "| copyright © |"
         << "| 2016 год    |"
         << "\n --------------------------\n";

    // блок проверки двух текстов
    int i = system("fc  InputFile.txt Exit.txt" );
	if(i==0)
        outfile << "\n\nТексты разные";
    else
        if(i==1)
            outfile << "\n\nТексты разные";
        else outfile << "\n\nОшибка";

// закрытие выходного файла
    outfile.close();

}
