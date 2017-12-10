program task_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  one_d:real;
begin
  Writeln('Введите значение');
  readln(one_d);
  Write('one_d=', one_d:5:2,' ');
  one_d:=one_d*one_d;
  Writeln('Полученное значение',' ', one_d:5:2);
  Writeln('Введите значение');
  readln(one_d);
  Write('one_d=', one_d:5:2,' ');
  one_d:=one_d*one_d;
  Writeln('Полученное значение',' ', one_d:5:2);
  readln;
end.

