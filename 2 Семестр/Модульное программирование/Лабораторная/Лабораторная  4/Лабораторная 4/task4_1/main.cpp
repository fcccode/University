#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    // обьявление переменных для ввода в них значений с консоли а потом передачи в выходной файл
    char name[10];
    char fname[10];
    char country[15];
    char year [10];
    setlocale(LC_ALL, "rus"); // локализация

    ofstream outfile;  // обьявление обьекта класса ofstream

    outfile.open("D:\\KNTU\\предметы\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная  4\\Exit.txt"); //  ассоциация файла с обьектом опен


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

    return 0;
}
