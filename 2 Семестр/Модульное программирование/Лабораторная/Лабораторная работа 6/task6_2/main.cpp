#include <iostream>
#include <fstream>
#include <windows.h>
#include <cstring>
#include "Personal_Datas.h"

using namespace std;

class Teacher{
public:
    Teacher(){
        TestSuite();
    }
private:
    void TestSuite(){
        ofstream output;
        output.open("Prov.txt", ios::trunc);
conus abstract;
        ifstream prj;
        prj.open("C:\\Users\\Арслан\\Desktop\\2 Семестр\\Модульное программирование\\Лабораторная\\Лабораторная работа 6\\task6_2\\main.cpp", ios::in);
        if (!prj.is_open()){
            prj.close();
            cout << "Ошибка файл не открывается!" << endl;
            output << "Установленные требования к лабораторной работе НАРУШЕНЫ!" << endl;;
            output.close();
            for (int i=0; i!=100; i++){
                cout << "\a";
                Sleep(100);
            }
        }
        else {
            output << "Разработчик Аннаев Арслан" << endl;
            output << "Время и дата компиляции: " << __TIMESTAMP__ << endl;
            output.close();

            double dob_rad, dob_vys, dob_plos;





            streambuf *old = cout.rdbuf(0);


            cout.rdbuf(old);

            for (int i=1; i!=4; i++)
                {
                if (abstract.rad == dob_rad)
                    cout << "TEST_CASE_D " << i << ": PASSED" << endl;
                else
                    cout << "TEST_CASE_D " << i << ": FAILED" << endl;
                dob_plos+5;
                dob_rad+5;
                dob_vys+5;
            }
            for (int i=1; i!=4; i++) {
                if (abstract.Printobm()==(abstract.plos*abstract.vys))
                    cout << "TEST_CASE_V " << i << ": PASSED" << endl;
                else
                    cout << "TEST_CASE_V " << i << ": FAILED" << endl;
                abstract.vys+5;
            }
        }
    }
protected:
};

int main()
{
    setlocale(LC_ALL, "rus");
    Teacher TestSuite;
    return 0;
}
