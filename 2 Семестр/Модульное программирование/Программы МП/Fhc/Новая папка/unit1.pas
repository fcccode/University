unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    OK: TButton;
       procedure Button1Click(Sender: TObject);
       procedure Button2Click(Sender: TObject);
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
procedure TForm1.Button1Click(Sender: TObject);
begin
  Per:=StrToInt(Edit1.Text);
  Vt:=StrToInt(Edit2.Text);
  if Vt>Per then
  begin
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
  Label7.Caption:= IntToStr( Raz );
  Label8.Caption:= FloatToStr( a );
  Label9.Caption:= FloatToStr( b);
  Label10.Caption:=FloatToStr( c);

  end
  else
  begin
    Button2.visible:=true;
    Edit1.visible:=false;
    Edit2.visible:=false;
    Label1.visible:=false;
    Label2.visible:=false;
    Label3.visible:=false;
    Label4.visible:=false;
    Label5.visible:=false;
    Label6.visible:=false;
    Label7.visible:=false;
    Label8.visible:=false;
    Label9.visible:=false;
    Label10.visible:=false;
    Button1.visible:=false;
   end;



end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  close;
end;



end.


