#include "analysis.h"
#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <iomanip>
#include <cmath>
#include <conio.h>


string vovel = "аоиуяюэыёй";
#define VOVEL_COUNT 10


using namespace std;

Analysis::Analysis()
{
    totalSymbolCount=0;
    part_size =0;
    analisis_result=0;

    part_size=0;
    part_count=0;
    totalVovel=0;
      counters=0;
     syllable=0;
     eps =0;
}

//  анализ текста
void Analysis::Analys(string path){
    LoadSymbol(path);
    LoadWord(path);
    GetPartSize();
    Counting();
    CountSyllableWithLetter();

}


// загрузка текста
void Analysis:: LoadSymbol(string path){
    std::ifstream text;
    text.open(path);

    if(!text.is_open()){
        cout << "file couldn`t open " << std::endl;
        exit(1);
    }
    char c;
    while(!text.eof()){
        c = text.get();
        symbols.push_back(c);
        if(c != ' '){
        totalSymbolCount++;
        }
    }
    text.close();

}

// загрузка текста
void Analysis:: LoadWord(string path){
    std::ifstream text;
    text.open(path);
    if(!text.is_open()){
        cout << "file couldn`t open " << std::endl;
        exit(1);
    }

    std::string temp;
    while(!text.eof()){
        std::getline(text, temp,' ');
        dictionary.push_back(temp);
    }
    text.close();
}


void Analysis::GetSymbolFromUser(){
    cout << " Введите символ : " << endl;
    userChoose = getch();
    cout << " Введенный символ : " << userChoose << endl;
    eps = GetEpsilon();
}

double Analysis::GetEpsilon(){
    double temp =0;
    cout << " Введите относительность : ";
    cin >> temp;
    return temp;

}

// определение размера порции
void Analysis::GetPartSize(){

    if (totalSymbolCount !=0 ){
        if (totalSymbolCount > 0 && totalSymbolCount <= 1000){
                    part_size = 100;
        } else  if (totalSymbolCount > 1000 && totalSymbolCount <= 10000){
                    part_size = 200;
        } else  if (totalSymbolCount > 10000 && totalSymbolCount <= 50000){
                    part_size = 300;
        } else  if (totalSymbolCount > 50000 && totalSymbolCount <=100000){
                    part_size = 500;
        } else  if (totalSymbolCount > 100000 ){
                    part_size = 1000;
        }

        part_count = (totalSymbolCount/part_size);

        if (part_count * part_size < totalSymbolCount)
            part_count++;
    }
}

// заполнение таблицы
void Analysis::Counting(){
    GetSymbolFromUser();
    double countInPart[part_count];
    double iter =0;
    for(int i=0; i <part_count; i++){
        iter =0;
        for(int j = i*part_size; j < part_size*(i+1); j++){
            if(j < totalSymbolCount){
                if(symbols[j] == userChoose)
                    iter ++;
            }
        }
        countInPart[i] = iter;
    }
    CountByFormula(countInPart);
    MiddleVal(countInPart);
}

// подсчет по формуле
void Analysis::CountByFormula(double *countInPart){
    double temp;
    double iter = 0;
    for(int i=0; i < part_count; i++){
        iter +=countInPart[i];
        temp = iter /((i+1)* part_size);
        countInPart[i] = temp;
    }
}

// среднее значение
void Analysis::MiddleVal(double *countInPart){

    double temp=0;
    for (int i= 0; i < part_count-1; i++){
       if (abs(countInPart[i+1]-countInPart[i]) > eps*10){
           cout << "в файле находится большое скопление символа\' " <<userChoose
                << " \' в порции " << i+1 << "приблизительно в районе " << (i+1)*part_size  << endl;
        exit(1);
       }
    }

    for (int i= part_count-1; i>part_count-6; i--){
        cout << "значение  в порции " << i<< " = " <<fixed << setprecision(5) << countInPart[i]<< endl;
        if (abs(countInPart[i]-countInPart[i-1])< 0.01)
            temp +=countInPart[i];
    }
    analisis_result = temp/5;
}



// проверка слов и подсчет слогов
void  Analysis::Check(string word){

    int iter =0;                                // счетчик
    string str;                                 // хранение одного слова

    int vovel_count  = CountVovelInWord(word);
    totalVovel += vovel_count;
    if(vovel_count != 0){                       // если количество гласных не равно нулю
    for(int i=0; i < int( word.length()); i++){ // пройтись по слову
        if(IsVovel(word[i])){                   // находим гласную
            str+=word[i];                       // конкатенируем ее
            vs.push_back(str);
            iter++;
            str.clear();
        }else{
        str += word[i];
        }
    }

    string temp = vs.back();
    temp += str;
    vs.erase(vs.end());
    vs.push_back(temp);

    for (int i=0; i < vovel_count; i++){
        str =vs.back();
        vs.erase(vs.end());
        if (str[0] == userChoose){
            counters++;
        }
    }
    vs.clear();
    }

}



// подсчет гласных в слове
int Analysis::CountVovelInWord(string word){
    int temp =0;                                // временная переменная
    for (int i =0; i< int(word.size()); i++){   // пройтись по всему слову
        if (IsVovel(word[i])){                  // если слово гласное
               temp++;                          // увеличить счетчик
        }
    }
    return temp;
}


// проверка является ли буква гласной
bool Analysis::IsVovel(char symbol){
    for (int i =0; i < VOVEL_COUNT; i++){       // пройтись по всем гласным
        if(symbol == vovel[i])                  // если символ находися в массиве гласных
            return true;                        // вернуть true
    }
    return false;
}

// подсчет вероятности
void Analysis::CountSyllableWithLetter(){

    for(int i =0; i< int(dictionary.size()); i++){
         Check(dictionary[i]);
    }
     syllable = counters/totalVovel;
}




// отчет
void Analysis::Report(){
    cout << fixed << setprecision(5)
         << " Результат анализа         : " << analisis_result << endl;
    cout << " Размер порции             : " << part_size << endl;
    cout << " Количество порций         : " << part_count << endl;
    cout << " Количество символов       : " << totalSymbolCount << endl;
    cout << " Вероятность в слоге       : " << syllable << endl;
    cout << " Общее количество слогов   : " << totalVovel << endl;
    cout << " Кол. слогов по условию    : " << counters << endl;
}
