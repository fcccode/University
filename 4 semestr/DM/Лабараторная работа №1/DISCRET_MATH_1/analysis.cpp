#include "analysis.h"
#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <iomanip>
#include <cmath>
#include <conio.h>


string vovel = "���������";
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

//  ������ ⥪��
void Analysis::Analys(string path){
    LoadSymbol(path);
    LoadWord(path);
    GetPartSize();
    Counting();
    CountSyllableWithLetter();

}


// ����㧪� ⥪��
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

// ����㧪� ⥪��
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
    cout << " ������ ᨬ��� : " << endl;
    userChoose = getch();
    cout << " �������� ᨬ��� : " << userChoose << endl;
    eps = GetEpsilon();
}

double Analysis::GetEpsilon(){
    double temp =0;
    cout << " ������ �⭮�⥫쭮��� : ";
    cin >> temp;
    return temp;

}

// ��।������ ࠧ��� ���樨
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

// ���������� ⠡����
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

// ������ �� ��㫥
void Analysis::CountByFormula(double *countInPart){
    double temp;
    double iter = 0;
    for(int i=0; i < part_count; i++){
        iter +=countInPart[i];
        temp = iter /((i+1)* part_size);
        countInPart[i] = temp;
    }
}

// �।��� ���祭��
void Analysis::MiddleVal(double *countInPart){

    double temp=0;
    for (int i= 0; i < part_count-1; i++){
       if (abs(countInPart[i+1]-countInPart[i]) > eps*10){
           cout << "� 䠩�� ��室���� ����讥 ᪮������ ᨬ����\' " <<userChoose
                << " \' � ���樨 " << i+1 << "�ਡ����⥫쭮 � ࠩ��� " << (i+1)*part_size  << endl;
        exit(1);
       }
    }

    for (int i= part_count-1; i>part_count-6; i--){
        cout << "���祭��  � ���樨 " << i<< " = " <<fixed << setprecision(5) << countInPart[i]<< endl;
        if (abs(countInPart[i]-countInPart[i-1])< 0.01)
            temp +=countInPart[i];
    }
    analisis_result = temp/5;
}



// �஢�ઠ ᫮� � ������ ᫮���
void  Analysis::Check(string word){

    int iter =0;                                // ���稪
    string str;                                 // �࠭���� ������ ᫮��

    int vovel_count  = CountVovelInWord(word);
    totalVovel += vovel_count;
    if(vovel_count != 0){                       // �᫨ ������⢮ ������ �� ࠢ�� ���
    for(int i=0; i < int( word.length()); i++){ // �ன��� �� ᫮��
        if(IsVovel(word[i])){                   // ��室�� ������
            str+=word[i];                       // �����⥭��㥬 ��
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



// ������ ������ � ᫮��
int Analysis::CountVovelInWord(string word){
    int temp =0;                                // �६����� ��६�����
    for (int i =0; i< int(word.size()); i++){   // �ன��� �� �ᥬ� ᫮��
        if (IsVovel(word[i])){                  // �᫨ ᫮�� ���᭮�
               temp++;                          // 㢥����� ���稪
        }
    }
    return temp;
}


// �஢�ઠ ���� �� �㪢� ���᭮�
bool Analysis::IsVovel(char symbol){
    for (int i =0; i < VOVEL_COUNT; i++){       // �ன��� �� �ᥬ �����
        if(symbol == vovel[i])                  // �᫨ ᨬ��� ��室��� � ���ᨢ� ������
            return true;                        // ������ true
    }
    return false;
}

// ������ ����⭮��
void Analysis::CountSyllableWithLetter(){

    for(int i =0; i< int(dictionary.size()); i++){
         Check(dictionary[i]);
    }
     syllable = counters/totalVovel;
}




// ����
void Analysis::Report(){
    cout << fixed << setprecision(5)
         << " ������� �������         : " << analisis_result << endl;
    cout << " ������ ���樨             : " << part_size << endl;
    cout << " ������⢮ ���権         : " << part_count << endl;
    cout << " ������⢮ ᨬ�����       : " << totalSymbolCount << endl;
    cout << " ����⭮��� � ᫮��       : " << syllable << endl;
    cout << " ��饥 ������⢮ ᫮���   : " << totalVovel << endl;
    cout << " ���. ᫮��� �� �᫮���    : " << counters << endl;
}
