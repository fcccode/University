#include <iostream>
#include <string>
#include <cstring>
#include <locale.h>
using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
// пример правила инициализации num1
        /*
        string cat ="How are you";
        cout << cat;
        */
//пример создани€ простого массива с выводом cin
    /*
        string str1 ;
    cin>>str1;
    cout<<"то что мы ввели " << str1 << endl;
*/
// пример ввода при помощи getline()
  /*
    string cut;
    cout<<"ѕример ввода"<<endl;
    getline(cin,cut);
    cout<<"то что ввели : "<<cut<<endl;
*/
// пример присваивани€
/*
string str1;
string str2;
cout<< "Enter"<<endl;
cin>>str1;
str2=str1;
cout<< "You write : "<< str2<<endl;

*/
// примеры конкатенации
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
// пример добавлени€
/*
string str1;
string str2;
cout<< "Enter"<<endl;
getline(cin,str1);
getline(cin,str2);
str2 +=str1;
cout<< "Enter" << str2 <<endl;
*/
// получени€ длины строки
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
