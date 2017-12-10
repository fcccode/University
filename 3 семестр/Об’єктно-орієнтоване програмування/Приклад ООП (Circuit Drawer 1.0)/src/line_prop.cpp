//---------------------------------------------------------------------------
/*

  Форма властивостей лінії

*/

#include <vcl.h>
#pragma hdrstop
#include "ext.h"
#include "line_prop.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
Tform_line *form_line;
//---------------------------------------------------------------------------
__fastcall Tform_line::Tform_line(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall Tform_line::BitBtn2Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------
void __fastcall Tform_line::BitBtn1Click(TObject *Sender)
{
line_width=RadioGroup2->ItemIndex+1;
line_style=RadioGroup1->ItemIndex;

for (int i=0;i<selected->Count;i++)
{
 CLineObject *t=(CLineObject*)selected->Items[i];
 if (t->type!=TLINE) continue;
 CleanRect(t->x,t->y,t->w,t->h);
 t->index=line_style;    //style
 t->data=line_width;     //width
 modified=1;
}
Refresh_Display();

Close();
}
//---------------------------------------------------------------------------
