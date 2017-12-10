program task_5_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  r:integer;
  d:string;
procedure slem(a:integer; var b:string);
begin
  if (53<=a) and (a<=54) then
         b:='XS'
     else if (55<=a) and (a<=56) then
                b:='S'
         else if (57<=a) and (a<=58)then
                       b:='M'
              else if (59<=a) and (a<=60) then
                                b:='L'
                   else if (59<=a) and (a<=60) then
                                b:='L'
                       else if (61<=a) and (a<=62) then
                                b:='XL';
end;
procedure Det(c:integer; var b:string);
begin
if (48<=c) and (c<=49) then
         b:='S'
     else if (50<=c) and (c<=51) then
                b:='M'
         else if c=52 then
         b:='L';
end;
begin
Writeln('Введите размер обхвата головы в сантиметрах');
Readln(r);
Writeln('Введенный размер:', r);
if (53>=r) and (r>=62) then
begin
     slem(r,d);
     writeln('Для вас требуется шлем для детей размером:',' ',d ,' ');
end
else
begin
  Det(r,d);
  writeln('Для вас требуется шлем для детей размером:',' ',d,' ');
end;
readln;
end.

