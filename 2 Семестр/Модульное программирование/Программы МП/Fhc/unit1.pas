unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Edit3: TEdit;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    OK: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Label1: TLabel;
      procedure OKClick(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;
  Raz,Per,Vt:integer;
    a,b,c:real;

implementation

{$R *.lfm}

{ TForm1 }
procedure TForm1.OKClick(Sender: TObject);
begin
  Per:=StrToInt(Edit1.Text);
  Vt:=StrToInt(Edit2.Text);
  Raz:=Vt- Per;
           if Raz<150 then
              begin
                    a:=Raz*25.7;
                    b:=Raz*5.14;
                    c:=Raz*30.84;
              end
           else if (Raz>150) and (Raz<800) then
                begin
                    a:=Raz*34.95;
                    b:=Raz*6.99;
                    c:=Raz*41.94;
                 end
           else if Raz>800 then
                 begin
                    a:=Raz*111.7;
                    b:=Raz*22.34;
                    c:=Raz*134.04;
                 end;
  Label4.Caption:= ’ Вдорва’+FloatToStr( a );
  Label5.Caption:= ’ Вдорва’+FloatToStr( b);
  Label6.Caption:= ’ Вдорва’+FloatToStr( c);


end;

end.
