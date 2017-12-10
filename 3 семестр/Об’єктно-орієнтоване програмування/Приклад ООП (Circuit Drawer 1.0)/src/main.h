/*
  main.h
  заголовок - головна форма, резагування і дані
*/

//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
#include <Menus.hpp>
#include <Dialogs.hpp>
#include <ExtDlgs.hpp>
#include <ComCtrls.hpp>
#include "objs.h"
#include <Buttons.hpp>
#include <ToolWin.hpp>
#include <AppEvnts.hpp>
//---------------------------------------------------------------------------
class Tform_main : public TForm
{
__published:	// IDE-managed Components
        TMainMenu *MainMenu1;
        TMenuItem *Object1;
        TMenuItem *AddBitmap1;
        TOpenPictureDialog *openpict;
        TMenuItem *File1;
        TMenuItem *New1;
        TMenuItem *Open1;
        TMenuItem *Save1;
        TMenuItem *SaveAs1;
        TMenuItem *Export1;
        TMenuItem *N1;
        TMenuItem *Quit1;
        TStatusBar *StatusBar1;
        TMenuItem *Grid1;
        TMenuItem *AddText1;
        TMenuItem *AddLine1;
        TMenuItem *Delete1;
        TMenuItem *AddDot1;
        TSavePictureDialog *savepict;
        TOpenDialog *opendlg;
        TSaveDialog *savedlg;
        TMenuItem *Tools1;
        TMenuItem *Help1;
        TMenuItem *About1;
        TMenuItem *Help2;
        TMenuItem *Options1;
        TMenuItem *N2;
        TScrollBox *ScrollBox1;
        TMenuItem *menuRefresh;
        TPopupMenu *PopupMenu1;
        TMenuItem *pmSelect1;
        TMenuItem *pmAddBitmap2;
        TMenuItem *pmAddLine2;
        TMenuItem *pmAddText2;
        TMenuItem *pmAddDot2;
        TMenuItem *N3;
        TMenuItem *pmDelete2;
        TMenuItem *Select1;
        TToolBar *ToolBar2;
        TSpeedButton *sbSelect;
        TSpeedButton *sbBitmap;
        TSpeedButton *sbLine;
        TSpeedButton *sbText;
        TSpeedButton *sbDot;
        TToolBar *ToolBar1;
        TSpeedButton *sbNew;
        TSpeedButton *sbOpen;
        TSpeedButton *sbSave;
        TApplicationEvents *ApplicationEvents1;
        TSpeedButton *sbShowGrid;
        TSpeedButton *sbAlignToGrid;
        TSpeedButton *sb0;
        TSpeedButton *sb45;
        TMenuItem *AddMultiBitmaps1;
        TSpeedButton *SpeedButton1;
        TFontDialog *font_dialog;
        TSpeedButton *sbFontDialog;
        TSpeedButton *sbLineProp;
        TMenuItem *N4;
        TMenuItem *Font1;
        TMenuItem *LineProperties1;
        TMenuItem *Rotate45Left1;
        TMenuItem *Rotate45Left2;
        TMenuItem *N5;
        TMenuItem *Cut1;
        TMenuItem *Copy1;
        TMenuItem *Paste1;
        TMenuItem *N6;
        TSpeedButton *sbCut;
        TSpeedButton *sbCopy;
        TSpeedButton *sbPaste;
        TSpeedButton *sbDel;
        TMenuItem *N7;
        TMenuItem *Cut2;
        TMenuItem *Copy2;
        TMenuItem *Paste2;
        TSpeedButton *sbArea;
        //void __fastcall FormPaint(TObject *Sender);
        void __fastcall AddBitmap1Click(TObject *Sender);
        void __fastcall imageMouseDown(TObject *Sender,
          TMouseButton Button, TShiftState Shift, int X, int Y);
        void __fastcall FormCloseQuery(TObject *Sender, bool &CanClose);
        void __fastcall Quit1Click(TObject *Sender);
        void __fastcall Grid1Click(TObject *Sender);
        void __fastcall AddText1Click(TObject *Sender);
        void __fastcall AddLine1Click(TObject *Sender);
        void __fastcall Delete1Click(TObject *Sender);
        void __fastcall AddDot1Click(TObject *Sender);
        void __fastcall New1Click(TObject *Sender);
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall Export1Click(TObject *Sender);
        void __fastcall Save1Click(TObject *Sender);
        void __fastcall SaveAs1Click(TObject *Sender);
        void __fastcall Open1Click(TObject *Sender);
        void __fastcall imageMouseUp(TObject *Sender, TMouseButton Button,
          TShiftState Shift, int X, int Y);
        void __fastcall About1Click(TObject *Sender);
        void __fastcall Options1Click(TObject *Sender);
        void __fastcall imageDblClick(TObject *Sender);
        void __fastcall Help2Click(TObject *Sender);
        void __fastcall menuRefreshClick(TObject *Sender);
        void __fastcall sbSelectClick(TObject *Sender);
        void __fastcall Image1MouseMove(TObject *Sender, TShiftState Shift,
          int X, int Y);
        void __fastcall ShowHint(TObject *Sender);
        void __fastcall sbAlignToGridClick(TObject *Sender);
        void __fastcall sbShowGridClick(TObject *Sender);
        void __fastcall sb0Click(TObject *Sender);
        void __fastcall AddMultiBitmaps1Click(TObject *Sender);
        void __fastcall SpeedButton1Click(TObject *Sender);
        void __fastcall sbFontDialogClick(TObject *Sender);
        void __fastcall sbLinePropClick(TObject *Sender);
        void __fastcall Cut1Click(TObject *Sender);
        void __fastcall Copy1Click(TObject *Sender);
        void __fastcall Paste1Click(TObject *Sender);
        void __fastcall sbAreaClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
        //---------------------------------------------------------------------


        __fastcall Tform_main(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE Tform_main *form_main;
//---------------------------------------------------------------------------
#endif
