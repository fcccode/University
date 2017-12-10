/*
  objs.h
  ��������� - ���� ��"���� �� �����
*/

#ifndef H_OBJS_H
#define H_OBJS_H

#define TLINE 1      //���� ��"���� - ���, �����, ����� � ��������
#define TDOT 2
#define TTEXT 3
#define TBITMAP 4

//������� ��� ������� ��"����


//������� ���� ���������� ��"����
class CDrawObject
{
public:
int x,y,w,h;    //���������� � �����
bool select;    //�������
int type;       //���
int index;      //���������� ����������, �������� �� ����
int data;       //---------------- // ---------------
TCanvas *canvas;        //������ �� ����� ��������� ��"���
CDrawObject(TCanvas *canv);
~CDrawObject(){}
virtual void Update();  //������ - ����� ������������� ��"����, ��� ��� �����
};


//�������� � �������� - ��������
//� ����� - ���������� ����� �������� � ������
class CBitmapObject:public CDrawObject
{
public:
int old_data;           //��������� �������
int pw,ph;              //��������� ������
TPicture *picture;      //����������
TImage *rot_picture;  //��������� ����������
AnsiString filename;
                        //����������� - ����. ����������, �������� � ������
CBitmapObject(TCanvas *canv, TPicture *pict, int X, int Y);
CBitmapObject(TCanvas *canv):CDrawObject(canv){}
~CBitmapObject();
void Update();          //�������������
void operator=(CBitmapObject *src);
};

//�������� � �������� - �����
//� ����� - ���������� ����� ������
class CTextObject:public CDrawObject
{
public:
//������ - �����
//����   - �����
AnsiString text;        //�����
AnsiString font_name;   //����� ������
CTextObject(TCanvas *canv, AnsiString s, int X, int Y,int size, AnsiString name, TFontStyles style);
CTextObject(TCanvas *canv):CDrawObject(canv){}
~CTextObject(){}
void Update();
void operator=(CTextObject *src);
};


//�������� � �������� - ˲Ͳ�
class CLineObject:public CDrawObject
{
//������ - �����
//���� - �������
public:
CLineObject(TCanvas *canv, int x1, int y1, int x2, int y2);
CLineObject(TCanvas *canv):CDrawObject(canv){}
~CLineObject(){}
void Update();
void operator=(CLineObject *src);

};

//�������� � �������� - �����
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
