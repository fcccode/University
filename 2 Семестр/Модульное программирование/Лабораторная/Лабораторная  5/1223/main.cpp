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
    cout << "\t\a***������ ���������� ������ � ���������� \n\n: " << endl; // ���������� ������

    directory_elem *p1 = new directory_elem; // ��������� ������ ��� ������ �������� ���������
    directory_elem *p2;

    do
    {
        cout << "� 1 ������� ������  -";          // ���� ����� ��������
        while( !(cin >> p1->index))    // �������� ������������ ��������� ��������
        {
            cin.clear();                                // ������������ ������ �����
            cin.ignore(mat, '\n');                     // ����� 20 �������
            cout << "�� ���������� ��������\n";
            cout << "**��������� �������!!! \n\n";         // ����������� � ������������ ��������
        }
        if ((p1->index >=24500) && (p1->index < 35000) ) // ������� �������� ��������� ���������� ��������
            c=1;
        else
        {
            cin.clear();                                      // ������������ ������ �����
            cout << "\t��������� ������ ������� �� �������\n" //  �����������
                 << "\t��������� ����������� ��� �������\n\n";
            cout << "**��������� �������!!! \n\n";
        }
    }
    while( c!= 1);
    cin.get();
    cout << "� 2 ������� ������� -";
    cin.get(p1->region,20);
    cin.get();
    cout << "� 3 ������� ����� -";
    cin.get(p1->district,20);
    cin.get();
    cout << "� 4 ������� ���������� ����� -";
    cin.get(p1->city,20);
    cin.get();
    cout << "� 5 ������� �������� ��� -";
    cin.get(p1->post_office,20);
    cin.get();


    cout << p1->region << "\n"<< p1->city << "\n" << p1->index <<"\n" << p1->district<< endl;

        ofstream fout;
        fout.open(file, ios_base::out | ios_base::app | ios_base::binary);
        if (!(fout.is_open()))
            cout << "�� ���������� ������� ����" <<endl;
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
