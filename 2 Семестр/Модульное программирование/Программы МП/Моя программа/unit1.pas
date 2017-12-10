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
    Label11: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;
  a,b,c,Per, Vt, Raz:real;

implementation

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
begin
      Per:=StrToFloat(Edit1.Text);
      Vt:=StrToFloat(Edit2.Text);
      If Vt>Per then
      begin
      Raz:=Vt-Per;
      if Raz<150 then
           begin
           a:=Raz*25.4;
           b:=Raz*5.1;
           c:=Raz*30.5;
           end
      else if (Raz>150)and (Raz<800) then
           begin
           a:=Raz*35.2;
           b:=Raz*7.1;
           c:=Raz*42.3;
           end
      else if Raz>800 then
           begin
           a:=Raz*51.2;
           b:=Raz*9.1;
           c:=Raz*60.3;
           end;

Label7.Caption:=FloatToStr(Raz);
Label8.Caption:=FloatToStr(a);
Label9.Caption:=FloatToStr(b);
Label10.Caption:=FloatToStr(c);

      end
else begin
Button1.visible:=False;
    Button2.visible:=True;
    Edit1.visible:=False;
    Edit2.visible:=False;
    Label1.visible:=False;
    Label2.visible:=False;
    Label3.visible:=False;
    Label4.visible:=False;
    Label5.visible:=False;
    Label6.visible:=False;
    Label7.visible:=False;
    Label8.visible:=False;
    Label9.visible:=False;
    Label10.visible:=False;
    Label11.visible:=True;
end;
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  close;
end;

end.

