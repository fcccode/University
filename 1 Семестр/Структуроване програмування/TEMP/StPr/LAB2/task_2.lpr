program task_2;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  o,k,n,g:integer;
  m,t,f:real;
begin
  Writeln('Введите значения:');
  Write('Общее количество заявок абитуриентов в текущем году:',' ');
  readln(o);
  Write('Количество абитуриентов допущенных до конкурса:',' ');
  readln(k);
  Write('Зачисленно по Госзаказу:');
  readln(g);
   n:=o-k-g;
   m:=n*100/o;
   t:=g*100/o;
    f:=k*100/o;
  writeln(m:2:1,' ',' ','процентов от общего количества заявок, не допущенно до конкурса ');
  writeln(t:2:1,' ','процентов от общего количества заявок, зачислено по Госзаказу');
  writeln(f:2:1,' ''Процентов от общего количества заявок, зачисленно по контракту');
  readln;
end.

