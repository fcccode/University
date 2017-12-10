//---------------------------------------------------------------------------

#ifndef line_propH
#define line_propH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <Buttons.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class Tform_line : public TForm
{
__published:	// IDE-managed Components
        TBitBtn *BitBtn1;
        TBitBtn *BitBtn2;
        TRadioGroup *RadioGroup1;
        TRadioGroup *RadioGroup2;
        void __fastcall BitBtn2Click(TObject *Sender);
        void __fastcall BitBtn1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall Tform_line(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE Tform_line *form_line;
//---------------------------------------------------------------------------
#endif
