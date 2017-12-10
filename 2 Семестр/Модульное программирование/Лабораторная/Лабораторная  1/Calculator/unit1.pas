unit Unit1;
 {$mode objfpc}{$H+}
 interface
 uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,Math,Crt;
type
  { TForm1 }
  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;

    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);

      private
    { private declarations }
  public
    { public declarations }
  end;
const z=['0','1','2','3','4','5','6','7','8','9',',','-'] ;
 var
  Form1: TForm1;
  i,d,re: integer;
  a:string;
  r,x,y,w,h,sum:real;
   implementation
{$R *.lfm}
  { TForm1 }
 procedure filtr (per:string; var r: real );
 begin

   for i:=1 to length(per) do
    if per[i]in z then
       begin
          a:=concat(a,per[i]);
            d:=d+1;
             end
               else
                begin
                  d:=0;
                   break;
                   end;
                  if  d>0 then
                 begin
               r:=StrToFloat(a);
             a:=' ';
           end
         else
       begin
    ShowMessage('Введено не корректное значение');
   re:=0;
 exit;
 end;
 end;

 procedure TForm1.Button2Click(Sender: TObject);
 begin
   close;
 end;

procedure TForm1.Button1Click(Sender: TObject);
begin
re:=1;
  filtr(Edit1.Text, x);
    filtr (Edit2.Text, y);
      filtr (Edit3.Text, w);
       if re=0 then
         exit else
           begin
             if (length(Edit1.Text)=0) and (length(Edit2.Text)=0)and (length(Edit3.Text)=0) then
               begin
                 ShowMessage('Не введено значение');
               exit;
             end else
           begin
          if (x = 0 ) and (y = 0) and (w = 0) then
         begin
       ShowMessage('Деление на ноль');
      exit;
     end else
    if w<=0 then
   begin
  ShowMessage('Z должно принимать значения больше 0');
exit ;
  end else
   h:=(12*x+(sqr(y)-Pi*sqrt(w)));
     if h<=0 then
      begin
        ShowMessage('Подкоренное выражение отрицательное') ;
           exit;
             end
               else
                 begin
               sum:=Power(x,w)-Power(y,3)+sqrt(abs((sqr(w))*(exp(x))))/(12*x+(sqr(y)-Pi*sqrt(w)));
             Edit4.Text:=FloatToStr(sum);
           x:=0; y:=0; w:=0;
        end;
      end;
     end;
end;
end.
