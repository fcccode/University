#include <iostream>
#include <display_graph.h>

using namespace std;

void Separator(int length){
    cout << endl;
    for (int i=0; i< length; i++){
        cout << "=";
    }
    cout << endl;
}

int main()
{
    graph object(6);
    Separator(50);
    object.AdjacencyMatrix();
    Separator(50);
    object.AdjacencyList();
    Separator(50);
    object.EdgeList();
    Separator(50);
    object.IncidenceMatrix();




    return 0;
}
