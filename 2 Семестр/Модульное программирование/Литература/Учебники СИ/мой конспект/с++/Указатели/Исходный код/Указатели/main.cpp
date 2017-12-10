#include <iostream>
#include <clocale>

using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
/*
	// объявление указателя
	int cars=250; // инициализация переменной
	int *pr = &cars; // указатель на адрес

		cout << "Значение переменной cars  : "<<cars <<"  штук"<< endl;
		cout << "Адрес по которому размещена переменная cars :  "<<&cars << endl;
		cout << "Значение переменной cars через указатель : "<<*pr <<"  штук"<< endl;
		cout << "Адрес по которому размещена переменная cars через указатель :  "<<pr << endl;
		cout << "Адрес самого указателя  :  "<<&pr << endl;
*/
/*
		// Создание динамического выделения памяти
		int *pt = new int;
		*pt =45;
		cout << "Значение переменной   : "<<*pt << endl;
		cout << "Адрес по которому размещена переменная pt через указатель :  "<<pt << endl;
		cout << "Адрес самого указателя  :  "<<&pt << endl;
		delete pt;
		cout << "Значение переменной   : "<<*pt << endl;
*/
/*
// Указатель на массив
int *pd = new int [10];
pd[0]=3;
pd[1]=10;
pd[9]=12;
cout << "Значение переменной   : "<<&pd[0] << endl;
cout << "Значение переменной   : "<<&pd[0]+1 << endl;
cout << "Значение переменной   : "<<&pd[0]+2 << endl;
delete [] pd;
*/
/*
double wave[3]={2.0, 3.2, 4.2};
int p2[3] {2, 3, 5};
double *p1=wave;
int *p3 =&p2[0];
cout << "Значение переменной p10   : "<<p1[0] << endl;
cout << "Значение переменной p11   : "<<p1[1] << endl;
cout << "Значение переменной p12   : "<<p1[2] << endl;
cout << "Адрес самого указателя  :  "<<p1 << endl;
cout << "Адрес самого указателя  :  "<<&p1[0] << endl;
cout << "Адрес самого указателя  :  "<<p1+1 << endl;
cout << "Адрес самого указателя  :  "<<&p1[1] << endl;
cout << "Адрес самого указателя  :  "<<p1+2 << endl;
cout << "Адрес самого указателя  :  "<<&p1 << endl;
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
