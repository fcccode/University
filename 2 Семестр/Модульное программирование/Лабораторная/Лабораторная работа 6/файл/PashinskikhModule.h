#ifndef T3LIB_H_INCLUDED
#define T3LIB_H_INCLUDED

using namespace std;

bool toggle = 0;

class Watermelon{
public:

    int edge;
    int weight;
    int seeds;

    Watermelon(int m_edge, int m_weight, int m_seeds){
        if (toggle == 0){
            SetData(m_edge, m_weight, m_seeds);
            toggle = 1;
        }
        cout << endl;
        cout << "�����, ����i�! � - ��������i� ���i����� ������. " << endl;
        cout << "����� ��i������ ������� � ����i, ���� �� �i���i��� ���i������, " << endl;
        cout << "��� �������� i�������i� ��� �i� ��\'��, ��� ���� ������." << endl;
        cout << endl;
    }
    int V() {
        return edge*edge*edge;
    }
    string About();
    void SetData(int m_edge, int m_weight, int m_seeds);

    int PrintEdge(){
        return edge;
    }
    int PrintWeight(){
        return weight;
    }
    int PrintSeeds(){
        return seeds;
    }

private:
protected:
};

string Watermelon::About(){
    string str = "������� �������� ���������� ��������� ��������� - ������� ����.";
    return str;
}
void Watermelon::SetData(int m_edge, int m_weight, int m_seeds){
    edge = m_edge;
    weight = m_weight;
    seeds = m_seeds;
}

#endif // T3LIB_H_INCLUDED
