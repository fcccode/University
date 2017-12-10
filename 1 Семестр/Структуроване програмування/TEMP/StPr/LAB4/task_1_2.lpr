program task_1_2;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
 var
   a,b,c,m:real;
begin
  Writeln('Введите значение а=');
  readln(a);
  Writeln('Введите значение b=');
  readln(b);
  Writeln('Введите значение c=');
  readln(c);
  if a>b then
              m:=b
  else
              m:=b;
  if m<c then
              m:=c
  else
  Writeln('m=',m);
  readln;
end.

