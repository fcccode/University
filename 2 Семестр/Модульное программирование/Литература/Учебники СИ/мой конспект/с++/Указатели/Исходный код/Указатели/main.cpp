#include <iostream>
#include <clocale>

using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
/*
	// ���������� ���������
	int cars=250; // ������������� ����������
	int *pr = &cars; // ��������� �� �����

		cout << "�������� ���������� cars  : "<<cars <<"  ����"<< endl;
		cout << "����� �� �������� ��������� ���������� cars :  "<<&cars << endl;
		cout << "�������� ���������� cars ����� ��������� : "<<*pr <<"  ����"<< endl;
		cout << "����� �� �������� ��������� ���������� cars ����� ��������� :  "<<pr << endl;
		cout << "����� ������ ���������  :  "<<&pr << endl;
*/
/*
		// �������� ������������� ��������� ������
		int *pt = new int;
		*pt =45;
		cout << "�������� ����������   : "<<*pt << endl;
		cout << "����� �� �������� ��������� ���������� pt ����� ��������� :  "<<pt << endl;
		cout << "����� ������ ���������  :  "<<&pt << endl;
		delete pt;
		cout << "�������� ����������   : "<<*pt << endl;
*/
/*
// ��������� �� ������
int *pd = new int [10];
pd[0]=3;
pd[1]=10;
pd[9]=12;
cout << "�������� ����������   : "<<&pd[0] << endl;
cout << "�������� ����������   : "<<&pd[0]+1 << endl;
cout << "�������� ����������   : "<<&pd[0]+2 << endl;
delete [] pd;
*/
/*
double wave[3]={2.0, 3.2, 4.2};
int p2[3] {2, 3, 5};
double *p1=wave;
int *p3 =&p2[0];
cout << "�������� ���������� p10   : "<<p1[0] << endl;
cout << "�������� ���������� p11   : "<<p1[1] << endl;
cout << "�������� ���������� p12   : "<<p1[2] << endl;
cout << "����� ������ ���������  :  "<<p1 << endl;
cout << "����� ������ ���������  :  "<<&p1[0] << endl;
cout << "����� ������ ���������  :  "<<p1+1 << endl;
cout << "����� ������ ���������  :  "<<&p1[1] << endl;
cout << "����� ������ ���������  :  "<<p1+2 << endl;
cout << "����� ������ ���������  :  "<<&p1 << endl;
delete [] p1;
delete [] p3;
*/
int ch=45;
int *ukaz=&ch;

cout<<"Adress"<<&ukaz<<endl;
cout<<"Adress"<<ukaz<<endl;
cout<<"Znacheniye" << *ukaz<< endl;
    return 0;
}
