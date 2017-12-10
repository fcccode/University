#include <iostream>
#include <fstream>
#include <stdio.h>
#include <string>
#include <string.h>
#include <cstdlib>
#include <clocale>

using namespace std;

int main()
{
    char name[100];
    cin.get(name, 100);
    ofstream outfile;
    strcat(name, ".txt");



    outfile.open(name);








outfile << "строки равны";

	return 0;

}
