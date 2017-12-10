#ifndef PERSONAL_DATAS_H_INCLUDED
#define PERSONAL_DATAS_H_INCLUDED


using namespace std;

class conus {
public:
    double rad = 1;
    double plos =1;
    double vys = 1;
    double obm = plos*vys;
void PrintDatas();
void PrintAtributes();
void ChangeAtributes(double rad, double vys, double plos);
void PrintObm();
double Printobm(){return rad*plos;};
};

void conus::PrintDatas()
{
    cout << "Информация про разработчика : \n\n";
    cout << "Студент Группы КИ-15\n"
         << "Аннаев Арслан \n"
         << "***KNTU***\n";
}


void conus::PrintAtributes()
{
    cout << "Объем конуса     :" << (vys*plos)  << endl;
    cout << "Радиус основания :" << rad  << endl;
    cout << "Высота конуса    :" << vys  << endl;
    cout << "Площадь основания:" << plos << endl;
}
void conus::PrintObm()
{
    cout << "Объем конуса     :" << plos*vys  << endl;
}

void conus::ChangeAtributes(double dob_rad, double dob_vys, double dob_plos)
{
cout << "Старые атрибуты :\n";
PrintAtributes();
rad = dob_rad;
vys = dob_vys;
plos = dob_plos;
}





#endif // PERSONAL_DATAS_H_INCLUDED
