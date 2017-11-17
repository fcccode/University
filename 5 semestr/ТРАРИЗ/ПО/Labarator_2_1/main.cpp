#include <iostream>

using namespace std;


void ReadKey()
{
    int key;                        // введенное значение
    cout << "Введите значение :";   // приглашение ввести значение
    cin >> key;                     // ввод значения
    if(key != 0)                    // проверка окончания ввода
        ReadKey();                  // рекурсивный вызов функции

    cout << key << endl;            // дошли до дна отображаем все
}

int main()
{
    setlocale(LC_ALL, "rus");      // локализация
    ReadKey();                     // вызов функции
    return 0;
}



