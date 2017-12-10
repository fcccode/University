/*
  objs.h
  заголовок - опис об"єктів на екрані
*/

#ifndef H_OBJS_H
#define H_OBJS_H

#define TLINE 1      //типи об"єктів - лінія, точка, текст і картинка
#define TDOT 2
#define TTEXT 3
#define TBITMAP 4

//Потужна моя система об"єктів


//базовий клас графічного об"єкту
class CDrawObject
{
public:
int x,y,w,h;    //координати і розмір
bool select;    //вибрано
int type;       //тип
int index;      //різноманітна інформація, залежить від типу
int data;       //---------------- // ---------------
TCanvas *canvas;        //канвас на якому зображено об"єкт
CDrawObject(TCanvas *canv);
~CDrawObject(){}
virtual void Update();  //віртуал - метод перемалювання об"єкта, свій для різних
};


//виведена з базового - КАРТИНКА
//в ІНДЕХ - зберігається номер картинки у списку
class CBitmapObject:public CDrawObject
{
public:
int old_data;           //попередній поворот
int pw,ph;              //оригінальні розміри
TPicture *picture;      //зображення
TImage *rot_picture;  //повернуте зображення
AnsiString filename;
                        //конструктор - вказ. координати, картинку і канвас
CBitmapObject(TCanvas *canv, TPicture *pict, int X, int Y);
CBitmapObject(TCanvas *canv):CDrawObject(canv){}
~CBitmapObject();
void Update();          //перевантажена
void operator=(CBitmapObject *src);
};

//виведена з базового - ТЕКСТ
//в ІНДЕХ - зберігається розмір шрифта
class CTextObject:public CDrawObject
{
public:
//індекс - стиль
//дата   - розмір
AnsiString text;        //рядок
AnsiString font_name;   //назва шрифта
CTextObject(TCanvas *canv, AnsiString s, int X, int Y,int size, AnsiString name, TFontStyles style);
CTextObject(TCanvas *canv):CDrawObject(canv){}
~CTextObject(){}
void Update();
void operator=(CTextObject *src);
};


//виведена з базового - ЛІНІЯ
class CLineObject:public CDrawObject
{
//індекс - стиль
//дата - товщина
public:
CLineObject(TCanvas *canv, int x1, int y1, int x2, int y2);
CLineObject(TCanvas *canv):CDrawObject(canv){}
~CLineObject(){}
void Update();
void operator=(CLineObject *src);

};

//виведена з базового - ТОЧКА
class CDotObject:public CDrawObject
{
public:
CDotObject(TCanvas *canv, int xx, int yy);
CDotObject(TCanvas *canv):CDrawObject(canv){}
~CDotObject(){}
void Update();

void operator=(CDotObject *src);
};

#endif
