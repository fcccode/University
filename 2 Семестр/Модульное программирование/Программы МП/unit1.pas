             unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Label1: TLabel;
    Label10: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    OK: TButton;
     procedure Button1Click(Sender: TObject);
     procedure FormCreate(Sender: TObject);
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

  If Vt>Per then
  begin
  Raz:= Vt-Per;
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

  Label3.Caption:=  IntToStr( Raz);
  Label4.Caption:=  FloatToStr( a );
  Label5.Caption:=  FloatToStr( b);
  Label6.Caption:=  FloatToStr( c);
 end
  else  begin
    Edit1.Visible:=false;
    Edit2.Visible:=false;
    Label1.Visible:=false;
    Label10.Visible:=false;
    Label2.Visible:=false;
    Label3.Visible:=false;
    Label4.Visible:=false;
    Label5.Visible:=false;
    Label6.Visible:=false;
    Label7.Visible:=false;
    Label8.Visible:=false;
    Label9.Visible:=false;
    OK.Visible:=false;
    Button1.Visible:=True; end;
  end;

end;

procedure TForm1.Button1Click(Sender: TObject);
begin
  close;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin

end;

end.


