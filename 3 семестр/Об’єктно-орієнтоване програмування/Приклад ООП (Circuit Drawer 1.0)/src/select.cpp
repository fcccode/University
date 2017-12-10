/*

  операції вибору об2єктів
*/


#include <vcl.h>
#include <stdio.h>
#pragma hdrstop

#include "ext.h"


//вибрати щось
void select_item(CDrawObject *obj)
{
  obj->select=true;
  selected->Add(obj);
}


//зняти вибірку
void clear_selection()
{
        CDrawObject *obj;
        for (int i=0;i<selected->Count;i++)
        {
         obj=(CDrawObject*)selected->Items[i];
         obj->select=false;
        }
        selected->Clear();

        transparent=false;
        Refresh_Display();
        transparent=true;
        Refresh_Display();
}


//знищити виділене
void delete_item(){

CDrawObject *sel;
for (int j=0;j<selected->Count;j++)
{
        sel=(CDrawObject*)selected->Items[j];
         //clear area
        if (sel->type==TDOT)  CleanRect(sel->x-gridstep+2,sel->y-gridstep+2,gridstep<<1,gridstep<<1);
        else if (sel->type==TLINE) CleanRect(sel->x,sel->y,sel->w-sel->x,sel->h-sel->y);
        else  CleanRect(sel->x,sel->y,sel->w,sel->h);

        CDrawObject *to_del;
        for (int i=0;i<objects->Count;i++)
        {
         to_del=(CDrawObject*)objects->Items[i];
         if (to_del==sel) { objects->Delete(i); break; }
        }

        delete sel;
}
        Refresh_Display();
        selected->Clear();
}


void select_area(int x1,int y1, int x2, int y2)
{
        TRect rrr;
        rrr.Left=select_x1;
        rrr.Top=select_y1;
        rrr.Right=select_x2;
        rrr.Bottom=select_y2;
        canon_rect(rrr);
        clear_selection();
        for (int i=0;i<objects->Count;i++)
        {
        CDrawObject *obj=(CDrawObject*)objects->Items[i];

        switch (obj->type)
                {
                  case TDOT:
                        if (rrr.Left<=obj->x && rrr.Top<=obj->y &&
                            rrr.Right>=obj->w && rrr.Bottom>=obj->h)
                                select_item(obj);
                  break;
                  case TTEXT:
                  case TBITMAP:
                        if (rrr.Left<=obj->x && rrr.Top<=obj->y &&
                            rrr.Right>=obj->w+obj->x && rrr.Bottom>=obj->h+obj->y)
                                select_item(obj);
                  break;
                  case TLINE:
                        if (rrr.Left<=obj->x && rrr.Top<=obj->y &&
                            rrr.Right>=obj->x && rrr.Bottom>=obj->y &&
                            rrr.Left<=obj->w && rrr.Top<=obj->h &&
                            rrr.Right>=obj->w && rrr.Bottom>=obj->h )
                                select_item(obj);

                  break;
                }
        }//loop
}

