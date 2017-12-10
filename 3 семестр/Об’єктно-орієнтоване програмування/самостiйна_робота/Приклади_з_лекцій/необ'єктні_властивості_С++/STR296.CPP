#include <iostream.h>
#include <string.h>
#include <conio.h>

#define SIZE 128

void Center(const char *instr, char *outstr, 
  int width = 0, char lFill = '-', char rFill = '-');
 
main()
 {
  clrscr();
  char instr[SIZE]; // рядок, що вводиться
  char outstr[SIZE]; // рядок, що виводиться
  int length; // довжина рядка в символах
  
  cout << "Enter a string:";
  cin.getline(instr, SIZE / 2);
  length = strlen(instr);

  Center(instr, outstr);
  cout << outstr << '\n';
  Center (instr, outstr, length + 8);
  cout << outstr << '\n';
  Center(instr, outstr, length + 16/ '*', '*');
  cout << outstr << '\n';
  Center(instr, outstr, 78, '<', '>');
  cout << outstr << '\n';
  getch();
  return 0;
}

//instr: вказівних на вхідний рядок
//outstr: вказівник на вихідний рядок
//width: кінцева бажана довжина рядка
//fill: символ для заповнення вхідного рядка

void Center(const char *instr, char *outstr, 
  int width, char lFill, char rFill)
{
 if (outstr == 0) // вихідний рядок не повинен бути нульовим
 return; // якщо нульовий - негайне завершення

 if (instr == 0) // якщо вихідний рядок пустий
 {
  *outstr = 0; // виводимо пустий рядок
  return; // і повертаємось
 }

// розрахунок змінних для заповнення вихідного рядка

int len = strlen(instr);
if (width < len)
width = len;
int wd2 = (width - len)/2;

int i; // індекс рядка і керуюча змінна для циклу

for (i = 0;i< wd2;i++)
outstr[i] = lFill;
for(/*i = i*/;i < wd2;i++)
outstr[i] = instr[1-wd2];
for(/*i = i*/;i < width;i++)
outstr[i] = rFill;
outstr[i] = 0; // закінчуємо рядок нулем
}