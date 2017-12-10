//---------------------------------------------------------------------------

#ifndef add_multiH
#define add_multiH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Buttons.hpp>
#include <ComCtrls.hpp>
#include <Dialogs.hpp>
#include <ExtCtrls.hpp>
#include <ExtDlgs.hpp>
//---------------------------------------------------------------------------
class Tform_multi : public TForm
{
__published:	// IDE-managed Components
        TBitBtn *BitBtn1;
        TBitBtn *BitBtn2;
        TOpenPictureDialog *open_pict1;
        TImage *Image1;
        TLabel *Label1;
        TButton *Button1;
        TBevel *Bevel1;
        TLabel *Label2;
        TLabel *Label3;
        TEdit *Edit1;
        TEdit *Edit2;
        TUpDown *UpDown1;
        TUpDown *UpDown2;
        TEdit *Edit3;
        TEdit *Edit4;
        TUpDown *UpDown3;
        TUpDown *UpDown4;
        TLabel *Label4;
        TLabel *Label5;
        void __fastcall BitBtn2Click(TObject *Sender);
        void __fastcall BitBtn1Click(TObject *Sender);
        void __fastcall Button1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall Tform_multi(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE Tform_multi *form_multi;
//---------------------------------------------------------------------------
#endif
