#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>

using namespace std;

void task4_1()
{
    setlocale(LC_ALL, "rus"); // �����������

    ofstream outfile;  // ���������� ������� ������ ofstream

    outfile.open("D:\\KNTU\\��������\\2 �������\\��������� ����������������\\������������\\������������  4\\Exit.txt"); //  ���������� ����� � �������� ����
    outfile << "\n --------------------------\n"
         << "| Arslan Annaev, KNTU |\n"
         << "| ������ ������, ���� |\n"
         << "| copyright � |"
         << "| 2016 ���    |"
         << "\n --------------------------\n";

    // ���� �������� ���� �������
    int i = system("fc  InputFile.txt Exit.txt" );
	if(i==0)
        outfile << "\n\n������ ������";
    else
        if(i==1)
            outfile << "\n\n������ ������";
        else outfile << "\n\n������";

// �������� ��������� �����
    outfile.close();

}
