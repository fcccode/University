import sys
import  math
# Лабараторная работа № 1
# Задание № 1
# Ст. гр. КИ-15 Аннаев А.К.

def task_1(a, b):
    # отображение полученных аргументов
    print("Вхідні дані:" + ' ' + str(a) + ' ' + str(b));
    # расчет по форму Задания -1
    W = (math.sqrt((a*b))/((math.pow(math.e, a))*b) + a *(math.pow(math.e,((2*a)/b))));
    return W;

"""
2)Вхідні дані: 3 дійсних числа -- аргументи командного рядка.
"""
def task_2(x,y,z):
    # отображение полученных аргументов
    print("Вхідні дані:" + ' ' + str(x) + ' ' + str(y) + ' ' + str(z));
    # для читабельности формула разделена на две части
    first_part  = ( 1 / (z *(math.sqrt (2 * math.pi ) )));
    second_part = ( math.exp (- (pow((x - y),2))/(2*pow(z,2))));

    return first_part * second_part;

"""
3)Вхідні дані: 3 числа x, y та z. x, y -- невід'ємні цілі числа, z дорівнює 0 або 1. x не дорівнює 0. 
Передаються як аргументи командного рядка.
"""
def task_3(x,y,z):
    # отображение полученных аргументов
    print("Вхідні дані:" + ' ' + str(x) + ' ' + str(y) + ' ' + str(z));
    # определение и инициализация значений
    song        = "Everybody sing a song: ";
    first_arg   = None;
    second_arg  = '';
    result      = None;

    # проверка первого аргумента (количество "la")
    if x > 1:
        first_arg = "la-" * ( x - 1);
        first_arg =  first_arg + "la ";
    else:
        first_arg = "la ";

    # проверка второго аргумента (количество "la-la" повторений)
    if y > 0:
        second_arg = first_arg * y;
    else:
        second_arg = ' ';

    # отсчет идет с нуля
    index = len(second_arg) - 1;
    # проверка третьего аргумента (количество завершение куплета )
    if z == 1:
        result = second_arg[:index] + "!";
    else:
        result = second_arg[:index] + ".";
    return song + result;


# Начало алгоритма
arg_count = len(sys.argv) - 1;      # определение количества аргументов не учитывая имени файла
result    = None;                   # результат выполнения алгоритма

if arg_count == 2:                  # если введены два аргумента значит у нас первое задание
    a = float(sys.argv[1]);         # получение первого аргумента
    b = float(sys.argv[2]);         # получение второго аргумента

    if a >= 0 and b > 0:            # проверка по условию задания
        result = task_1(a,b);
    else:
        print("Некоррекные входные данные");
elif arg_count == 3:                # если введены три аргумента значит второе или третье задание
    x = float(sys.argv[1]);
    y = float(sys.argv[2]);
    z = float(sys.argv[3]);

    # проверка по условию задания 2 и задания 3
    if x >= 0 and y >= 0 and (z == 0 or z == 1):
        result = task_3(int(x),int(y),int(z));
    else:
        result = task_2(x,y,z);

# Вывод результатов обработки
print("Результат : " + str(result));



