#ifndef STARKINA_UNIT_LAB_5_H_INCLUDED
#define STARKINA_UNIT_LAB_5_H_INCLUDED

#include <fstream>
#include <cstring>

/*directory_elem* search_elem(directory_elem *head, char city_in[20]) //  ������� ����������� ������ � ������
{
    directory_elem *p;                                              // �������� ��������� �� ���������
    p = head;
    if (p!=NULL)                                                       // �������� ��������� ������
    {
        do              // ��������� ���� ��������� �� ����� �� ����� ������
        {
            if ((strcmp(p->city,city_in)==0))       // �������� �� ������������ ��������
            {
                return p;                           // ������� ������
            }
            p = p->next;                            // ��������� ��������� ��������� �������
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
                std::cout << "I����� - " << p->index << std::endl
                          << "������� - " << p->region << std::endl
                          << "����� - " << p->district << std::endl
                          << "��������� ����� - " << p->city << std::endl
                          << "��� - " << p->post_office << std::endl
                          << "-------------------------" << std::endl;
                p = p->next;
            }
            while (p!=NULL);
        }
        else
        {
            std::cout << "���i���� ������i�." << std::endl;
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
                    out_directory << "I����� - " << p->index << std::endl
                                  << "������� - " << p->region << std::endl
                                  << "����� - " << p->district << std::endl
                                  << "��������� ����� - " << p->city << std::endl
                                  << "��� - " << p->post_office << std::endl
                                  << "-------------------------" << std::endl;
                    p = p->next;
                }
                while (p!=NULL);
            }
            else
            {
                std::cout << "�������!! ���� �� �i�������." << std::endl;
            }
        }
        else
        {
            out_directory << "���i���� ������i�." <<  std::endl;
        }
        out_directory.close();
    }
}
*/
#endif // STARKINA_UNIT_LAB_5_H_INCLUDED
