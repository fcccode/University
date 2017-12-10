/*
  options.cpp
  вікно параметрів
*/

//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "options.h"
#include "main.h"

#include "ext.h"

//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
Tform_options *form_options;
//---------------------------------------------------------------------------
__fastcall Tform_options::Tform_options(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall Tform_options::FormShow(TObject *Sender)
{
//Встановити елементи керування відповідно переметрам
grid_step->ItemIndex=gridstep/8;
cbShowGrid->Checked=show_grid==1;
cbAlign->Checked=aligning==1;
Edit1->Text=IntToStr(image->Width);
Edit2->Text=IntToStr(image->Height);
}
//---------------------------------------------------------------------------
void __fastcall Tform_options::BitBtn1Click(TObject *Sender)
{
//Модифікувати параметри перед закриттям ОК
modified=1;
switch (grid_step->ItemIndex)
{
case 0:
gridstep=4;gridmask=0xfffc;break;
case 1:
gridstep=8;gridmask=0xfff8;break;
case 2:
gridstep=16;gridmask=0xfff0;break;
}

show_grid=cbShowGrid->Checked;
aligning=cbAlign->Checked;
form_main->sbAlignToGrid->Down=aligning;
form_main->sbShowGrid->Down=show_grid;

if (StrToInt(Edit1->Text)!=image->Width||
    StrToInt(Edit2->Text)!=image->Height)
{
        create_images(StrToInt(Edit1->Text),StrToInt(Edit2->Text));
        image->OnDblClick=form_main->imageDblClick;
        image->OnMouseMove=form_main->Image1MouseMove;
        image->OnMouseDown=form_main->imageMouseDown;
        image->OnMouseUp=form_main->imageMouseUp;
        image->PopupMenu=form_main->PopupMenu1;
        for (int i=0;i<objects->Count;i++)
        {
         CDrawObject *o=(CDrawObject*)objects->Items[i];
         o->canvas=image->Canvas;
        }
        }
        //перемалювати екран
if (show_grid) form_main->Grid1Click(0);
else
image->Canvas->FillRect(TRect(0,0,image->Width,image->Height));
Refresh_Display();
Hide();
}
//---------------------------------------------------------------------------
void __fastcall Tform_options::BitBtn2Click(TObject *Sender)
{
Hide();
}
//---------------------------------------------------------------------------
