#ifndef ANALYSIS_H
#define ANALYSIS_H
#include <string>
#include <vector>
using namespace std;

class Analysis
{
private:
    vector<string> dictionary;
    vector <char> symbols;
    vector <string> vs;
    char userChoose;
    double analisis_result;

    int totalSymbolCount;
    int part_size;
    int part_count;
    double totalVovel;
    double counters;
    double syllable;
    double eps;


     void LoadWord(string path);                 // загрузка текста в словарь
     void LoadSymbol(string path);                 // загрузка текста в словарь
     void GetPartSize();                         // определение размера порции
     void Counting();                            // заполнение таблицы
     void CountByFormula(double *countInPart);
     void MiddleVal(double *countInPart);
     void GetSymbolFromUser();
     double GetEpsilon();
     void CountSyllableWithLetter();
     int  CountVovelInWord(string word);
     bool IsVovel(char symbol);
     void  Check(string word);
public:
    Analysis();
    void Analys(string path);                   //  анализ текста
    void Report();                              // отчет
};

#endif // ANALYSIS_H
