//---------------------------------------------------------------------------

#ifndef helpH
#define helpH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class Tform_help : public TForm
{
__published:	// IDE-managed Components
        TMemo *Memo1;
private:	// User declarations
public:		// User declarations
        __fastcall Tform_help(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE Tform_help *form_help;
//---------------------------------------------------------------------------
#endif
