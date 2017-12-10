#include <iostream.h>
#include <stdlib.h>
#include <string.h>
class TStrOp {
private:
char value[12];
public:
TStrOp() { value[0] = 0; }
TStrOp(const char *s);
long GetValue(void) { return atol(value); }
long operator+(TStrOp b);
long operator-(TStrOp b);
};
main()
{
TStrOp a="1234";
TStrOp b="4321";
cout<<"\nValue of a=="<<a.GetValue();
cout<<"\nValue of b=="<<b.GetValue();
cout<<"\na+b+6=="<<(a+b+6);
cout<<"\na-b+10=="<<(a-b+10)
<<'\n';
return 0;
}
TStrOp::TStrOp(const char *s)
{
strncpy(value, s, 11);
value[11] = 0;
}
long TStrOp::operator+(TStrOp b)
{
return(atol(value) + atol(b.value));
}
long TStrOp::operator-(TStrOp b)
	{
return (atol(value) - atol(b.value));
}
