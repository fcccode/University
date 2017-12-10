#include <vcl.h>
#include <stdio.h>
#pragma hdrstop

#include "main.h"
#include "ext.h"



// ==================== ОЧИСТКА БУФЕРА========================
void clear_buffer()
{
 for (int i=0;i<buffer->Count;i++) delete buffer->Items[i];
 buffer->Clear();
}


// ===================== КОПІЮВАННЯ ===========================
void copy()
{
if (selected->Count==0) return;
clear_buffer();
for (int i=0;i<selected->Count;i++)
        {
         CDrawObject *obj=(CDrawObject*)selected->Items[i];
         CLineObject *n_line;
         CDotObject *n_dot;
         CTextObject *n_text;
         CBitmapObject *n_bmp;
        //дублюємо об"єкт
         switch(obj->type)
                {
                 case TLINE:
                 n_line=new CLineObject(obj->canvas);
                 *n_line=(CLineObject*)obj; // "=" це перевантажена операція.
                 buffer->Add(n_line);
                        break;
                 case TDOT:
                 n_dot=new CDotObject(obj->canvas);
                 *n_dot=(CDotObject*)obj;
                 buffer->Add(n_dot);
                        break;
                 case TTEXT:
                 n_text=new CTextObject(obj->canvas);
                 *n_text=(CTextObject*)obj;
                 buffer->Add(n_text);
                        break;
                 case TBITMAP:
                 n_bmp=new CBitmapObject(obj->canvas);
                 *n_bmp=(CBitmapObject*)obj;
                 buffer->Add(n_bmp);
                        break;
                }

        }

//тепер знищити оригінальні об"єкти
if (cutting)
  {
  delete_item();
  cutting=0;
  }

}





void paste()
{
if (buffer->Count==0) return;
clear_selection();
//------------------------- ВСТАВКА------------------

for (int i=0;i<buffer->Count;i++)
        {
         CDrawObject *obj=(CDrawObject*)buffer->Items[i];
         CLineObject *n_line;
         CDotObject *n_dot;
         CTextObject *n_text;
         CBitmapObject *n_bmp;
        //дублюємо об"єкт
         switch(obj->type)
                {
                 case TLINE:
                 n_line=new CLineObject(obj->canvas);
                 *n_line=(CLineObject*)obj; // "=" це перевантажена операція.
                 select_item(n_line);
                 objects->Add(n_line);
                        break;
                 case TDOT:
                 n_dot=new CDotObject(obj->canvas);
                 *n_dot=(CDotObject*)obj;
                 select_item(n_dot);
                 objects->Add(n_dot);
                        break;
                 case TTEXT:
                 n_text=new CTextObject(obj->canvas);
                 *n_text=(CTextObject*)obj;
                 select_item(n_text);
                 objects->Add(n_text);
                        break;
                 case TBITMAP:
                 n_bmp=(CBitmapObject*)obj;
                 AddBitmap(n_bmp->x, n_bmp->y, n_bmp->filename);
                        break;
                }
        }


//------------------------- ВСТАВКА------------------
Refresh_Display();
}

