#include <iostream.h>

class TPoint {
private:
int x, y;
public:
TPoint() { x = y = 0; }
TPoint(int xx, int yy) { x = xx; y = yy; }
void PutX(int xx) { x = xx; }
void PutY(int yy) { y = yy; }
int GetX(void) { return x; }
int GetY(void) { return y; }
friend ostream& operator<<(ostream& os, TPoint &p);
friend istream& operator>>(istream& is, TPoint &p);
}; 	
main()
{
TPoint p;
cout << p << '\n';
p.PutX(100);
p.PutY(200);
cout<<p<<'\n';
cout<<"\nEnter x and y values:";
cin>> p;
cout << "\nYou entered: " << p;
return 0;
}
ostream& operator<<(ostream& os, TPoint &p)
{
os<< "x == "<<p.x <<"y =="<<p.y;
}
istream& operator>>(istream& is, TPoint &p)
{
is>> p.x >> p.y;
return is;
}
