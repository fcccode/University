//bench.cpp --Реализация класса TBench

#include <stdio.h >
#include "bench.h"

//Вызывает тестируемую функцию tf numTests раз
void TBench::Benchmark(long numTests, test tf)
{
 printf("Running %1d tests...",numTests);
 Reset();     //Reset timer to zero
 Start();     //Start timing
 while (--numTests >= 0)
  (*tf)();    //Call user test function
 Stop();       //Stop timing
 puts("\nTests completed");
}

//Выводит результаты теста
void TBench::Report(void)
{
 double result = Time();
 if(result < Resolution))
   puts("Results too small for accuracy");
  printf("Elapsed time == %6f sec.\n", result);
}  

}
