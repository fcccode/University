//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
USERES("drawer.res");
USEFORM("main.cpp", form_main);
USEUNIT("objs.cpp");
USEFORM("about.cpp", form_about);
USEFORM("options.cpp", form_options);
USEFORM("help.cpp", form_help);
USEUNIT("kernel.cpp");
USEUNIT("files.cpp");
USEUNIT("mouse.cpp");
USEUNIT("select.cpp");
USEFORM("add_multi.cpp", form_multi);
USEFORM("line_prop.cpp", form_line);
USEUNIT("buffer.cpp");
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
        try
        {
                 Application->Initialize();
                 Application->Title = "Circuit Drawer";
                 Application->CreateForm(__classid(Tform_main), &form_main);
                 Application->CreateForm(__classid(Tform_multi), &form_multi);
                 Application->CreateForm(__classid(Tform_about), &form_about);
                 Application->CreateForm(__classid(Tform_options), &form_options);
                 Application->CreateForm(__classid(Tform_help), &form_help);
                 Application->CreateForm(__classid(Tform_line), &form_line);
                 Application->Run();
        }
        catch (Exception &exception)
        {
                 Application->ShowException(&exception);
        }
        return 0;
}
//---------------------------------------------------------------------------
