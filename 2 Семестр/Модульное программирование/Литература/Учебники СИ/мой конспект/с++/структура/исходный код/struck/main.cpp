#include <iostream>
#include <clocale>
#include <string>
#include <cstring>

        using namespace std;
        struct data
                {
                    char name[10] ;
                    string sname;
                    string fname ;
                };

        int main()
                {
                    setlocale(LC_ALL, "rus");
                    cout << "Please entering your personal dates :" << endl;
                    data num1={  "Arslan","Annaev","Gurbandurdyevic"};
                    data num2 {};
                    cin>>num2.name;
                    cout<<endl;
                    cout <<  num1.name;<< endl;
                    cin>>num2.sname;
                    cout<<num2.sname<<endl;
                     cout <<  num2.name;

                    return 0;
                }
