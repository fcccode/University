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
  Writeln('������ ���祭��');
  readln(one_d);
  Write('one_d=', one_d:5:2,' ');
  one_d:=one_d*one_d;
  Writeln('����祭��� ���祭��',' ', one_d:5:2);
  Writeln('������ ���祭��');
  readln(one_d);
  Write('one_d=', one_d:5:2,' ');
  one_d:=one_d*one_d;
  Writeln('����祭��� ���祭��',' ', one_d:5:2);
  readln;
end.

