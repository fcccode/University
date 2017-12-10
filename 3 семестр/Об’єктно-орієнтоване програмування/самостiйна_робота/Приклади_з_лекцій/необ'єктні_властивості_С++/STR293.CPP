#include <iostream.h>
#include <conio.h>

#define COUNT 100 // кількість цілих значень

main()
{
 clrscr();
 int *array; // масив цілих значень
 int i; // індекс масива

  array = new int[COUNT];

  // завповнення масиву
  for (i = 0; i < COUNT; i++)
  array[i] = i;

  // виведення вмісту масиву
  for (i = 0; i < COUNT; i++)
   {
    cout.width(8);
    cout << array[i];
   }
   delete[] array;
   getch();
   return 0;
}