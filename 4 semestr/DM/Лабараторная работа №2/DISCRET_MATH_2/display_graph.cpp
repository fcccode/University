#include "display_graph.h"

#include <vector>
#include <string>
#include<iostream>
using namespace std;

// GRAPH
//===================================================================
// конструктор по умолчанию
graph::graph(int vertex_count){
    this->vertex_count = vertex_count;
    CreateGraph(vertex_count);
}

//=====================================================================================
// создание графа
void graph::CreateGraph(int vertex_count){
    cout << "\n\tFilling vertex value " << endl;
    for(int i=0; i< vertex_count; i++){
        vertex temp(i);
        setVertexList(i,&temp);
        list_vertex.push_back(temp);
    }
    Algorithm();
}

//=====================================================================================
// заполнения списка смежных вершин
void graph::setVertexList(int i, vertex *ver){
    string temp;
    cout << " # " << i+1 << " enter the \'VERTEX\' id as [1,2,3,4] = ";
    cin >> temp;
    ParseString(temp,ver);
}

//=====================================================================================
// парсинг строки
void graph::ParseString(string str, vertex *ver){
    string temp;
    for(int i = 0; i < int (str.length()); i++){
        if(!isdigit(str[i])){
            ver->list.push_back(atoi(temp.c_str()));
            temp.clear();
         }
        else{
            temp += str[i];
        }
    }
    ver->list.push_back(atoi(temp.c_str()));
}

//=====================================================================================
// алгоритм преобразования полученых данных о вершинах в список ребер
void graph::Algorithm(){
    int count = 0;
     for(int i=0; i< vertex_count; i++)
         for(int j=0; j < int(list_vertex[i].list.size()); j++){
             edge temp(count);

             temp.beg = i+1;
             temp.end = list_vertex[i].list[j];
             if(check_edge(&temp)){
                list_edge.push_back(temp);
                count++;
             }
         }
     edge_count = count;
}


//=====================================================================================
// проверка списка ребер
bool graph:: check_edge(edge *temp){
    for(int i=0; i < int(list_edge.size()); i++){
        if(((temp->beg == list_edge[i].beg)&&(temp->end == list_edge[i].end))||
            ((temp->beg == list_edge[i].end)&&(temp->end == list_edge[i].beg)))
                return false;
        }

    return true;
}


//=====================================================================================
// Adjacency Matrix
void graph::AdjacencyMatrix(){
    cout << "Adjacency Matrix with " << vertex_count << "  vertex`s" << endl;

    bool flag =false;
    for(int i=0; i < vertex_count; i++){
        for(int j=1; j <= vertex_count; j++){
            for(int k=0; k < int(list_vertex[i].list.size()); k++){
                if(list_vertex[i].list[k]== j)
                   flag = true;
            }
            if(flag){
                cout << "| " << "1" << " |";
                flag =false;
            } else {
             cout << "| " << "0"<< " |";
            }
        }
          cout << endl;
    }
}

//=====================================================================================
// Incidency Matrix
void graph::IncidenceMatrix(){
   cout << "|| Incicdency Matrix with " << vertex_count << "  vertexes ||  and"
        << edge_count <<" edges" << endl;
    for(int i=0; i < vertex_count; i++){
        for(int j=0 ; j < edge_count; j++){
            if(list_edge[j].beg == i+1 ||list_edge[j].end == i+1){
                    cout << "| " << "1" << " |";
            }
            else {
                 cout << "| " << "0"<< " |";
            }
        }
        cout << endl;
    }
}

//=====================================================================================
// Adjacency List
void graph::AdjacencyList(){
    cout << "Adjacency list with " << vertex_count << "  vertexes" << endl;
     for(int i=0; i < vertex_count; i++){
         cout << "["<< i+1 <<"] = { ";
         for(int k=0; k < int(list_vertex[i].list.size()); k++){
             cout << list_vertex[i].list[k]<<",";
         }
         cout <<"}"<< endl;
    }
}

//=====================================================================================
// Edge list
void graph::EdgeList(){
    cout << "Edge List with " << edge_count << "  edges" << endl;
    for(int j=0 ; j < edge_count; j++){
        cout << "[ " << list_edge[j].id+1 << "] : "
             << "[ " << list_edge[j].beg << "-"
             << list_edge[j].end << " ] = "
             << "{" << list_edge[j].beg << ","
             << list_edge[j].end << "}"
             << " or "
             << "{" << list_edge[j].end << ","
             << list_edge[j].beg << "}" << endl;
    }
}
//=====================================================================================

