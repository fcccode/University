#include <iostream>
#include <fstream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
  setlocale(LC_ALL, "rus"); // �����������
    char *p = "D:\\KNTU\\��������\\2 �������\\��������� ����������������\\������������\\������������  4\\Exit";
    char *v = "D:\\KNTU\\��������\\2 �������\\��������� ����������������\\������������\\������������  4\\�����";

    ofstream outfile,files;  // ���������� ������� ������ ofstream
    outfile.open("p"); //  ���������� ����� � �������� ����
    if (outfile.is_open()) cout << "Open\n";
    else cout << "close \n";

    files.open("v");

        if (files.is_open()) cout << "Open\n";
    else cout << "close \n";

    outfile << "\n --------------------------\n"
         << "| Arslan Annaev, KNTU |\n"
         << "| ������ ������, ���� |\n"
         << "| copyright � |"
         << "| 2016 ���    |"
         << "\n --------------------------\n";


         srand(time(NULL));
         outfile << 10+rand()%100;



    // ���� �������� ���� �������
    int i = system("fc v p " );
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
