program task_4_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };

var
  i:integer;
  s,r,k,v,f,t:real;
  ch:char;

begin
repeat
writeln('������ ���祭�� ⥬�������:');
r:=0; k:=0;
for i:=1 to 6 do
    begin
         Write('������ ����७�� ⥬������� �',' ',i,' ');
         readln(v);
         writeln('��������� �',' ',i,'=',v:3:2,' ������');
         r:=r+v;
         k:=k+32+9/5*v;
         t:=32+9/5*v;
         writeln('��������� �',' ',i,'=',t:3:2,' ��७����');
    end;
        s:=r/6;
         f:=k/6;
          writeln('�।��� ���祭�� ⥬�������','-',s:3:2,' ','������');
          writeln('�।��� ���祭�� ⥬�������','-',f:3:2,' ','��७����');
          Writeln('������ "q" ��� ��室� � �ணࠬ��');
          readln(ch);
         until ch='q';
end.

