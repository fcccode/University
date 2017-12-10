//set.h -- Обьявление класа TSet

#ifndef __SET_H
#define __SET_H 1 //Предотвращение нескольких #include

class TElem;
typedef TElem* PTElem;
typedef PTElem* PPTElem;

class TSet;
typedef TSet* PTSet;

class TSet {
private:
 int max;              //Максимальное число элементов
 int index;            //Индекс масива множества
 PPTElem set;          //Указатель на масив
protected:
 virtual int CompareElems(PTElem p1, PTElem p2) = 0;
public:
 TSet(int n)
     {max = n; index = 0; set = new PTElem[n]; }
 virtual ~TSet()
   {delete[] set; }
 void AddElem(PTElem p);
 int HasElem(PTElem p);
};

#endif             //__SET_H