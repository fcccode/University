#ifndef H_EXT_H
#define H_EXT_H

//#include <vcl.h>
#include <stdio.h>


#include "objs.h"


      //////////////////////////
void create_images(int w, int h);
void load_file(FILE *f);
void save_file(FILE *f);
void mouse_up(int X, int Y, int Shift);
void mouse_down(int X, int Y,int Shift, int Alt);
void mouse_move(int X, int Y);
int new_file();
void  AddBitmap(int X, int Y, AnsiString file_name);
void  AddText(int X, int Y);
void  AddLine(int X, int Y);
void  AddDot(int X, int Y);
void Refresh_Display();
void CleanRect(int X, int Y, int W, int H);
void clear_selection();
void select_item(CDrawObject *obj);
void delete_item();

void copy();
void paste();
void clear_buffer();

void select_area(int x1,int y1, int x2, int y2);

void canon_rect(TRect &r);

        //////////
extern        TImage *image;
extern        TImage *dot_image;
extern        TList *objects;         //������ ��"����
extern        TList *pictures;        //������ �������� (TPicture)
extern        TList *picture_names;   //������ ����� ��������
extern        TList *buffer;          //����� �����  

extern        int add_bitmap;         //������ ���������
extern        int add_text;           //����� ��"����
extern        int add_line;
extern        int add_dot;

extern        int drag_x,drag_y,dragging;     //���� ����������
extern        int delta_dragx,delta_dragy;    //��"���� �����

extern        int line_x,line_y;              //������� �� ��� ������
extern        int prev_line_x,prev_line_y;

extern        TList *selected;          //�������� ��"���
extern        CDrawObject     *last_selected;
extern        int line_dragging;

extern        int line_width;   //��������� ��
extern        int line_style;


extern        int cutting;      //����� ��������

extern        int font_size;         //����� ��������� ������
extern        AnsiString font_name;  //����� ������
extern        TFontStyles font_style;//�����
extern        bool transparent;

        // ----------------- OPTIONS
extern        int show_grid;  //����� ����
extern        int aligning;   //��������� �� ����
extern        int modified;   //������ �����������
extern        int gridstep;   //���� ����  -   8, 16, 4
extern        unsigned gridmask;      //����� ��� ��������� ���� (��� �����������)
extern        int dbl_click;          //������ ��������� ����

extern        TImage    *back_image;    //���-�����
extern int last_mouse_x,last_mouse_y;//������ ���� ��� ������������ ���

extern TList *selected;         //�������� ������
extern CDrawObject     *last_selected;  //������ �������

extern  int selecting_area,draw_select_area;
extern  int select_x1,select_y1, select_x2,select_y2;

#endif