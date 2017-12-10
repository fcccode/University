/*
  main.cpp
  реалізація - головна форма, резагування і дані
*/
//---------------------------------------------------------------------------

#include <vcl.h>
#include <stdio.h>
#pragma hdrstop

#include "main.h"
#include "objs.h"
#include "about.h"
#include "options.h"
#include "help.h"

#include "ext.h"
#include "add_multi.h"
#include "line_prop.h"

//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"

Tform_main *form_main;
//---------------------------------------------------------------------------
__fastcall Tform_main::Tform_main(TComponent* Owner)
        : TForm(Owner)
{
objects=new TList;              //ініціалізувати всі значення параметрів
selected=new TList;              //ініціалізувати всі значення параметрів
pictures=new TList;
buffer=new TList;
picture_names=new TList;        //створити списки
add_bitmap=0;                   //режими
add_text=0;
add_line=0;
add_dot=0;
dragging=0;
show_grid=1;                    //опції
aligning=1;

font_size=10;                   //розміри
gridstep=8;
gridmask=0xfff8;
dbl_click=0;

create_images(800,600);

image->OnDblClick=imageDblClick;
image->OnMouseDown=imageMouseDown;
image->OnMouseUp=imageMouseUp;
image->OnMouseMove=Image1MouseMove;
image->PopupMenu=PopupMenu1;


}


//---------------------------------------------------------------------------
void __fastcall Tform_main::FormCloseQuery(TObject *Sender, bool &CanClose)
{
if (new_file()==-1) CanClose=false;
else
clear_buffer();
}


//---------------------------------------------------------------------------
//натискання миші
void __fastcall Tform_main::imageMouseDown(TObject *Sender,
      TMouseButton Button, TShiftState Shift, int X, int Y)
{
int sh=0, al=0;
if (Shift.Contains(ssShift)) sh=1;
if (Shift.Contains(ssAlt)) al=1;
if (Button==mbLeft) mouse_down(X,Y,sh, al);
}


//---------------------------------------------------------------------------
void __fastcall Tform_main::New1Click(TObject *Sender)
{
new_file();
//очистити екран
selected->Clear();
clear_selection();

if (show_grid) Grid1Click(0);
else
image->Canvas->FillRect(TRect(0,0,image->Width,image->Height));

Caption = "Circuit painter";
savedlg->FileName="";
modified=0;
sbSelect->Down=true;
add_text=add_line=add_bitmap=add_dot=0;
}


//---------------------------------------------------------------------------
void __fastcall Tform_main::Quit1Click(TObject *Sender)
{
Close();
}


//---------------------------------------------------------------------------
void __fastcall Tform_main::Help2Click(TObject *Sender)
{
form_help->ShowModal();
}

//---------------------------------------------------------------------------
void __fastcall Tform_main::imageMouseUp(TObject *Sender,
      TMouseButton Button, TShiftState Shift, int X, int Y)
{
int sh=0;
if (Shift.Contains(ssShift)) sh=1;
if (Button==mbLeft) mouse_up(X,Y,sh);
}


//---------------------------------------------------------------------------
void __fastcall Tform_main::About1Click(TObject *Sender)
{
form_about->ShowModal();
}


//---------------------------------------------------------------------------
void __fastcall Tform_main::Options1Click(TObject *Sender)
{
form_options->Show();
}


//---------------------------------------------------------------------------
//ясно...
void __fastcall Tform_main::SaveAs1Click(TObject *Sender)
{
if (!savedlg->Execute()) return;
Save1Click(Sender);
}


//---------------------------------------------------------------------------
void __fastcall Tform_main::menuRefreshClick(TObject *Sender)
{
if (show_grid) Grid1Click(0);
else
image->Canvas->FillRect(TRect(0,0,image->Width,image->Height));
Refresh_Display();
}

//---------------------------------------------------------------------------
//експорт у ВМР
void __fastcall Tform_main::Export1Click(TObject *Sender)
{
if (savepict->Execute())
{
if (show_grid)//експортувати без сітки!!!
{
        image->Canvas->FillRect(TRect(0,0,image->Width,image->Height));
        Refresh_Display();
}
image->Picture->SaveToFile(savepict->FileName);

if (show_grid)
{
        Grid1Click(Sender);
        Refresh_Display();
}
}
}


//---------------------------------------------------------------------------
//малюємо сітку на весь екран
void __fastcall Tform_main::Grid1Click(TObject *Sender)
{
TRect r;
r.Left=0;
r.Top=0;
r.Right=image->Width;
r.Bottom=image->Height;
image->Canvas->CopyRect(r,dot_image->Canvas,r);
}


//---------------------------------------------------------------------------
//ДОДАВАННЯ ОБ"ЄКТІВ (просто встановлюємо режими)
void __fastcall Tform_main::AddText1Click(TObject *Sender)
{
selecting_area=0;
sbText->Down=true;
add_text=add_line=add_bitmap=add_dot=0;
 add_text=1;
 Screen->Cursor=crHandPoint;
}
//---------------------------------------------------------------------------

void __fastcall Tform_main::AddLine1Click(TObject *Sender)
{
sbLine->Down=true;
selecting_area=0;
add_text=add_line=add_bitmap=add_dot=0;
 add_line=1;
 Screen->Cursor=crHandPoint;
}
//---------------------------------------------------------------------------
void __fastcall Tform_main::AddBitmap1Click(TObject *Sender)
{
sbBitmap->Down=true;
add_text=add_line=add_bitmap=add_dot=0;
selecting_area=0;
 add_bitmap=1;
 Screen->Cursor=crHandPoint;
}
//---------------------------------------------------------------------------

void __fastcall Tform_main::AddDot1Click(TObject *Sender)
{
selecting_area=0;
sbDot->Down=true;
add_text=add_line=add_bitmap=add_dot=0;
 add_dot=1;
 Screen->Cursor=crHandPoint;

}


//---------------------------------------------------------------------------
void __fastcall Tform_main::FormCreate(TObject *Sender)
{
//dirs  -       встановити каталоги
Left=0;
Top=0;
Width=Screen->DesktopWidth;
Height=Screen->DesktopHeight;
AnsiString s=ParamStr(0);
s=ExtractFilePath(s);
opendlg->InitialDir=s;
savedlg->InitialDir=s;
savepict->InitialDir=s;
openpict->InitialDir=s+"img";
New1Click(Sender);      //новий створити
}


//-----------------------------------------------------------------------
void __fastcall Tform_main::Open1Click(TObject *Sender)
{
if (!opendlg->Execute()) return;
FILE *f=fopen(opendlg->FileName.c_str(),"r");
if (f==NULL)
{
  MessageBox(Handle,"Loading failed!","Failure",MB_OK+MB_ICONERROR);
  return;
}
load_file(f);
fclose(f);
savedlg->FileName=opendlg->FileName;
Caption="Circuit drawer: "+savedlg->FileName;
Refresh_Display();
}


//---------------------------------------------------------------------------
//процедура запису
void __fastcall Tform_main::Save1Click(TObject *Sender)
{
if (savedlg->FileName=="")
if (!savedlg->Execute()) return;
FILE *f=fopen(savedlg->FileName.c_str(),"w");
if (f==NULL)
 {
  MessageBox(Handle,"Saving failed!","Failure",MB_OK+MB_ICONERROR);
  return;
 }
save_file(f);
fclose(f);
Caption="Circuit drawer: "+savedlg->FileName;
}


//---------------------------------------------------------------------------
//ВИЛУЧИТИ виділений об"єкт
void __fastcall Tform_main::Delete1Click(TObject *Sender)
{
delete_item();
}



void __fastcall Tform_main::sbSelectClick(TObject *Sender)
{
selecting_area=0;
add_text=add_line=add_bitmap=add_dot=0;
Screen->Cursor=crArrow;
sbSelect->Down=true;
}
//---------------------------------------------------------------------------


void __fastcall Tform_main::Image1MouseMove(TObject *Sender,
      TShiftState Shift, int X, int Y)
{
//
mouse_move(X,Y);
}


//---------------------------------------------------------------------------
void __fastcall Tform_main::imageDblClick(TObject *Sender)
{
if (selected->Count==1) last_selected=(CDrawObject*)selected->Items[0];
if (selected->Count==1&&last_selected->type==TTEXT)
{
 //CHANGE TEXT          //зміна напису виділеного тексту
 CTextObject *t=(CTextObject*)last_selected;
 CleanRect(t->x,t->y,t->w,t->h);
 t->text=InputBox("Change text","Enter new text:",t->text);
 t->canvas->Font->Size=t->index;
 t->canvas->Font->Name=t->font_name;
 
 t->w=t->canvas->TextWidth(t->text);
 t->h=t->canvas->TextHeight(t->text);
 modified=1;
 t->Update();
 dbl_click=1;
}
}





void __fastcall Tform_main::ShowHint(TObject *Sender)
{
  StatusBar1->Panels->Items[0]->Text =GetLongHint(Application->Hint);
}
//---------------------------------------------------------------------------

void __fastcall Tform_main::sbAlignToGridClick(TObject *Sender)
{
aligning=sbAlignToGrid->Down;
}
//---------------------------------------------------------------------------

void __fastcall Tform_main::sbShowGridClick(TObject *Sender)
{
show_grid=sbShowGrid->Down;
if (show_grid) form_main->Grid1Click(0);
else
image->Canvas->FillRect(TRect(0,0,image->Width,image->Height));
Refresh_Display();
}
//---------------------------------------------------------------------------


void __fastcall Tform_main::sb0Click(TObject *Sender)
{
TSpeedButton *btn=(TSpeedButton*)Sender;
//Клавіша поворотів картинки на 45 і -45 градусів. Кут - в ТАГ
for (int i=0;i<selected->Count;i++)
{
 //ROTATE BITMAP
 CBitmapObject *t=(CBitmapObject*)selected->Items[i];
 if (t->type!=TBITMAP) continue;
 CleanRect(t->x,t->y,t->w,t->h);
 int cur_angle=t->data;
 cur_angle+=btn->Tag;
 if (cur_angle==-45) cur_angle=315;
 if (cur_angle==360) cur_angle=0;
 t->data=cur_angle;
 modified=1;
 t->Update();
}

}
//---------------------------------------------------------------------------


void __fastcall Tform_main::AddMultiBitmaps1Click(TObject *Sender)
{
form_multi->open_pict1->InitialDir=openpict->InitialDir;
form_multi->ShowModal();
}
//---------------------------------------------------------------------------

void __fastcall Tform_main::SpeedButton1Click(TObject *Sender)
{
AddMultiBitmaps1Click(Sender);
}
//---------------------------------------------------------------------------

void __fastcall Tform_main::sbFontDialogClick(TObject *Sender)
{
if (font_dialog->Execute())
{
font_size=font_dialog->Font->Size;    //новий ШРИФТ
font_name=font_dialog->Font->Name;
font_style=font_dialog->Font->Style;

for (int i=0;i<selected->Count;i++)
{
 //RESIZE TEXT
 CTextObject *t=(CTextObject*)selected->Items[i]; //поміняти шрифт у всіх вибраних
 if (t->type!=TTEXT) continue;                  //текстових об2єктів.
 CleanRect(t->x,t->y,t->w,t->h);

 //effects      // обчислення бітів для виведення ефектів. На якого... всі ці класи?
                // По-людськи, зробили б вони біти, а то шифруй-розшифровуй...
 t->data=0;
 if (font_style.Contains(fsBold)) t->data|=1;
 if (font_style.Contains(fsItalic)) t->data|=2;
 if (font_style.Contains(fsUnderline)) t->data|=4;

 //тепер обновлюємо текст на екрані. перед цим перерахувати розмір
 t->canvas->Font->Style=font_style;
 t->index=font_size;
 t->font_name=font_name;
 t->canvas->Font->Size=t->index;
 t->canvas->Font->Name=font_name;
 t->w=t->canvas->TextWidth(t->text);
 t->h=t->canvas->TextHeight(t->text);
 modified=1;
 t->Update();
}
}

}
//---------------------------------------------------------------------------

void __fastcall Tform_main::sbLinePropClick(TObject *Sender)
{
form_line->ShowModal();
}
//---------------------------------------------------------------------------


void __fastcall Tform_main::Cut1Click(TObject *Sender)
{
cutting=1;
copy();
}
//---------------------------------------------------------------------------

void __fastcall Tform_main::Copy1Click(TObject *Sender)
{
cutting=0;
copy();
}
//---------------------------------------------------------------------------

void __fastcall Tform_main::Paste1Click(TObject *Sender)
{
paste();        
}
//---------------------------------------------------------------------------


void __fastcall Tform_main::sbAreaClick(TObject *Sender)
{
//вибір прямокутника
add_text=add_line=add_bitmap=add_dot=0;
selecting_area=1;      draw_select_area=0;
Screen->Cursor=crCross;
}
//---------------------------------------------------------------------------

