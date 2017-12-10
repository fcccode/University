#include <iostream.h>
#include <stdlib.h>
#include <string.h>

#define FALSE 0
#define TRUE 1
#define SIZE 10
#define BUFLEN 20

double &ref(int index);
void ShowArray (void);
double array[SIZE];

main()
{
 int done = FALSE, index;
 char buffer[BUFLEN];
 
 for (index = 0; index < SIZE; index++)
 ref(index) = index; // присвоювання посилкової функції
 while(!done) 
{ 
 ShowArray();
 cout << "\nEnter index from 0 to 9, Enter to quit:";
 cin.getline(buffer, BUFLEN);
 done = (strlen(buffer) == 0);
 if(!done)
{
 index = atoi(buffer);
 cout << "Enter floating-point value:";
 cin.getline(buffer, BUFLEN);
ref(index) = atof(buffer);
}
}
return 0;
}
double &ref(int index)
{
 if((index < 0) || (index >= SIZE))
 index = 0;
 return array[index]; // повернути ссилку на елемент масива
}
 void ShowArray(void)
{
 cout << "\n Array: \n";
 for (int i = 0; i < SIZE; i++)
 cout << "[" << i << "] == " << array[i] <<'\n';
}
 