// bench.h --Объявление класса TBench

#ifndef__BENCH_H
#define__BENCH_H 1  //Предотвращение нескольких #include

#include <classlib\timer.h>

typedef void (* testfn)(void)

class TBench: public TTimer{
public:
 TBench():TTimer() { }
 void Benchmark(long numTests, testfn tf);
 void Report(void);
 };
 
 #endif           // __BENCH_H
 