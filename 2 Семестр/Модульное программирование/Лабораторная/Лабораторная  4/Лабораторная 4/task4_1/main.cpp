#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    // ���������� ���������� ��� ����� � ��� �������� � ������� � ����� �������� � �������� ����
    char name[10];
    char fname[10];
    char country[15];
    char year [10];
    setlocale(LC_ALL, "rus"); // �����������

    ofstream outfile;  // ���������� ������� ������ ofstream

    outfile.open("D:\\KNTU\\��������\\2 �������\\��������� ����������������\\������������\\������������  4\\Exit.txt"); //  ���������� ����� � �������� ����


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

    return 0;
}
