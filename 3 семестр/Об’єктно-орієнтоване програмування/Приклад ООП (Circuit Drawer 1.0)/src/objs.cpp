/*
  objs.cpp
  реалізація - опис об"єктів на екрані
*/

#include <vcl.h>

#pragma hdrstop

#include <math.h>
#include "objs.h"
#include "ext.h"


TImage *tmp;


//поворот зображення
void rotate_canvas(int angle, TCanvas *src_canvas,
                float src_w, float src_h,
                TColor back,
                int dx, int dy,
                int& destw, int& desth,
                int sel)
{
//float delta=1;
//transl to radians
double a=3.1415926*angle/180;
//center of the picture
int i,j;
TColor c;
double x,y,xxx,yyy,dest_w,dest_h;
int xx,yy;
double si,co;
si=sin(a);
co=cos(a);

switch (angle)
{
  case 0:
        dest_w=src_w;
        dest_h=src_h;
break;
  case 180:
        dest_w=src_w;
        dest_h=src_h;
        break;
  case 90:
        dest_w=src_h;
        dest_h=src_w;
        break;
  case 270:
        dest_w=src_h;
        dest_h=src_w;
        break;
  case 45:
  case 135:
  case 225:
  case 315:
        //--------------------------------
        if (src_w>src_h)
        {
        dest_w=src_w;
        dest_h=src_w;
        }
        else
        {
        dest_w=src_h;
        dest_h=src_h;
        }
        //--------------------------------
        break;
   default: return;
  }
if (tmp)
        {
         delete tmp;
         tmp=new TImage(0);
         tmp->Width=dest_w;
         tmp->Height=dest_h;
        }
        tmp->Canvas->FillRect(TRect(0,0,dest_w,dest_h));
        destw=dest_w;
        desth=dest_h;
        for (j=0;j<src_h;j++)
          for (i=0;i<src_w;i++)
          {
           c=src_canvas->Pixels[i][j];
           if (c==back) continue;
           xxx=(float)i-src_w/2;
           yyy=(float)j-src_h/2;
           x=xxx*co-yyy*si;
           y=xxx*si+yyy*co;
           x+=dest_w/2+0.5;
           y+=dest_h/2+0.5;
           xx=x;
           yy=y;
           tmp->Canvas->Pixels[xx+dx][yy+dy]=c;
          }
}




//базовий конструктор   -       задати канву і ініціалізувати
CDrawObject::CDrawObject(TCanvas *canv)
{
select=true;
canvas=canv;
index=0;
data=0;
}

//абстрактний порожній метод - не використовується
void CDrawObject::Update(){}//ABSTRACT
//-============================================
//      КАРТИНКА


//Конструктор
CBitmapObject::
CBitmapObject(TCanvas *canv, TPicture *pict, int X, int Y):
CDrawObject(canv)       //виклик базового
{
picture=pict;           //задати картинку і координати
rot_picture=new TImage(0);
x=X;
y=Y;
if (picture){           //визначити ширину і висоту

w=picture->Width;       //розміри
h=picture->Height;
rot_picture->Width=w;
rot_picture->Height=h;

rot_picture->Canvas->CopyRect(TRect(0,0,w,h),picture->Bitmap->Canvas,TRect(0,0,w,h));

} else {w=5; h=5;}
pw=w;
ph=h;
type=TBITMAP;           //тип
old_data=-1;
}

//принцип такий.
/*
  Для картинки використовується аж 3 буфери. 1-й - це зображення таке, яке
  було завантажено з диска. 2-й - це перевернуте зображення. 3 - це видимий
  буфер.
  2-й зроблено для прискорення (кожен раз не перераховується поворот)

*/
void CBitmapObject::Update()
{
if (data!=old_data){
tmp=rot_picture;        //повернути якщо змінився кут
rotate_canvas(data, picture->Bitmap->Canvas,
                pw, ph, clWhite, 0, 0, w, h,(select==true));
                old_data=data;
        rot_picture=tmp;
        }
rot_picture->Transparent=transparent;
canvas->Draw(x,y,rot_picture->Picture->Graphic);
if (select)
{
 canvas->Brush->Color=clBlue;           //рамка для вибору
 canvas->FrameRect(TRect(x,y,x+w,y+h));
 canvas->Brush->Color=clWhite;
}
}


CBitmapObject::~CBitmapObject()
{
 delete rot_picture;
}



void CBitmapObject::operator=(CBitmapObject *src)
{
 
 this->type=TBITMAP;
 this->x=src->x+64;
 this->y=src->y+32;
 this->filename=src->filename;
}




//-============================================
//      ТЕКСТ

CTextObject::
CTextObject(TCanvas *canv, AnsiString s, int X, int Y,int size, AnsiString name, TFontStyles style):
CDrawObject(canv)
{
index=size;                     //встановлення опцій шрифта і координат
canvas->Font->Size=index;
canvas->Font->Style=style;
font_name=name;
canvas->Font->Name=name;

//знову ці стильові класи"№;%:?!!!
data=0;
if(style.Contains(fsBold)) data|=1;
if(style.Contains(fsItalic)) data|=2;
if(style.Contains(fsUnderline)) data|=4;

text=s;
x=X;
y=Y;
w=canvas->TextWidth(s);         //визначити розмір
h=canvas->TextHeight(s);
type=TTEXT;
}

void CTextObject::Update()
{

//і знову ці класи... хто їх придумав?
TFontStyles style;                        //}
TFontStyles s1 =TFontStyles()<<fsBold;     //}
TFontStyles s2 =TFontStyles()<<fsItalic;    //}
TFontStyles s3 =TFontStyles()<<fsUnderline;  //}
                                            //}
if (data&1) style+=s1;                     //}
if (data&2) style+=s2;                  //Ї}
if (data&4) style+=s3;                  //дивіться, скільки місця пропало через
                                        //ці класи стилю!

canvas->Font->Size=index;       //вивести напис
canvas->Font->Name=font_name;
canvas->Font->Style=style;

if (select)
 canvas->Font->Color=clBlue;
 else
 canvas->Font->Color=clBlack;

// canvas->TextFlags+=ETO_OPAQUE;

canvas->TextOutA(x,y,text);
}




void CTextObject::operator=(CTextObject *src){
 this->x=src->x+64;
 this->y=src->y+32;
 this->w=src->w;
 this->h=src->h;
 this->type=TTEXT;
 this->index=src->index;
 this->data=src->data;
 this->text=src->text;
 this->font_name=src->font_name;
}





//-============================================
//      ЛІНІЯ

CLineObject::
CLineObject(TCanvas *canv, int x1, int y1, int x2, int y2):
CDrawObject(canv)
{
x=x1;           //встановити параметри
y=y1;
w=x2;
h=y2;
type=TLINE;
}

void CLineObject::Update()
{
//малюємо синім якщо вибрано, інакше чорним

if (select) canvas->Pen->Color=clBlue;
else canvas->Pen->Color=clBlack;

//вибір типу лінії
switch (index)
{
 case 0: canvas->Pen->Style=psSolid;break;
 case 1: canvas->Pen->Style=psDash;break;
 case 2: canvas->Pen->Style=psDot;break;
 case 3: canvas->Pen->Style=psDashDot;break;
 case 4: canvas->Pen->Style=psDashDotDot;break;
}

canvas->Pen->Width=data;
canvas->MoveTo(x,y);
canvas->LineTo(w,h);

canvas->Pen->Color=clBlack;
}



void CLineObject::operator=(CLineObject *src)
{
 this->x=src->x+64;
 this->y=src->y+32;
 this->w=src->w+64;
 this->h=src->h+32;
 this->type=TLINE;
 this->index=src->index;
 this->data=src->data;
}




//-============================================
//      ТОЧКА

CDotObject::
CDotObject(TCanvas *canv, int xx, int yy):
CDrawObject(canv)
{
x=xx-2; //розмір 4х4
y=yy-2;
w=xx+2;
h=yy+2;
type=TDOT;
}

void CDotObject::Update()
{
//синя якщо вибрана - перемалювання
if (select) canvas->Pen->Color=clBlue;
else canvas->Pen->Color=clBlack;
canvas->Pen->Width=2;
canvas->Ellipse(x,y,w,h);
canvas->Ellipse(x+1,y+1,w-1,h-1);
canvas->Pen->Color=clBlack;
}


void CDotObject::operator=(CDotObject *src)
{
 this->x=src->x+64;
 this->y=src->y+32;
 this->w=src->w+64;
 this->h=src->h+32;
 this->type=TDOT;
 this->index=src->index;
 this->data=src->data;
}

