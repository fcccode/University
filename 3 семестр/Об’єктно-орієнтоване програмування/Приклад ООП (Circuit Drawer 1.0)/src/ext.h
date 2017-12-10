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
extern        TList *objects;         //список об"єктів
extern        TList *pictures;        //список картинок (TPicture)
extern        TList *picture_names;   //список файлів картинок
extern        TList *buffer;          //буфер обміну  

extern        int add_bitmap;         //режими додавання
extern        int add_text;           //різних об"єктів
extern        int add_line;
extern        int add_dot;

extern        int drag_x,drag_y,dragging;     //стан переміщення
extern        int delta_dragx,delta_dragy;    //об"єктів мишою

extern        int line_x,line_y;              //початок лінії при доданні
extern        int prev_line_x,prev_line_y;

extern        TList *selected;          //вибраний об"єкт
extern        CDrawObject     *last_selected;
extern        int line_dragging;

extern        int line_width;   //параметри лінії
extern        int line_style;


extern        int cutting;      //режим вирізання

extern        int font_size;         //розмір поточного шрифта
extern        AnsiString font_name;  //назва шрифта
extern        TFontStyles font_style;//стиль
extern        bool transparent;

        // ----------------- OPTIONS
extern        int show_grid;  //видно сітку
extern        int aligning;   //розміщення по сітці
extern        int modified;   //прапор модифікації
extern        int gridstep;   //крок сітки  -   8, 16, 4
extern        unsigned gridmask;      //маска для координат миші (для вирівнювання)
extern        int dbl_click;          //ознака подвійного кліка

extern        TImage    *back_image;    //бак-буфер
extern int last_mouse_x,last_mouse_y;//курсор миші при перетягуванні ліній

extern TList *selected;         //вибраний список
extern CDrawObject     *last_selected;  //останнє вибрано

extern  int selecting_area,draw_select_area;
extern  int select_x1,select_y1, select_x2,select_y2;

#endif