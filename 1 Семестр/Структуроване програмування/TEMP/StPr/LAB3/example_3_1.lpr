program birth_and_age;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
var
  birth, current:word;//
  mon, day:byte;
begin
  write(#13#10, '��� ��᪠ ������: ',#13#10,'-� ��஦����� /����/:');
  readln(birth);
  write('-����� ��஦����� /��/:');
  readln(mon);
  write('-���� ��஦����� /��/:');
  readln(day);
  write('-���筨� � /����/: ');
  readln(current);
  if (mon>0) and (mon<=12) and  (day>0) and  (day<=31) and  (birth>1900) then
      begin
           write ('����!',#13#10, '�� ��த�����', day:7 );
      case mon of
            1 : write('���');
            2 : write('��⮣�');
            3 : write('��१��');
            4 : write('����');
            5 : write('�ࠢ��');
            6 : write('��ࢭ�');
            7 : write('�����');
            8 : write('��௭�');
            9 : write('�����');
            10 : write('�����');
            11 : write('���⮯���');
            12 : write('��㤭�');
      end;
      writeln(birth, 'p.',#13#10, '��� ��: ',(current-birth):4);
  end
  else
      writeln(#13#10,#13#10,'�������! ������� ��� ��஦����� � �����४⭮�. ');
      writeln('������ Enter ��� �����襭��');
      readln;
end.

