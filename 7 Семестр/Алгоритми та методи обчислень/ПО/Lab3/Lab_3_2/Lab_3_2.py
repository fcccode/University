from math import *
from functools import reduce
from operator import mul

#********************************************************************************************
#Задание №2 
def LagrangeFunction(list_x, list_y, value):

    lenx = len(list_x)
    leny = len(list_y)
    
    if lenx != leny and lenx < 2:
        return -1

    temp = (value - list_x[0]) / (list_x[1] - list_x[0])
    koefficient = (reduce(mul, [temp - i for i in range(lenx)]))

    total = 0
    for i in range(lenx):
        result = (pow(-1, lenx-1 - i) * factorial(i) * factorial(lenx-1 - i))
        total += list_y[i] / ((temp - i) * result)

    return koefficient * total
#********************************************************************************************

#********************************************************************************************
# Вариан выполнения
variant_x = [1.375, 1.380, 1.385, 1.390, 1.395, 1.400]
variant_y= [5.04192, 5.17744, 5.32016, 5.47069, 5.62968, 5.79788]
variant_value = 1.3934
#********************************************************************************************

#********************************************************************************************
# Образец выполнения
example_x = [0.101, 0.106, 0.111, 0.116, 0.121, 0.126]
example_y = [1.26183, 1.27644, 1.29122, 1.30617, 1.32130, 1.32660]
example_value = 0.1157
#********************************************************************************************

#********************************************************************************************
# Вызов функций
print("Запуск образца результат %f" % (LagrangeFunction(example_x, example_y, example_value)))
print("Запуск варианта результат %f" % (LagrangeFunction(variant_x, variant_y, variant_value)))
#********************************************************************************************


