/*/////////////////////////////////////////////
������������� ���� �����/////////
////////////////////////////////////////////////
������ ������/////////////////////////
///////////////////////////////////////////////
////////////////////////////////////////////*/
#include <iostream>
#include <climits>
int fun();
using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
     // ������� ������������� ������������� ������
    int counts=25;
     //int counts = {25};
     //int counts {25};
     // int counts (2);
     //int counts ={}; // ������������� �������� ���� � ���������
     //int counts {};//������������� �������� ���� � ���������

    // �������� ����������������� �������� ������������� ����������
    cout << "����������  counts �������� �������� :  "<< counts << endl;

// ��� ����������� ������� ����������
int a=3;
cout <<"����������  ��������  �������� "<<a<<""<<endl;
cout<< "����������  �  ����� ������ "<< sizeof a <<"  ����"<<endl;
cout<<"���������� ���� integer :"<<sizeof (int )<<" ����"<<endl;
cout<<"���������� ���� short :"<<sizeof (short)<<" ����"<<endl;
cout<<"���������� ���� long :"<<sizeof (long )<<" ����"<<endl;
cout<<"���������� ���� long long :"<<sizeof (long long)<<" ����"<<endl;
cout<<"���������� ���� char :"<<sizeof (char)<<" ����"<<endl;
cout<<"���������� ���� double :"<<sizeof (double)<<" ����"<<endl;

// ������ ����������� ������������� � ������������ ��������


short  b  = SHRT_MAX;
int c= INT_MAX;
long d= LONG_MAX;
long long e =LLONG_MAX;

 //����������� ������
short B=SHRT_MIN;
int C= INT_MIN;
long D= LONG_MIN;
long long E =LLONG_MIN;
cout<<"���� � �� ������������ �������� \n\n"<<endl;

cout<<"��� short "<<b<<endl<<endl;
cout<<"��� long "<<d<<endl<<endl;
cout<<"���  integer"<<c<<endl<<endl;
cout<<"���  long long"<<e<<endl<<endl;
cout<<"���� � �� ����������� �������� \n\n\n"<<endl;

cout<<"���  short"<<B<<endl<<endl;
cout<<"���  integer"<<C<<endl<<endl;
cout<<"���  long"<<D<<endl<<endl;
cout<<"���  long long"<<E<<endl<<endl;

// ������� ����������� �����
unsigned short  t  = USHRT_MAX;
unsigned int g= UINT_MAX;
unsigned long l= ULONG_MAX;
unsigned long long ll =ULLONG_MAX;

cout<<"���  ��� �������� short"<<t<<endl<<endl;
cout<<"��� ��� ��������   integer"<<g<<endl<<endl;
cout<<"���   ��� �������� long"<<l<<endl<<endl;
cout<<"���   ��� ��������  long long"<<ll<<endl<<endl;

    return 0;

}
