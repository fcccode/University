#include <vcl.h>
#include <stdio.h>
#pragma hdrstop

#include "main.h"
#include "ext.h"


//-------------- DATA ----------------------------------------

        TImage *image;          //екран
        TImage *dot_image;      //точки - сітка
        TList *objects;         //список об"єктів
        TList *pictures;        //список картинок (TPicture)
        TList *picture_names;   //список файлів картинок

        int add_bitmap;         //режими додавання
        int add_text;           //різних об"єктів
        int add_line;
        int add_dot;

        int drag_x,drag_y,dragging;     //стан переміщення
        int delta_dragx,delta_dragy;    //об"єктів мишою

        int line_x,line_y;              //початок лінії при доданні
        int prev_line_x,prev_line_y;
        int line_dragging=0;
        int line_width=1;               //параметри лінії
        int line_style;

        int        font_size;                  //розмір поточного шр.
        AnsiString font_name="MS Sans Serif";  //назва шрифта
        TFontStyles font_style;

        bool transparent=true;

        // ----------------- OPTIONS
        int show_grid;  //видно сітку
        int aligning;   //розміщення по сітці
        int modified;   //прапор модифікації
        int gridstep;   //крок сітки  -   8, 16, 4
        unsigned gridmask;      //маска для координат миші (для вирівнювання)
        int dbl_click;          //ознака подвійного кліка

        TImage          *back_image;
        // ----------------- OPTIONS
        int last_mouse_x,last_mouse_y;

        TList *selected;
        CDrawObject     *last_selected;


        TList * buffer;
        int cutting=0;

        int selecting_area=0,draw_select_area=0;   //режим вибору прямокутника
        int select_x1,select_y1, select_x2,select_y2;
                                //координати вибору



        //---------------------------------------------------------------------


        //створити нові компоненти при зміні розміру зображення з опцій
void create_images(int w, int h)
{
if (image) delete image;
image=new TImage(0);
image->Width=w;
image->Height=h;
image->Parent=form_main->ScrollBox1;

if (back_image) delete back_image;
back_image =new  TImage(0);
back_image->Width=w;
back_image->Height=h;
back_image->Parent=form_main;

if (dot_image) delete dot_image;
dot_image =new  TImage(0);
dot_image->Width=w;
dot_image->Height=h;
dot_image->Parent=form_main;

int i,j;
dot_image->Canvas->Pen->Color=clBlack;
for (i=0;i<image->Width;i+=gridstep)
for (j=0;j<image->Height;j+=gridstep)
{
dot_image->Canvas->MoveTo(i,j);
dot_image->Canvas->LineTo(i+1,j+1);
}

}


//додавання лінії
void  AddLine(int X, int Y)
{
 if (add_line==1)       //перший клік
 {
 add_line=2;
 prev_line_x=X; prev_line_y=Y;
 line_x=X;
 line_y=Y;

 }
 else                   //другий клік
 {
 CLineObject *l=new CLineObject(image->Canvas,line_x,line_y,X,Y);
 l->Update();

  //select it
  clear_selection();
  select_item(l);

 objects->Add(l);
 add_line=1;
 }
}


//додати текст
void  AddText(int X, int Y)
{
form_main->StatusBar1->Panels->Items[0]->Text="Ready.";
AnsiString s="";
s=InputBox("New Text","Enter text:",s);
if (s=="") return;
CTextObject *t=new CTextObject(image->Canvas,s,X,Y,font_size, font_name, font_style);

//select it
clear_selection();
select_item(t);

objects->Add(t);
t->Update();
}


//додати картинку
void  AddBitmap(int X, int Y, AnsiString file_name)
{
int i;
AnsiString *s;
TPicture *p;
CBitmapObject *cbm;
for (i=0;i<pictures->Count;i++) //відшукати, чи не завантажувалась ця картинка раніше
{
 s=(AnsiString*)picture_names->Items[i];
 if (*s==file_name)
 {
  //FOUND       //знайдено - зробити на неїї посилання і додати
  p=(TPicture*)pictures->Items[i];
  cbm=new CBitmapObject(image->Canvas,p,X,Y);
  cbm->index=i;
  cbm->filename=file_name;
  cbm->data=0;

  //select it
  select_item(cbm);

  objects->Add(cbm);
  cbm->Update();
  return;
 }
}
  //NOT FOUND   //не знайдено - завантажуємо з файла і додаємо в список картинок
  s=new AnsiString;
  *s=file_name;
  picture_names->Add(s);
  p=new TPicture;
  p->LoadFromFile(*s);
  cbm=new CBitmapObject(image->Canvas,p,X,Y);
  cbm->index=pictures->Count;
  cbm->filename=file_name;
  cbm->data=0;
  pictures->Add(p);

  //select it
  select_item(cbm);

  objects->Add(cbm);
  cbm->Update();
  return;
}

//додавання точки
void  AddDot(int X, int Y)
{
form_main->StatusBar1->Panels->Items[0]->Text="Ready.";
CDotObject *d=new CDotObject(image->Canvas,X,Y);

//select it
clear_selection();
select_item(d);

d->Update();
//objects->Add(d);
objects->Insert(0,d);

}



//---------------------------------------------------------------------------
//Перемалювання об"єктів на екрані
void Refresh_Display()
{
CDrawObject *tmp;
for (int i=0;i<objects->Count;i++)
{
tmp=(CDrawObject*)objects->Items[i];
tmp->Update();          //віртуальний метод - ось де сила!!!
}
}


//намалювати прямокутник і заповнити його сіткою (фон)
void CleanRect(int X, int Y, int W, int H)
{
if (!aligning)           //вирівняти координати
{
  int xa,ya,xb,yb;
  xa=(X&gridmask);
  xb=xa+gridstep;
  ya=(Y&gridmask);
  yb=ya+gridstep;
  if ((xb-X)<(X-xa)) X=xb; else X=xa;
  if ((yb-Y)<(Y-ya)) Y=yb; else Y=ya;
  xa=(W&gridmask);
  xb=xa+gridstep;
  ya=(H&gridmask);
  yb=ya+gridstep;
  if ((xb-W)<(W-xa)) W=xb; else W=xa;
  if ((yb-H)<(H-ya)) H=yb; else H=ya;
}

int i,j;

int x1,y1,x2,y2,tmp;
x1=X;y1=Y;
x2=X+W;y2=Y+H;

if (x1>x2) {tmp=x1; x1=x2; x2=tmp;}
if (y1>y2) {tmp=y1; y1=y2; y2=tmp;}
x1-=8;x2+=8;y1-=8;y2+=8;

//квадрат
image->Canvas->FillRect(TRect(x1,y1,x2,y2));
image->Canvas->Pen->Width=1;
image->Canvas->Pen->Color=clBlack;

if (show_grid)//сітка
for (i=x1;i<x2;i+=gridstep)
for (j=y1;j<y2;j+=gridstep)
{
  image->Canvas->MoveTo(i,j);
  image->Canvas->LineTo(i+1,j+1);
}


//x1,y1,x2,y2
//image->Canvas->Rectangle(TRect(x1,y1,x2,y2));
//при перетягуванні обновити елементи які поряд
for (i=0;i<objects->Count;i++)
{
CDrawObject *obj=(CDrawObject*)objects->Items[i];
int draww=0,a1,b1,a2,b2;

switch (obj->type)
        {
         case TTEXT:
         case TBITMAP:
/*         if ( (obj->x>=x1&&obj->y>=y1&&obj->x<=x2&&obj->y<=y2) ||
            ( (obj->w+obj->x) >=x1 && (obj->h+obj->y) >=y1 && (obj->w+obj->x) <=x2 && (obj->h+obj->y) <=y2) ||
            ( (obj->w) >=x1 && (obj->h+obj->y) >=y1 && (obj->w) <=x2 && (obj->h+obj->y) <=y2) ||
            ( (obj->w+obj->x) >=x1 && (obj->h+obj->y) >=y1 && (obj->w+obj->x) <=x2 && (obj->h+obj->y) <=y2) ||
            )*/
            a1=obj->x;
            b1=obj->y;
            a2=obj->x+obj->w;
            b2=obj->y+obj->h;

            if (a1>=x1 && b1>=y1 && a1<=x2 && b1<=y2) draww=1;
            if (a2>=x1 && b2>=y1 && a2<=x2 && b2<=y2) draww=1;
            if (a2>=x1 && b1>=y1 && a2<=x2 && b1<=y2) draww=1;
            if (a1>=x1 && b2>=y1 && a1<=x2 && b2<=y2) draww=1;

         break;

         case TLINE:
                draww=1;
         break;

         case TDOT:
                draww=1;
         break;
        }

if (draww)
for (j=0;j<selected->Count;j++)
        {
         CDrawObject *obj1=(CDrawObject*)selected->Items[j];
         if (obj1==obj) draww=0;
        }

  if (draww)  obj->Update();

//  if (draww&&(obj->type==TBITMAP||obj->type==TTEXT)) MessageBeep(0);


  }//оновлення
}

