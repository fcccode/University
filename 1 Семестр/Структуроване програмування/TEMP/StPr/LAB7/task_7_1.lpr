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
    writeln('������ 20 ����ࠫ��� �ᥫ ');
     for i:=1 to 20 do
         begin
              write('x(',i,')=');
              readln(x[i]);
         end;
          Writeln('������� ���� ���ᨢ ��⮨� ��');
          for i:=1 to 20 do
               write('x(',i,')=', x[i]:2,' ');
            Writeln('��� �த������� ������ Enter');
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
                 writeln('� ��������� ���� �᫠�',' ',a,' ����');
                 writeln('� ',y,' ������');
                 Writeln('��� �����襭�� ������ "Y" ��� "N" ��� ����७��');
                 readln(ch);
  until ch='Y';
end.

