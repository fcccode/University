#include <iostream>
#include <clocale>
#include <cstring>

using namespace std;



int main()
{   setlocale(LC_ALL, "rus");
    cout << "Программа    \n" << endl;
    string str1,s;
    cin >> str1;

    int len = str1.length();
    for (int i=0; i<len ; i++)
    {
        if (isdigit(str1[i]))
           s += str1[i];
    }
    cout << "" << s;
    return 0;
}
