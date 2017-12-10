print("Лабараторная работа № 1_3\n")
print("Введите параметры  матрицы\n")
x = input("Введите количество строк :")
y = input("Введите количество столбцов :")

x = int(x)
y = int(y)

matrix=[[0]*y for i in range(x)]

for i in range (x):
    for j in range (y):
        print("Введите значения",i+1,j+1)
        matrix[i][j]=int(input())



array = [0]* x
for i in range(x):
    for j in range (y):
        array[i] = array[i] + matrix[i][j]
        
   
for i in range (len(array)):
    print("Элемент № ", i+1 ," = ", array[i])



