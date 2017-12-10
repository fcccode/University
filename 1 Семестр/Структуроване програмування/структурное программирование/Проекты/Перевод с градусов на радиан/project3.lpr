program project3;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes, SysUtils
  { you can add units after this };
 var
   gradus,minuta:integer; radian:real;
begin
  write('gradus=');
  readln(gradus);
  write('minuta=');
  readln(minuta);
  radian:=gradus*pi/180+pi/180*60;
  writeln('radian=', radian);
end.

