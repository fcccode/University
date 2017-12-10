program task_4_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };

var
  i:integer;
  s,r,k,v,f,t:real;
  ch:char;

begin
repeat
writeln('Введите значения температуры:');
r:=0; k:=0;
for i:=1 to 6 do
    begin
         Write('Введите измерение температуры №',' ',i,' ');
         readln(v);
         writeln('Температура №',' ',i,'=',v:3:2,' Цельсия');
         r:=r+v;
         k:=k+32+9/5*v;
         t:=32+9/5*v;
         writeln('Температура №',' ',i,'=',t:3:2,' Фаренгейт');
    end;
        s:=r/6;
         f:=k/6;
          writeln('Среднее значение температуры','-',s:3:2,' ','Цельсия');
          writeln('Среднее значение температуры','-',f:3:2,' ','Фаренгейт');
          Writeln('Нажмите "q" для выхода с программы');
          readln(ch);
         until ch='q';
end.

