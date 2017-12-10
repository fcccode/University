#include<iostream>
class PseudoArray {
private: 
int value0; 
int value1; 
int value2; 
int value3; 
public:
PseudoArray(int v0, int v1, int v2, int v3)
{ value0 = v0; value1 = v1; value2 = v2; value3 = v3;} 
int GetInt(unsigned i);
int operator[](unsigned i);
};
main()
{
PseudoArray pa(10, 20, 30, 40);
for (int i = 0; i <= 3; i++)
cout << "pa[" << i << "] == "<<pa[i]<<'\n';
return 0;
}
int PseudoArray::GetInt(unsigned i)
{
switch(i){
case0:return value0;
case1:return value1;
case2:return value2;
case3:return value3;
default:return value0;
}
}
int PseudoArray::operator[](unsigned i)
{
return GetInt(i);
}
