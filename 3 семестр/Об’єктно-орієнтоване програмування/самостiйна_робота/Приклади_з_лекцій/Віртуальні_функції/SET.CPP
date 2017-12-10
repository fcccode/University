//set.cpp -- реализация класса TSet

#include <iostream.h>
#include <stdlib.h>
#include "set.h"

//Добавляет элемент в множество. (В случае ошибки программа прерывается!)
void TSet::AddElem(PTElem p)
{
  if (set == NULL) {
    cout << "\nERROR:  Out of memory";
	exit(1);
  }
  if (index >= max) {
    cout << "\nERROR: Set limit exceeded";
	exit(1);
  }
  set[index] = p;
  ++index;
 } 
  
//Возвращает истину, если элемент, адресуемый р, находится в множестве
int TSet::HasElem(PTElem p)
{
  if (SET ==NULL)
    return 0;     //В пустом множестве не может быть элементов
  for (int i = 0; i < index; i++)
   if (CompareElems(p, set[i] ==0)
     return 1;      //Элемент в множестве
   return 0;        // Элемента в множестве нет
}
	 











   