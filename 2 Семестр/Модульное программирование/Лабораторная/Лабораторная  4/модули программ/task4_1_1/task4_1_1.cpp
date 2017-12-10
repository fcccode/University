#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>
#include <stdio.h>
#include <string>
#include <string.h>
#include <clocale>


using namespace std;

void task4_1_1()
{
    setlocale(LC_ALL, "rus"); // локализация
    ofstream outfile;
    outfile.open("D:\\KNTU\\предметы\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная  4\\проверочная\\Exit.txt");
    if (outfile.is_open()) cout << "open\n";
     else cout << "close\n";

     outfile << "\n --------------------------\n"
         << "| Arslan Annaev, KNTU |\n"
         << "| Арслан Аннаев, КНТУ |\n"
         << "| copyright © |"
         << "| 2016 год    |"
         << "\n --------------------------\n";


         srand(time(NULL));
         outfile << 10+rand()%100 << endl;



    // блок проверки двух текстов



    ifstream Mary1,Mary2;
	Mary1.open("D:\\KNTU\\предметы\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная  4\\проверочная\\InPutFile.txt");
	Mary2.open("D:\\KNTU\\предметы\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная  4\\проверочная\\InPutFiles.txt");

    char string1[1000], string2[1000];
	int j = 0;
	while(!Mary1.eof())
	{
		Mary1.getline(string1,1000);
		Mary2.getline(string2,1000);
		j++;
		if(strcmp(string1,string2) != 0)
		{
			outfile << j << " строка не равна" << "\n";
					}
	}
outfile << "строки равны";

// закрытие выходного файла
    outfile.close();

 }
