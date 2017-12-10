#ifndef STARKINA_UNIT_LAB_5_H_INCLUDED
#define STARKINA_UNIT_LAB_5_H_INCLUDED

#include <fstream>
#include <cstring>

/*directory_elem* search_elem(directory_elem *head, char city_in[20]) //  Функция принимающая адресс и строку
{
    directory_elem *p;                                              // создание указателя на структуру
    p = head;
    if (p!=NULL)                                                       // проверка получения адреса
    {
        do              // выполнять пока указатель не дошел до конца списка
        {
            if ((strcmp(p->city,city_in)==0))       // проверка на существующее название
            {
                return p;                           // вернуть адресс
            }
            p = p->next;                            // назначить указателю следующий элемент
        }
        while (p!=NULL);
        return NULL;
    }
    else
    {
        return p;
    }
}
*/
directory_elem* search_elem(directory_elem *head)
{
    directory_elem *p;
    p = head;
    if (p!=NULL)
    {
        do
        {
            if ((p->index == index_in))
            {
                return p;
            }
            p = p->next;
        }
        while (p!=NULL);
        return NULL;
    }
    else
    {
        return p;
    }
}

/*void print_directoty (directory_elem *head, const char name_file[25] = "\n")
{
    directory_elem *p;
    p = head;
    if (name_file == "\n")
    {
        if (p!=NULL)
        {
            do
            {
                std::cout << "Iндекс - " << p->index << std::endl
                          << "Область - " << p->region << std::endl
                          << "Район - " << p->district << std::endl
                          << "Населений пункт - " << p->city << std::endl
                          << "ВПЗ - " << p->post_office << std::endl
                          << "-------------------------" << std::endl;
                p = p->next;
            }
            while (p!=NULL);
        }
        else
        {
            std::cout << "Довiдник порожнiй." << std::endl;
        }
    }
    else
    {
        std::fstream out_directory;
        out_directory.open(name_file, std::ios::out);
        if (p!=NULL)
        {
            if (out_directory)
            {
                do
                {
                    out_directory << "Iндекс - " << p->index << std::endl
                                  << "Область - " << p->region << std::endl
                                  << "Район - " << p->district << std::endl
                                  << "Населений пункт - " << p->city << std::endl
                                  << "ВПЗ - " << p->post_office << std::endl
                                  << "-------------------------" << std::endl;
                    p = p->next;
                }
                while (p!=NULL);
            }
            else
            {
                std::cout << "Помилка!! Файл не вiдкрився." << std::endl;
            }
        }
        else
        {
            out_directory << "Довiдник порожнiй." <<  std::endl;
        }
        out_directory.close();
    }
}
*/
#endif // STARKINA_UNIT_LAB_5_H_INCLUDED
