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
    cout << "���������� ��� ������������ : \n\n";
    cout << "������� ������ ��-15\n"
         << "������ ������ \n"
         << "***KNTU***\n";
}


void conus::PrintAtributes()
{
    cout << "����� ������     :" << (vys*plos)  << endl;
    cout << "������ ��������� :" << rad  << endl;
    cout << "������ ������    :" << vys  << endl;
    cout << "������� ���������:" << plos << endl;
}
void conus::PrintObm()
{
    cout << "����� ������     :" << plos*vys  << endl;
}

void conus::ChangeAtributes(double dob_rad, double dob_vys, double dob_plos)
{
cout << "������ �������� :\n";
PrintAtributes();
rad = dob_rad;
vys = dob_vys;
plos = dob_plos;
}





#endif // PERSONAL_DATAS_H_INCLUDED
