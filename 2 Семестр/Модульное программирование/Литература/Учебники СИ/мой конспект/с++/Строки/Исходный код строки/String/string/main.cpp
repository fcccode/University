#include <iostream>
#include <string>
#include <cstring>
#include <locale.h>
using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
// ������ ������� ������������� num1
        /*
        string cat ="How are you";
        cout << cat;
        */
//������ �������� �������� ������� � ������� cin
    /*
        string str1 ;
    cin>>str1;
    cout<<"�� ��� �� ����� " << str1 << endl;
*/
// ������ ����� ��� ������ getline()
  /*
    string cut;
    cout<<"������ �����"<<endl;
    getline(cin,cut);
    cout<<"�� ��� ����� : "<<cut<<endl;
*/
// ������ ������������
/*
string str1;
string str2;
cout<< "Enter"<<endl;
cin>>str1;
str2=str1;
cout<< "You write : "<< str2<<endl;

*/
// ������� ������������
/*
string str1;
string str2;
string str3;
cout<< "Enter"<<endl;
 getline(cin,str1);
  getline(cin,str2);
    str3 = str1 + str2;
  cout<< "Enter"<<str3<<endl;
  */
// ������ ����������
/*
string str1;
string str2;
cout<< "Enter"<<endl;
getline(cin,str1);
getline(cin,str2);
str2 +=str1;
cout<< "Enter" << str2 <<endl;
*/
// ��������� ����� ������
 static char charr[] {};
 string str1;
 cout<<strlen(charr)<<"  letters"<<endl;
 cout<<str1.size()<<"  letters"<<endl;
 cout<<"Enter the first string for char"<<endl;

 cout<<"Enter string for string "<<endl;
 getline (cin, str1);
 cout<<"you entered "<<strlen(charr)<<"  letters"<<endl;
 cout<<"you entered "<<str1.size()<<"  letters"<<endl;


    return 0;
}
