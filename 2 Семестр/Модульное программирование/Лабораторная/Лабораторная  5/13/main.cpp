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
    cout << "\t����������� ������ ���������� ����������� \n"
         << "\t� ��������� �������\n";
    cout << "������� ��� ��� �����";
    /*
    char gname[20],fil[5]= ".txt";
    cin.get(gname, 20);
    */
    ofstream fout;
    fout.open("put.txt", ios_base::out| ios_base::app);
    if (!(fout.is_open()))
        cout << "�������� ��������� � ��������� �����\n";
    ifstream fin;
    fin.open("C:\\Users\\������\\Desktop\\2 �������\\��������� ����������������\\������������\\������������  5\\Prover\\files.dat", ios_base::in | ios_base::binary);
    if (!(fin.is_open()))
        cout << "�������� �������� � ��������� �����\n";
    else
    {
        while (fin.read((char*)&p1, sizeof p1))
    {
        cout<< "| ������   :" << p1.index << "|\n"
            << "| �������  :" << p1.region << "|\n"
            << "| ������   :" << p1.district << "|\n"
            << "| ���\\�����:" << p1.city << "|\n"
            << "| ���      :" << p1.post_office << "|\n";
    }
}

fout.close();
fin.close();
    return 0;
}

