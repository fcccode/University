#include <iostream>
#include <clocale>

using namespace std;
/* ������� transferIn2 ��������� ���������� ����� num_10, � �������� num_2 (��������� ��������� � ������,
   ������� ��� ������� ��� �������� ��������� num_2) */

int main ()
{ setlocale (LC_ALL, "rus");
    int i, j=0; // ��� ������
    /* temp - ��� ���������� �������� ������� �� ������ ��������, ������� ����� ������� � ����� ��������
       ��� �������������� ������� �� �������� �� ���������� � ������� */
bool temp;
    bool num_2[32];
        int num_10;
            cin >> num_10;
                for(i=0; i<32; i++) //�������� ��� �������� (�������)
            num_2[i]=0;
        i=0;
    int c,g;
c=0; g=0;
    while(1)
    { num_2[i]=num_10%2; // ���������� ����� ����� �� ������ �� 2 (�.�. � num_2[i] ������������ ��� ������� �� ������� �� 2)
        if(!(num_10/2)) // ���� ������� ��� ������ (��� �������) �� 2 ����� �������� 0, ��...
        {   while(1) // ����, ������� �������� ������� �������� ��������� � ������� �� �������� �� ���������� � �������
            {   temp=num_2[31-j]; // � temp ����������� ������ �� ������ ��������
                num_2[31-j]=num_2[j]; // � ������ �� ����� �������� ����������� ��������������� ���������� ������ ����� ��������
                num_2[j]=temp; // � ������ ����� �������� ����������� �������� �� temp (������ ������ �� ������ ��������)
                if (!i) // ���� i=0, ��...
                    break; // ���� �����������
                j++; i--; }
            break;} // ���� �����������
        num_10/=2; // ���������� ����� ����� ��� ������ (��� �������)
        i++; }
for (i=0 ; i<32; i++)
    cout << num_2[i];
       for (i=0; i<32; i++)
         { if (num_2[i]==1)
             {for (; i<32; i++)
                {if  (num_2[i]==1) g++;
             else c++; };
             } };
         cout << " \n\n***���������� �����   : " << c ;
      cout << "\n\n*** ���������� ������� : " << g << "\n\n";
return 0;
}
