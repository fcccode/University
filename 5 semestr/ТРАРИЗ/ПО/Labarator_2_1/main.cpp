#include <iostream>

using namespace std;


void ReadKey()
{
    int key;                        // ��������� ��������
    cout << "������� �������� :";   // ����������� ������ ��������
    cin >> key;                     // ���� ��������
    if(key != 0)                    // �������� ��������� �����
        ReadKey();                  // ����������� ����� �������

    cout << key << endl;            // ����� �� ��� ���������� ���
}

int main()
{
    setlocale(LC_ALL, "rus");      // �����������
    ReadKey();                     // ����� �������
    return 0;
}



