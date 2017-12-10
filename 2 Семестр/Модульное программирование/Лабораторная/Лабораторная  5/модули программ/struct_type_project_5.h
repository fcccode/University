#ifndef STRUCT_TYPE_PROJECT_5_H_INCLUDED
#define STRUCT_TYPE_PROJECT_5_H_INCLUDED

struct directory_elem
{
unsigned int index;
char region[20] {'\n'};
char district[20]{'\n'} ;
char city[20] {'\n'};
char post_office[20] {'\n'};
directory_elem *next;
}

#endif // STRUCT_TYPE_PROJECT_5_H_INCLUDED
