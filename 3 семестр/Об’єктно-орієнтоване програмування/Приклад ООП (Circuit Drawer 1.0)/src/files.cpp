#include <vcl.h>
#include <stdio.h>
#pragma hdrstop

#include "main.h"
#include "ext.h"

void load_file(FILE *f)
{

int i;
int pic_count;
int str_count=0;
int obj_count;
int type,x,y,w,h,index,data;
char s[80];
AnsiString *string;
TFontStyles style;

        //���̲�� ��������
        fscanf(f,"%d ",&x);
        fscanf(f,"%d ",&y);

        //create new image
        create_images(x,y);

        image->OnDblClick=form_main->imageDblClick;
        image->OnMouseDown=form_main->imageMouseDown;
        image->OnMouseUp=form_main->imageMouseUp;
        image->OnMouseMove=form_main->Image1MouseMove;
        image->PopupMenu=form_main->PopupMenu1;

        fscanf(f,"%d ",&show_grid);                     //����������� ��������� � �����
        fscanf(f,"%d ",&aligning);
        form_main->sbAlignToGrid->Down=(aligning!=0);
        form_main->sbShowGrid->Down=(show_grid!=0);
        fscanf(f,"%d ",&gridstep);
        fscanf(f,"%d ",&gridmask);

        form_main->New1Click(0);                              //�������

        //����� ��������
        fscanf(f,"%d\n",&pic_count);                    //��������

        ///������������ ���� ��������
        for (i=0;i<pic_count;i++)
        {
        fgets(s,75,f);
        *(s+strlen(s)-1)=0;
        string=new AnsiString(s);                       //����� ��������
        picture_names->Add(string);
        }

        //������������ ����� ��������
        AnsiString *pname;                              //����������� ��� ��������
        TPicture *newp;
        for (i=0;i<pic_count;i++)
        {
        pname=(AnsiString*)picture_names->Items[i];
        newp=new TPicture;
        try{
        newp->LoadFromFile(*pname);
        }
        catch(...)
                {
                //������� ��� ����������� ����� �������� - ��������� ������, ��������
                //�� ������ � ����� � ���������
                //LOADING ERROR
                MessageBox(form_main->Handle,pname->c_str(),"Error loading file",MB_OK+MB_ICONERROR);
                //ABORT AND CLEAR ALL
                form_main->New1Click(0);
                return;
                }
        pictures->Add(newp);
        }

//----------------------------------������������ ������ ��2��Ҳ�

        fscanf(f,"%d",&obj_count);      //����������� ��������� ��"����

        for (i=0;i<obj_count;i++)
        {
          fscanf(f,"%d ",&type);
          fscanf(f,"%d ",&x);
          fscanf(f,"%d ",&y);
          fscanf(f,"%d ",&w);
          fscanf(f,"%d ",&h);
          fscanf(f,"%d ",&index);
          fscanf(f,"%d ",&data);

          //������ ��"��� � ������, ������ - ���� �������������
          if (type==TTEXT)
                {
                CTextObject *tmp1=new CTextObject(image->Canvas,"",x,y,index,font_name,font_style);
                tmp1->data=data;
                objects->Add(tmp1);
                }
          if (type==TDOT) objects->Add(new CDotObject(image->Canvas,x+2,y+2));
          if (type==TLINE)
           {
           CLineObject *tmp2=new CLineObject(image->Canvas,x,y,w,h);
           tmp2->data=data;
           tmp2->index=index;
           objects->Add(tmp2);
           }
          if (type==TBITMAP)
          {
          CBitmapObject *bm=new CBitmapObject(image->Canvas,NULL,x,y);
          bm->index=index;
          bm->data=data;
          objects->Add(bm);
          }
        }
//----------------------------------������������ ������ ��2��Ҳ�

//----------------------------------����������� �����
        CTextObject *t;
        fscanf(f,"%d\n",&str_count);            //����� �������������
        for (i=0;i<objects->Count;i++)
        {
          t=(CTextObject*)objects->Items[i];
          if (t->type==TTEXT)
          {
          fgets(s,75,f);
          *(s+strlen(s)-1)=0;                   //�����
          t->text=s;

          fgets(s,75,f);                        //� ����� - �����
          *(s+strlen(s)-1)=0;
          t->font_name=s;

        TFontStyles s1 =TFontStyles()<<fsBold;  //��������ު�� ������������ �����
        TFontStyles s2 =TFontStyles()<<fsItalic;
        TFontStyles s3 =TFontStyles()<<fsUnderline;

        if (t->data&1) style+=s1;
        if (t->data&2) style+=s2;
        if (t->data&4) style+=s3;
        t->canvas->Font->Style=style;

        t->canvas->Font->Size=t->index;         //�����Ͳ ���̲��
        t->canvas->Font->Name=t->font_name;
        t->w=t->canvas->TextWidth(t->text);
        t->h=t->canvas->TextHeight(t->text);
        }
        }
//---------------------------------------����������� �����


//===============================================================
        //last call - make picture pointers in bitmaps
        CBitmapObject *bmp;                     //���������� ��������� ��� ��������
                                                //� ��"����� ������������ ���������
        for (i=0;i<objects->Count;i++)
        {

          bmp=(CBitmapObject*)objects->Items[i];
          if (bmp->type==TBITMAP)
          {
          bmp->picture=(TPicture*)pictures->Items[bmp->index];
          bmp->pw=bmp->picture->Width;
          bmp->ph=bmp->picture->Height;
          bmp->w=bmp->picture->Width;
          bmp->h=bmp->picture->Height;
          bmp->filename=*(AnsiString*)picture_names->Items[bmp->index];
        //2-� ����� ��� �������� - ���� �� 0 �������
        if (bmp->rot_picture) delete bmp->rot_picture;
        bmp->rot_picture=new TImage(0);
        bmp->rot_picture->Width=bmp->w;
        bmp->rot_picture->Height=bmp->h;
        bmp->rot_picture->Canvas->CopyRect(TRect(0,0,w,h),bmp->picture->Bitmap->Canvas,TRect(0,0,w,h));
        }
        }
//===============================================================

        //clear selections
       CDrawObject *obb;
       for (i=0;i<objects->Count;i++)
        {
        obb=(CDrawObject*)objects->Items[i];
        obb->select=false;
        }
        selected->Clear();
}


void save_file(FILE *f)
{
AnsiString s;
int i;

//save options                                  //����� ����������� � ����
fprintf(f,"%d ",image->Width);                  //0 - ����� ����
fprintf(f,"%d ",image->Height);

fprintf(f,"%d ",show_grid);                     //1 - ����� ����
fprintf(f,"%d ",aligning);                      //2 - �����������
fprintf(f,"%d ",gridstep);                      //3 - ���� ����
fprintf(f,"%d ",gridmask);                      //4 - �����
//save filenames
fprintf(f,"%d\n",picture_names->Count);         //5 - ������� ���������
for (i=0;i<picture_names->Count;i++)
{
  s=*(AnsiString*)picture_names->Items[i];
  s=ExtractFileName(s);
  s="img\\"+s;
  fputs(s.c_str(),f);                           //6 - ����� ��� ��������
  fprintf(f,"\n");
}

//save objects
CDrawObject *obj;
fprintf(f,"%d ",objects->Count);                //7 - ������� ��"����
for (i=0;i<objects->Count;i++)
{
  obj=(CDrawObject*)objects->Items[i];
  fprintf(f,"%d ",obj->type);                   //8 - ����� ������� ��"����
  fprintf(f,"%d ",obj->x);                      //��������� ��� ���
  fprintf(f,"%d ",obj->y);
  fprintf(f,"%d ",obj->w);
  fprintf(f,"%d ",obj->h);
  fprintf(f,"%d ",obj->index);
  fprintf(f,"%d ",obj->data);
}
//save text strings
int str_count=0;
for (i=0;i<objects->Count;i++)
{
  obj=(CDrawObject*)objects->Items[i];          //��������� ����� � �������
  if (obj->type==TTEXT) str_count++;
}
///text count
CTextObject *t;
fprintf(f,"%d\n",str_count);                    //9 - ������� �����
for (i=0;i<objects->Count;i++)
{
  t=(CTextObject*)objects->Items[i];
  if (t->type==TTEXT)
  {
  fputs(t->text.c_str(),f);                     //10 - ����� ��������� �����
  fprintf(f,"\n");
  fputs(t->font_name.c_str(),f);                     //10 - ����� ��������� �����
  fprintf(f,"\n");
  }
}
modified=0;
}


int new_file()
{
int i;
//if not saved
//����� �� ����������
if (modified)
{
i=MessageBox(form_main->Handle,"Do you want to save your work?","Alert",MB_YESNOCANCEL+MB_ICONQUESTION);
if (i==IDCANCEL) return -1;
if (i==IDYES) form_main->Save1Click(0);
}
//�������� ����� ��������
//create new
//��� ��������

for (i=0;i<objects->Count;i++) delete objects->Items[i];
objects->Clear();
for (i=0;i<picture_names->Count;i++) delete picture_names->Items[i];
picture_names->Clear();
for (i=0;i<pictures->Count;i++)
 {
 TPicture *p=(TPicture*)pictures->Items[i];
 delete p;
 }
pictures->Clear();
//can_paste=0;
Screen->Cursor=crArrow;
selecting_area=0;
return 0;
}