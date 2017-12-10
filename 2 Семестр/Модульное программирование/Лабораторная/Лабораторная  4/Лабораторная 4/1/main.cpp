#include <iostream>
#include <fstream>
#include <cstdlib>
#include <cstring>
#include <string>
#include <bitset>
#include <string>

using namespace std;

int main()
{


	int i = system("fc Exit.txt File.txt");
	if(i==0)
		cout << "The different";
	else if(i==1)
		cout << "The different";
	else
		cout << "Error";



















/*
char c; int i=0;

setlocale(LC_ALL,"rus"); // локализация

ifstream infile; infile.open("Exit.txt");

if (infile.is_open()) cout << "open"; else cout << "close";

while (infile.get(c)){i++;}



char ch[i]; int d=1; char e=0;

infile >> e;

/*
while (infile.get(e))
{  ch[d] =c; d++; }

for (int j=0; j<d; j++)
{  cout << ch[j];}

cout << "    "<< e;






ifstream in;
in.open("File.txt");
if (in.is_open()) cout << "open";
else cout << "close";
string str;

in >> str;


char ch[3];

/*
for (int k=0; k<3; k++)
{
    in.get(str );
    ch[k]=str[k];
}

for (int k=0; k<3; k++)
{
    cout << ch[k];
}
//in.getline(str,'\"');

*/




return 0;
}
