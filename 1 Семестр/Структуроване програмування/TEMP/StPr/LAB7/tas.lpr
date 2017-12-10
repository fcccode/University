program tas;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
Type
    ukazat=^s;
    s=record
    Next:integer;
    Inf:ukazat;
    end;
var
    a:^s;
    i:integer;
begin
  new(a);
  a^.Next:= nil;
  a^.Inf:= 3;
writeln(a^.Inf);
dispose(a);
readln;
end.

