#include<iostream.h>
#include<except.h>
#include<conio.h>
#define MAXERR 10
class MaxErr{};
class Error{
public:
  Error();
  void Say();
private:
  static int count;
};
void Run() throw(Error);
void trapper();
void zapper();
int Error::count;
void main()
{
  set_unexpected(trapper);
  set_terminate(zapper);
  for(;;)
  {
    try{Run();}
    catch(Error e){e.Say();}
  }
}
void Run() throw(Error)
{
 throw Error();
 //throw "Nevidomyi typ obecta";
}
void trapper()
{
  cout << "Obrobnyk neperedbachenyx sytuacii.  .";
  throw Error();
}
void zapper()
{
  cout << "Obrobnyk zavershennja funkcii";
  getch();
  exit(-1);
}
Error::Error()
{
  count++;
  if(count>MAXERR)
  throw MaxErr();
  getch();
}
void Error::Say()
{
  cout << count << '\n';
}
