program prg_4_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  ch:char;
begin
  repeat
    writeln(#10#13, '---�������� ����� �� � �� Z---');
    for ch:='A' to 'Z' do
    write(ch, ', ');
    write(#10#13,#10#13,'�������� 5 ��� ������...������ -������ ');
    readln(ch);
  until ch='5';
end.

