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
  Writeln('������ ���祭��:');
  Write('��饥 ������⢮ ��� �����ਥ�⮢ � ⥪�饬 ����:',' ');
  readln(o);
  Write('������⢮ �����ਥ�⮢ ����饭��� �� �������:',' ');
  readln(k);
  Write('���᫥��� �� ��᧠����:');
  readln(g);
   n:=o-k-g;
   m:=n*100/o;
   t:=g*100/o;
    f:=k*100/o;
  writeln(m:2:1,' ',' ','��業⮢ �� ��饣� ������⢠ ���, �� ����饭�� �� ������� ');
  writeln(t:2:1,' ','��業⮢ �� ��饣� ������⢠ ���, ���᫥�� �� ��᧠����');
  writeln(f:2:1,' ''��業⮢ �� ��饣� ������⢠ ���, ���᫥��� �� ����ࠪ��');
  readln;
end.

