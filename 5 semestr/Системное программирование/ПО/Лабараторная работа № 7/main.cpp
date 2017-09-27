/*****************************************
******** Закрытие и удаление файла********
******************************************/
/** закрытие
    СloseHandle(lpHandle);
*/
/** Удаление
    BOOL DeleteFile(
                    LPCTSTR lpFileName; // полный путь до файла
                    );
*/
#include <windows.h>
#include <iostream>

using namespace std;

int main()
{
    if (!DeleteFile("C:\\demo_file.dat"))
    {
        cerr << "Delete file failed\n";
        cout << "Press any key to finish\n";
        cin.get();
        return 0;
    }

    cout << "file is deleted\n";
    return 0;
}
