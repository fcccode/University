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
  write('Введть довжину гран куба (m):');
  readln(a);
  v:=a*a*a;
  writeln('Обьем куба:', v, 'm3');
  writeln('Натиснте Enter для завершення...');
  readln;
end.

