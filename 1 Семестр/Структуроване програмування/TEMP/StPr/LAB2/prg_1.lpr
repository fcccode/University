program project_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  a:ShortInt;
  v:Longint;
begin
  write('������ ������� �࠭ �㡠 (m):');
  readln(a);
  v:=a*a*a;
  writeln('��쥬 �㡠:', v, 'm3');
  writeln('����� Enter ��� �����襭��...');
  readln;
end.

