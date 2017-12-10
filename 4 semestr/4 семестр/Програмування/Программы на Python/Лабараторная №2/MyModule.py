#1 quicksort
def quicksort(array):
    """ Быстрая сортировка; """
    if array:
        head, *tail = array
        return quicksort([x for x in tail if x <= head]) + \
               [head] + \
               quicksort([x for x in tail if x > head])
    return []



#2  Search by item's value;
def findByIndex(array, val):
    """
    Поиск элемента по значению;   
    """
    for i in range(len(array)):         # в цикле по всей длине списка 
        if(array[i]==val):              # если нашел значение 
            return "true :", (i+1)      # вернуть подверждение и индекс 
                                        # (i+1) -> i начинается с 0


#3 Search sequence elements;
def findSeqInlist(array, lis):
    ''' Поиск последовательности элементов; '''
    length = len(array)
    count =0
    for i in range(length):
        if (array[i]==lis[0]):
            t =i
            count =0
            for j in range (len(lis)):
                if (array[t]==lis[j]):
                    t = t+1
                    count = count +1
                    if (count == len(lis)):
                        return 'true'
    else:
         return 'false'


#4 Find the minimum of the first five elements;
def findMin(list_):
    """
    Поиск первых пяти минимальных элементов;    
    """
    list_.sort()
    a= [0]*5
    for i in range (5):
        a[i] = min(list_)
        list_.remove(a[i])
    return  a


# 5 Find the maximum of the first five elements;
def findMax(list_):
    """
    Поиск первых пяти максимальных элементов;    
    """
    list_.sort()
    a= [0]*5
    for i in range (5):
        a[i] = max(list_)
        list_.remove(a[i])
    return  a


# 6. Find the arithmetic mean;
def findArithmeticMiddle(list_):
    """
    Поиск среднего арифметического;   
    """
    temp = 0
    length = len(list_)
    for i in range (length):
        temp = temp + list_[i]
    temp = temp/length
    return  temp


# 7_1 The function that takes a list and returns a list of values that are not repeated
def notRepeatList(list_):
    """
    Возвращение списка сформирован из первоначального списка,
    но не содержит повторов     
    """
    temp = set(list_)
    return  temp


# 7_2 The function that takes a list and returns a list of values that are repeated
def RepeatList(list_):
    ''' Функция котороя принимает список
        и возвращает список с значениями которые повторяются
    '''
    num =[]
    for i in range (len(list_)):
         if list_.count(list_[i]) > 1:
           num.append(list_[i])
    temp = set(num)
    return temp



