unit Unit1;

{$mode objfpc}{$H+}
interface
uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,DateUtils,Crt;
type
 upper= set of '€'..'Ÿ';
 low = set of ' '..'ï';
  { TForm1 }
    TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Edit1: TEdit;
    Memo1: TMemo;
    Memo2: TMemo;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;
const
big:upper=['€'..'Ÿ'];
  sm:low =[' '..'ï'];
var
  Form1: TForm1;
  k,i,h: integer;
  g:string;
  a,b,c,d,x:real;
implementation
{$R *.lfm}
{ TForm1 }
procedure TForm1.Button1Click(Sender: TObject);
begin
if Edit1.Text<> ' ' then
begin
   Memo1.Clear;
g:=UTF8ToAnsi(Edit1.Text);
    k:=length(g);
        for i:=1 to k do
            if ('A'<Edit1.Text[i])or(Edit1.Text[i]<'Z') or ('a'<Edit1.Text[i])or(Edit1.Text[i]<'z')  then
                if ('€'<Edit1.Text[i])or(Edit1.Text[i]<'Ÿ') or (' '<Edit1.Text[i])or(Edit1.Text[i]<'ï')  then
                   begin
                      if Pos(Edit1.Text,Memo2.Text)<>0 then
                          begin
                             Memo1.Lines[0]:= 'Yes';
                      Memo1.Lines[1]:= 'Entered word is in verse';
                   end
                else
             begin
          Memo1.Lines.Add(DateTimeToStr(date));
      Memo1.Lines[1]:= 'Entered Incorrect value';
    break;
end;
end;
end
else
    ShowMessage('Please enter your request ');
end;


procedure TForm1.Button2Click(Sender: TObject);
begin
if Edit1.Text<> ' ' then
begin
Memo1.Clear;
a:=0;
    b:=0;
 c:=0;
    d:=0;
 x:=0;
 h:=2;
        for i:=1 to length(Edit1.Text) do
          if ('A'<Edit1.Text[i] ) and ( Edit1.Text[i]<'Z')  then
              a:=a+1
                   else
                        if ('a'<Edit1.Text[i]) and ( Edit1.Text[i]<'z') then
                             b:=b+1
                                 else
                                    if Edit1.Text[i] in big then
                                        c:=c+1
                                            else
                                        if Edit1.Text[i] in sm then
                                    d:=d+1
                                  else
                              begin
                         ShowMessage('Error! Incorrect value');
                      break;
                   h:=0;
                end ;
           if h>0 then
          begin
             x:=a+b+c/2+d/2;
                Memo1.Lines[0]:=FloatToStr(x);
           end
        end
else
    ShowMessage('Please enter your request ');
end;
end.


