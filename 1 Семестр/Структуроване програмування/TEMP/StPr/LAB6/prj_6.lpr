program Count_element_array;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
 const
   count_elem=255;
 var
   arr: array[1..count_elem] of cardinal;
   i,count:byte;
begin
     writeln(#201#205#205#205#205#205#205#187#10#13#186,'����',#186#10#13#200#205#205#205#205#205#205#188#10#13);
     write('������', count_elem, '楫�� �ᥫ � ��������� �� 0 �� 4294967295:',#10#13#45#32);
  for i:=1 to count_elem do
       read(arr[i]);
      count:=0;
  for i:=1 to count_elem do
      if (arr[i]>=15000) and (arr[i]<=4000000) then
      count:=count+1;
          if count<>0 then
             writeln(#10#13,'������⢮ �ᥫ, ���祭�� ������ �� 15000 �� 4000000: ', count:3)
          else
              writeln(#10#13, '�।� �������� ���������� �᫠, ���祭�� ������ �� 15000 �� 4000000');
          readln;
          readln;
end.

