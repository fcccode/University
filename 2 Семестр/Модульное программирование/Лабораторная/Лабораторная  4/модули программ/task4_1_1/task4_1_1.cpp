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
    setlocale(LC_ALL, "rus"); // �����������
    ofstream outfile;
    outfile.open("D:\\KNTU\\��������\\2 �������\\��������� ����������������\\������������\\������������  4\\�����������\\Exit.txt");
    if (outfile.is_open()) cout << "open\n";
     else cout << "close\n";

     outfile << "\n --------------------------\n"
         << "| Arslan Annaev, KNTU |\n"
         << "| ������ ������, ���� |\n"
         << "| copyright � |"
         << "| 2016 ���    |"
         << "\n --------------------------\n";


         srand(time(NULL));
         outfile << 10+rand()%100 << endl;



    // ���� �������� ���� �������



    ifstream Mary1,Mary2;
	Mary1.open("D:\\KNTU\\��������\\2 �������\\��������� ����������������\\������������\\������������  4\\�����������\\InPutFile.txt");
	Mary2.open("D:\\KNTU\\��������\\2 �������\\��������� ����������������\\������������\\������������  4\\�����������\\InPutFiles.txt");

    char string1[1000], string2[1000];
	int j = 0;
	while(!Mary1.eof())
	{
		Mary1.getline(string1,1000);
		Mary2.getline(string2,1000);
		j++;
		if(strcmp(string1,string2) != 0)
		{
			outfile << j << " ������ �� �����" << "\n";
					}
	}
outfile << "������ �����";

// �������� ��������� �����
    outfile.close();

 }
