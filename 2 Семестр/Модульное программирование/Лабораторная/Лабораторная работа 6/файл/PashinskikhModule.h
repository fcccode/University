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
        cout << "Друже, привiт! Я - абстракцiя кубiчного кавуна. " << endl;
        cout << "Можеш змiнювати довжину моєї гранi, вагу та кiлькiсть насiннячок, " << endl;
        cout << "або отримати iнформацiю про мiй об\'єм, про мого творця." << endl;
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
    string str = "Додаток розробив Пашинських Владислав Вадимович - студент КНТУ.";
    return str;
}
void Watermelon::SetData(int m_edge, int m_weight, int m_seeds){
    edge = m_edge;
    weight = m_weight;
    seeds = m_seeds;
}

#endif // T3LIB_H_INCLUDED
