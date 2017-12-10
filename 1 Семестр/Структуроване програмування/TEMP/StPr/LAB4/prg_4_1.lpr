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
    writeln(#10#13, '---‹€’ˆ‘œŠ ‹’…ˆ ‚„ € „ Z---');
    for ch:='A' to 'Z' do
    write(ch, ', ');
    write(#10#13,#10#13,'€’ˆ‘’œ 5 „‹Ÿ ‚ˆ•„“...ˆ€Š˜… -‚’ ');
    readln(ch);
  until ch='5';
end.

