program task_3_1;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}{$IFDEF UseCThreads}
  cthreads,
  {$ENDIF}{$ENDIF}
  Classes
  { you can add units after this };
 const
  a=5;
  b=7;
  c=9;
  d=12;
  e=15;
  f=20;
  t=25;
 var
  o,s,v:real;
begin
  writeln('Введите общую сумму');
  readln(v);
  if (0<v) and (v<100) then
     begin
       s:=v*a/100;
       o:=v-s;
       writeln('на данную сумму вы получаете',' ',a,' ','процентов скидки');
       writeln('вы должны оплатить сумму',' ',o:3:2,' ','гр.');
     end
  else
  if (100<v) and (v<200) then
     begin
       s:=v*b/100;
       o:=v-s;
       writeln('на данную сумму вы получаете',' ',b,' ','процентов скидки');
       writeln('вы должны оплатить сумму',' ' ,   o:3:2,' ','гр.');
     end
  else
        if (200<v) and (v<300) then
     begin
       s:=v*c/100;
       o:=v-s;
       writeln('на данную сумму вы получаете',' ',c,' ','процентов скидки');
       writeln('вы должны оплатить сумму',' ',o:3:2,' ','гр.');
     end
  else    if (300<v) and (v<400) then
     begin
       s:=v*d/100;
       o:=v-s;
       writeln('на данную сумму вы получаете',' ',d,' ','процентов скидки');
       writeln('вы должны оплатить сумму',' ',o:3:2,' ','гр.');
     end
  else    if (400<v) and (v<500) then
     begin
       s:=v*e/100;
       o:=v-s;
       writeln('на данную сумму вы получаете',' ',e,' ','процентов скидки');
       writeln('вы должны оплатить сумму',' ',o:3:2,' ','гр.');
     end
  else    if (500<v) and (v<1000) then
     begin
       s:=v*f/100;
       o:=v-s;
       writeln('на данную сумму вы получаете',' ',f,' ','процентов скидки');
       writeln('вы должны оплатить сумму',' ',o:3:2,' ','гр.');
     end
  else  if 1000<v then
     begin
       s:=v*t/100;
       o:=v-s;
       writeln('на данную сумму вы получаете',' ',t,' ','процентов скидки');
       writeln('вы должны оплатить сумму',' ',o:3:2,' ','гр.');
     end
  else;
  readln;

end.

