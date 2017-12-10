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
  write(#13#10, 'Будь ласка введть: ',#13#10,'-рк нарождення /РРРР/:');
  readln(birth);
  write('-Мсяць нарождення /ММ/:');
  readln(mon);
  write('-День нарождення /ДД/:');
  readln(day);
  write('-поточний рк /РРРР/: ');
  readln(current);
  if (mon>0) and (mon<=12) and  (day>0) and  (day<=31) and  (birth>1900) then
      begin
           write ('Дякую!',#13#10, 'ви народилися', day:7 );
      case mon of
            1 : write('Счня');
            2 : write('Лютого');
            3 : write('Березня');
            4 : write('Квтня');
            5 : write('Травня');
            6 : write('Червня');
            7 : write('Липня');
            8 : write('Серпня');
            9 : write('Вересня');
            10 : write('Жовтня');
            11 : write('Листопада');
            12 : write('Грудня');
      end;
      writeln(birth, 'p.',#13#10, 'Ваш вк: ',(current-birth):4);
  end
  else
      writeln(#13#10,#13#10,'Помилка! Введена дата нарождення є некорректною. ');
      writeln('натиснть Enter для завершення');
      readln;
end.

