program task_3_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
 const
  a=5;
  b=7;
  c=9;
  d=12;
  e=15;
  f=20;
  t=25;
 var
  o,s,v:real;
begin
  writeln('������ ����� �㬬�');
  readln(v);
  if (0<v) and (v<100) then
     begin
       s:=v*a/100;
       o:=v-s;
       writeln('�� ������ �㬬� �� ����砥�',' ',a,' ','��業⮢ ᪨���');
       writeln('�� ������ ������� �㬬�',' ',o:3:2,' ','��.');
     end
  else
  if (100<v) and (v<200) then
     begin
       s:=v*b/100;
       o:=v-s;
       writeln('�� ������ �㬬� �� ����砥�',' ',b,' ','��業⮢ ᪨���');
       writeln('�� ������ ������� �㬬�',' ' ,   o:3:2,' ','��.');
     end
  else
        if (200<v) and (v<300) then
     begin
       s:=v*c/100;
       o:=v-s;
       writeln('�� ������ �㬬� �� ����砥�',' ',c,' ','��業⮢ ᪨���');
       writeln('�� ������ ������� �㬬�',' ',o:3:2,' ','��.');
     end
  else    if (300<v) and (v<400) then
     begin
       s:=v*d/100;
       o:=v-s;
       writeln('�� ������ �㬬� �� ����砥�',' ',d,' ','��業⮢ ᪨���');
       writeln('�� ������ ������� �㬬�',' ',o:3:2,' ','��.');
     end
  else    if (400<v) and (v<500) then
     begin
       s:=v*e/100;
       o:=v-s;
       writeln('�� ������ �㬬� �� ����砥�',' ',e,' ','��業⮢ ᪨���');
       writeln('�� ������ ������� �㬬�',' ',o:3:2,' ','��.');
     end
  else    if (500<v) and (v<1000) then
     begin
       s:=v*f/100;
       o:=v-s;
       writeln('�� ������ �㬬� �� ����砥�',' ',f,' ','��業⮢ ᪨���');
       writeln('�� ������ ������� �㬬�',' ',o:3:2,' ','��.');
     end
  else  if 1000<v then
     begin
       s:=v*t/100;
       o:=v-s;
       writeln('�� ������ �㬬� �� ����砥�',' ',t,' ','��業⮢ ᪨���');
       writeln('�� ������ ������� �㬬�',' ',o:3:2,' ','��.');
     end
  else;
  readln;

end.

