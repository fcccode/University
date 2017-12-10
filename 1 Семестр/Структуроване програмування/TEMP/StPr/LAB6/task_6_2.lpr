program task_7_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  x:array[1..20] of integer;
  i,a,y:integer;
  ch:char;
begin
  repeat
    writeln('Введите 20 натуральных чисел ');
     for i:=1 to 20 do
         begin
              write('x(',i,')=');
              readln(x[i]);
         end;
          Writeln('введеный вами массив состоит из');
          for i:=1 to 20 do
               write('x(',i,')=', x[i]:2,' ');
            Writeln('Для продолжения нажмите Enter');
          readln;
         a:=0;
         y:=0;
     for i:=1 to 20 do
         if x[i] mod 2=0
            then
                 a:=a+1
            else
                begin
                   y:=y+1;
                end;
                 writeln('В введенных вами числах',' ',a,' четных');
                 writeln('И ',y,' нечетных');
                 Writeln('Для завершения нажмите "Y" или "N" для повторения');
                 readln(ch);
  until ch='Y';
end.

