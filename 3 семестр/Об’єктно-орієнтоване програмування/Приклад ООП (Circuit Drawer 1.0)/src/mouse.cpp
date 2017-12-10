#include <vcl.h>
#include <stdio.h>
#pragma hdrstop

#include <math.h>
#include "main.h"
#include "ext.h"
#include "objs.h"


//
//RETURN 1 if user clicked ON line and
//0 if NOT ON LINE

int check_click_line(int x1, int y1, int x2, int y2,
                        int a, int b)
{

float ab,ac,bc;
ab=sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
ac=sqrt((a-x1)*(a-x1)+(b-y1)*(b-y1));
bc=sqrt((a-x2)*(a-x2)+(b-y2)*(b-y2));
ac+=bc;
if (abs(ab-ac)<=1) return 1;
return 0;

}


//зробити так, щоб справа і внизу було більше ніж зліва вгорі
void canon_rect(TRect &r)
{
long tmp;
if (r.Left>r.Right)
        {
         tmp=r.Left;
         r.Left=r.Right;
         r.Right=tmp;
        }
if (r.Top>r.Bottom)
        {
         tmp=r.Top;
         r.Top=r.Bottom;
         r.Bottom=tmp;
        }
r.Top-=8;
r.Left-=8;
r.Right+=8;
r.Bottom+=8;
}



void mouse_up(int X, int Y, int Shift)
{

 //===================== = ВИДІЛЕННЯ
 if (selecting_area==1&&draw_select_area==1)
 {

        select_area(select_x1,select_y1,select_x2,select_y2);
        form_main->Grid1Click(0);
        Refresh_Display();
        selecting_area=0;
        draw_select_area=0;
        Screen->Cursor=crDefault;
        form_main->sbSelect->Down=true;
        return;
 }

if (dragging){
        int xa,xb,ya,yb;
        X+=delta_dragx;
        Y+=delta_dragy;
        if (aligning)           //вирівняти координати
        {
        xa=(X&gridmask);
        xb=xa+gridstep;
        ya=(Y&gridmask);
        yb=ya+gridstep;
        if ((xb-X)<(X-xa)) X=xb; else X=xa;
        if ((yb-Y)<(Y-ya)) Y=yb; else Y=ya;
        }
        dragging=0;
        Screen->Cursor=crArrow;


        if (selected->Count==1)
        {
        last_selected=(CDrawObject*)selected->Items[0];
        //переміщення лінії
        if (last_selected->type==TLINE)
        {
        if (line_dragging==1)   //переміщення початку лінії
                {
                last_selected->x=X;
                last_selected->y=Y;
                line_dragging=0;
                }
                else
        if (line_dragging==2)   //переміщення кінця лінії
                {
                last_selected->w=X;
                last_selected->h=Y;
                line_dragging=0;
                }
        }
        if (show_grid) form_main->Grid1Click(0);
        else
        image->Canvas->FillRect(TRect(0,0,image->Width,image->Height));
        Refresh_Display();
        }//count==1
}
}


void mouse_down(int X, int Y, int Shift, int Alt)
{
CDrawObject* o;
int i;
int xa,xb,ya,yb,A,B;
A=X;B=Y;
if (dbl_click) {        //не робити нічого, якщо зреаговано на DoubleClick - у
                        //нього свій обробник.
                dbl_click=0;
                return;
                }
modified=1;
if (aligning)   //вирівняти позицію по сітці
{
        xa=(X&gridmask);
        xb=xa+gridstep;
        ya=(Y&gridmask);
        yb=ya+gridstep;
        if ((xb-X)<(X-xa)) X=xb; else X=xa;
        if ((yb-Y)<(Y-ya)) Y=yb; else Y=ya;
}

// ==================== РЕЖИМ ВИБОРУ ПРЯМОКУТНИКА
if (selecting_area==1)
        {
        draw_select_area=1;
        select_x1=X;
        select_y1=Y;
        select_x2=X;
        select_y2=Y;
        return;
        }





//==================== додати об"єкти при вибраному режимі
if (add_bitmap) {
if (!form_main->openpict->Execute()) return;
        clear_selection();
        AddBitmap(X,Y,form_main->openpict->FileName);
        Screen->Cursor=crHandPoint;
        return;
        }     //додати різні об"єкти
if (add_text)   {AddText(X,Y); Screen->Cursor=crHandPoint;return; }
if (add_line!=0) { AddLine(X,Y); Screen->Cursor=crHandPoint;return; }
if (add_dot!=0) { AddDot(X,Y); Screen->Cursor=crHandPoint;return; }


//------- select operations
    if (Alt==0&&Shift==0)                               //якщо вибрано - зняти
        clear_selection();

    for (i=0;i<objects->Count;i++)              //відшукати - може, клацнули
    {//find object                              //на якомусь об"єкті - треба
    o=(CDrawObject*)objects->Items[i];          //його вибрати

    //вибір залежить від типу об"єкта
    //IS A LINE                                 //це лінія
    if ((o->type==TLINE&&check_click_line(o->x,o->y,o->w,o->h,A,B))
    //IS A DOT                                  //це точка
    ||(o->type ==TDOT&&o->x<=X&&o->y<=Y&&o->w>X&&o->h>Y)
    //NOT A LINE                                //це картинка чи текст
    ||((o->type==TBITMAP||o->type==TTEXT)&&o->x<=X&&o->y<=Y&&o->x+o->w>X&&o->y+o->h>Y))

        {//found                                //знайшли об"єкт
        //Якщо об"єкт вже є виділеним, то зняти виділення
        CDrawObject *ooo;
        if (Alt==0)
        for (int q=0; q<selected->Count;q++)
        {
          ooo=(CDrawObject*)selected->Items[q];
          if (ooo==o)
            {
              //found
              o->select=false;
              selected->Delete(q);
              transparent=false;
              o->Update();
              transparent=true;
              o->Update();
              return;
            }
        }

        //====================ВИДІЛИТИ ОБ"ЄКТ===================
        if (Alt==0)
        {
        select_item(o);
        o->Update(); //перемалювати його з рамкою
        last_selected=o;
        }//ALT

        last_mouse_x=X;
        last_mouse_y=Y;

        /// -------------- ОПЕРАЦІЇ НАД ОДНИМ ОБ"ЄКТОМ
        if (selected->Count==1)
        {
        //якщо вибраний текст
        //перетягуємо картинку, точку чи текст
        if (o->type!=TLINE)
        {
        dragging=1;
        Screen->Cursor=crDrag;
        delta_dragx=o->x-X;
        delta_dragy=o->y-Y;
        drag_x=X;
        drag_y=Y;
        line_dragging=0;
        }
        else
        {
         //перетягуємо лінію
         //складність - визначити, чи будемо тягнути початок,
         //чи кінець. вище - це однозначно, тут - треба подумати
         delta_dragx=0;
         delta_dragy=0;
         drag_x=X;
         drag_y=Y;
         //взнати чи знаходимось на початку лінії
         if (X==last_selected->x&&Y==last_selected->y)
           {
             dragging=1;
             line_dragging=1;//LINE_DRAGGING_START
             Screen->Cursor=crDrag;
             line_x=last_selected->w;
             line_y=last_selected->h;
           }
         //взнати чи знаходимось в кінці початку лінії
         if (X==last_selected->w&&Y==last_selected->h)
           {
             dragging=1;
             line_dragging=2;//LINE_DRAGGING_START
             Screen->Cursor=crDrag;
             line_x=last_selected->x;        //це - фіксована точка
             line_y=last_selected->y;
           }
         prev_line_x=X; //це - вільний кінець, який ухопили
         prev_line_y=Y;
        if (line_dragging!=0)
                {
                TRect r;
                r.Left=line_x;
                r.Top=line_y;
                r.Right=prev_line_x;
                r.Bottom=prev_line_y;
                canon_rect(r);
                back_image->Canvas->CopyRect(r,image->Canvas,r);
                }       //запам"ятати екран під лінією
        }//перетягування лінії

        return;
        }//count==1

        else
        //---------- ПЕРЕТЯГУЄМО КІЛЬКА ОБ"ЄКТІВ
        if (Alt)
        {
        dragging=1;
        Screen->Cursor=crMultiDrag;
        delta_dragx=delta_dragy=0;
        }
        }//found
    }

}




void mouse_move(int X, int Y)
{
int cx,cy;
static int pcx=0,pcy=0;
 if (aligning)   //вирівняти позицію по сітці
 {
 int xa,xb,ya,yb;
 xa=(X&gridmask);
 xb=xa+gridstep;
 ya=(Y&gridmask);
 yb=ya+gridstep;
 if ((xb-X)<(X-xa)) cx=xb; else cx=xa;
 if ((yb-Y)<(Y-ya)) cy=yb; else cy=ya;
 if (pcx==cx&&pcy==cy) return;
 pcx=cx;pcy=cy;
 }



 //===================== = ВИДІЛЕННЯ
 if (selecting_area==1&&draw_select_area==1)
        {
        TRect rrr;
        rrr.Left=select_x1;
        rrr.Top=select_y1;
        rrr.Right=select_x2;
        rrr.Bottom=select_y2;
        canon_rect(rrr);

        image->Canvas->CopyRect(rrr,back_image->Canvas,rrr);

         select_x2=cx;
         select_y2=cy;

        rrr.Left=select_x1;
        rrr.Top=select_y1;
        rrr.Right=select_x2;
        rrr.Bottom=select_y2;
        canon_rect(rrr);
        back_image->Canvas->CopyRect(rrr,image->Canvas,rrr);

        image->Canvas->Brush->Color=clRed;
        image->Canvas->FrameRect(rrr);
        image->Canvas->Brush->Color=clWhite;

         return;
        }
 //============================================DRAWING LINE
 if (add_line==2||
 selected->Count==1&&dragging&&last_selected->type==TLINE)
    {
    //restore rectangle line_X, line_Y, prev_line_X,prev_line_Y
    TRect r;
    r.Left=line_x;
    r.Top=line_y;
    r.Right=prev_line_x;
    r.Bottom=prev_line_y;
    canon_rect(r);
    image->Canvas->CopyRect(r,back_image->Canvas,r);
    //save new rectangle prev_line_X=X, prev_line_Y=Y
    prev_line_x=X; prev_line_y=Y;
    r.Left=line_x;
    r.Top=line_y;
    r.Right=prev_line_x;
    r.Bottom=prev_line_y;
    canon_rect(r);
    back_image->Canvas->CopyRect(r,image->Canvas,r);
      if (aligning)
      {
       X=cx;Y=cy;
      }
    image->Canvas->Pen->Color=clBlack;
    image->Canvas->MoveTo(line_x,line_y);
    image->Canvas->LineTo(X,Y);
    return;
    }
    //============================================DRAWING LINE

    //малювання об2єктів при перетягуванні
    if (dragging)
    {
      if (aligning)
      {
       X=cx;Y=cy;
      }
    int delta_x=X-last_mouse_x;
    int delta_y=Y-last_mouse_y;
    last_mouse_x=X;
    last_mouse_y=Y;
        //робимо на весь вибраний список
    CDrawObject *ttt;
    for (int t=0;t<selected->Count;t++)
    {
      ttt=(CDrawObject*)selected->Items[t];
        //delete old picture
        if (ttt->type==TDOT) CleanRect(ttt->x-gridstep+2,ttt->y-gridstep+2,gridstep<<1,gridstep<<1);
        else if (ttt->type==TBITMAP||ttt->type==TTEXT) CleanRect(ttt->x,ttt->y,ttt->w+gridstep,ttt->h);
        else if (ttt->type==TLINE)CleanRect(ttt->x,ttt->y,ttt->w-ttt->x,ttt->h-ttt->y);
          switch (ttt->type)
          {
            case TLINE:
            case TDOT:
                ttt->x+=delta_x;
                ttt->y+=delta_y;
                ttt->w+=delta_x;
                ttt->h+=delta_y;
                break;
            case TTEXT:
            case TBITMAP:
                ttt->x+=delta_x;
                ttt->y+=delta_y;
                break;
           }//sw
        ttt->Update();
        }//loop

//     MessageBeep(0);
    }

}
