program proje_record;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
type
    nameANDyearBirth=record
    sname,name,mname:string[30];
    ybirth:word;
    end;
    snameANDinitials=string[34];
var
    pers:nameANDyearBirth;
    ptr:^snameANDinitials;
begin
  Writeln('Введите Фамилию');
  readln(pers.sname);
  Writeln('Введите Имя');
  readln(pers.name);
  Writeln('Введите Отчество');
  readln(pers.mname);
  Writeln('Введите год рождения');
  readln(pers.ybirth);
  new(ptr);
  ptr^:=pers.sname+' '+pers.name[1]+'.'+pers.mname[1]+'.';
  write(ptr^, ',',pers.ybirth,' г.р.');
  dispose(ptr);
  readln;
end.

