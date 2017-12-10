#include <iostream.h>
#include <stdio.h >
#include "bench.h"

#define NUMTESTS 20000

void Testfn(void)

main( )
{
 TBench test; 
 
 out << "Testing sprintf() fun tion\n";
 test Benchmark(NUMTESTS, Testfn);
 test.Report();
 return 0;
}
 
void Testfn(void)
{ 
  har buffer[80];
  double d = 3.14159;
  
  sprintf(buffer, "%1f", d);
}
  