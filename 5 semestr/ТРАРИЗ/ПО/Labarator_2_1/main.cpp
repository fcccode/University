#include <iostream>

using namespace std;



int counter = 0;
int n = 10;
int a[10];
int temp = 0;
int t = 0;


void Generate()
{
    int i =0, j =0;
    if(t == n)
    {
        for(i = 0; i < n; i++)
            cout << a[i];
    }
    else
    {
        for(j = t+1; j < n; j++)
        {
            temp = a[t+1];
            a[t+1] =  a[j];
            a[j] = temp;
            t = t+1;
            Generate();
            t = t-1;
            temp = a[t+1];
            a[t+1] =  a[j];
            a[j] = temp;
        }

    }
}

int main()
{
    setlocale(LC_ALL, "rus");      // локализация

    for(int i = 0; i < n; i++)
        a[i] = i;

    Generate();
    return 0;
}



