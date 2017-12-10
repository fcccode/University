//---------------------------------------------------------------------------
/*


  Форма з додаванням кількох об2єктів.
        Коментую мало - все зрозуміло...

*/

#include <vcl.h>
#pragma hdrstop

#include "ext.h"
#include "add_multi.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
Tform_multi *form_multi;
//---------------------------------------------------------------------------
__fastcall Tform_multi::Tform_multi(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall Tform_multi::BitBtn2Click(TObject *Sender)
{
Close();
}
//---------------------------------------------------------------------------
void __fastcall Tform_multi::BitBtn1Click(TObject *Sender)
{
int i,j;
int sx=0,sy=0;


for (j=0;j<UpDown3->Position;j++)       //vertical
{
sx=0;
for (i=0;i<UpDown4->Position;i++)       //horizontal

{
AddBitmap(sx,sy,open_pict1->FileName);
sx+=UpDown1->Position;
}
sy+=UpDown2->Position;

}



Close();
}
//---------------------------------------------------------------------------
void __fastcall Tform_multi::Button1Click(TObject *Sender)
{
if (open_pict1->Execute())
{
 BitBtn1->Enabled=true;
 Image1->Picture->LoadFromFile(open_pict1->FileName);
 Label1->Caption="W= "+IntToStr(Image1->Picture->Width)+
                " H= "+IntToStr(Image1->Picture->Height);
}
}
//---------------------------------------------------------------------------
