program SUM_and_Qv;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  x,y:integer;
  z:Int64;
  procedure Sum(a,b:integer; var rez:int64);
begin
  rez:=a+b;
end;
function Qv(x:integer):int64;
begin
  qv:=x*x;
end;
begin
  write('Введите два натуральных числа');
  readln(x,y);
  Sum(x,y,z);
  writeln(x,'+',y,'=', z);
  writeln(x,'^2=', Qv(x), #10#13, y,'^2=', Qv(y));
  readln;
end.
