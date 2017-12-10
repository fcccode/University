program task_1_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  a,b,c,d,e,f,z:real;
begin
  Writeln('Введите значения переменным');
  Write('a=');
  readln(a);
  Write('b=');
  readln(b);
  Write('c=');
  readln(c);
  Write('d=');
  readln(d);
  Write('e=');
  readln(e);
  Writeln('','a=',a:3:2,'b=',b:3:2 ,'c=',c:3:2,'d=',d:3:2, 'e=',e:3:2);
  if (a>0) and (e=0) and (d>0) then
     begin
        f:=a*a*a+e-(b*c)-d*d;
        z:=e+a;
        Writeln('f=',f:3:2,'z=',z:3:2);
    end
  else
      begin
        f:=(a+b+d)-e/c;
        z:=0;
         Writeln('f=',f:3:2,'  ','z=',z:3:2);
      end;
      readln;
end.

