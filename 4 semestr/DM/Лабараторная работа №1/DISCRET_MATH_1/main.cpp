#include <iostream>
#include "analysis.h"

using namespace std;

int main()
{
    string path = "D:\\1.txt";
    Analysis *object= new Analysis();
    object->Analys(path);
    object->Report();

    return 0;
}

