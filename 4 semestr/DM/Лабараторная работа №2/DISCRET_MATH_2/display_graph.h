#ifndef DISPLAY_GRAPH_H
#define DISPLAY_GRAPH_H


#include <vector>
#include <string>
using namespace std;



struct vertex{
  int id;
  vector<int> list;                   // список смежных вершин
  vertex(int id):id(id){}
};


// абстрактный класс ребра
struct edge{
    int id;
    int beg;
    int end;
    edge(int id):id(id){}
};

class graph{
    int vertex_count;
    int edge_count;
public:
    vector<vertex> list_vertex;
    vector<edge> list_edge;
    graph(int vertex_count);
    void Algorithm();
    void setVertexList(int i, vertex *ver);
    void ParseString(string str, vertex *ver);
    void CreateGraph(int vertex_count);
    bool check_edge(edge *temp);

    // представление графа
    void AdjacencyMatrix();
    void AdjacencyList();
    void IncidenceMatrix();
    void EdgeList();
};

#endif // DISPLAY_GRAPH_H
