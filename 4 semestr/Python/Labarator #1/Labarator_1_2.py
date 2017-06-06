print("Программа подсчета факториала числа n: \n\n")

n =input("Введите значение для n: ")
n=int(n)
if n<=0:
    print("Число должно быть больше нуля")
    
else:
    result=1
    i=1
    while i<=n:
        result = result*i
        i=i+1

print("Результат = ", result)
