#ifndef CLASSLIB_H_INCLUDED
#define CLASSLIB_H_INCLUDED

using namespace std;

class conus {
private:

    double obm = 1;
    double rad = 1;
    double plos =1;
    double vys = 1;

public:
void PrintDatas();
void PrintAtributes();
void ChangeAtributes(double rad, double vys, double plos);
void PrintObm();
};




#endif // CLASSLIB_H_INCLUDED
