from math import *
import matplotlib.pyplot as plt

#************************************************************************
user_points = [0.37, 0.58, 0.73, 0.92]
fpar = 5
spar = 10
variant =19
#************************************************************************


#************************************************************************
# Заданая функция
#************************************************************************
def Function(x):
    return sin((20 * x)/(sqrt(variant + 13))) + ((100 * pow(x, 2))/(variant + 37))
#************************************************************************

#************************************************************************
# Расчет коэфициента
#************************************************************************
def BinomialKoefficient(k, n):
    return factorial(n) / (factorial(k) * factorial(n - k))
#************************************************************************

def C(k , n):
    c = 1.0
    z = 1.0
    i = k + 1
    while i<=n:
        c*=i
        i = i + 1
    i =2
    while i<=(n-k):
        z*=i
        i = i + 1
    return c/z

#************************************************************************
# Расчет по Полиному
#************************************************************************
def BernshtanePolinome(x, n):
    value = 0.0

    for k in range(n):
        value += (BinomialKoefficient(k,n) * Function(k / n) * pow(x, k) * pow((1-x), (n - k)))
    return value
#************************************************************************


#************************************************************************
# Задание №1
figure = plt.figure()
ax = figure.add_axes([0, 0, 1, 1])

result1=[]
for i in range(fpar):
    result1.append(BernshtanePolinome(i, fpar))

result2=[] 
for i in range(spar):
    result2.append(BernshtanePolinome(i, spar))

plt.plot(range(spar), result2, color='blue', linewidth=2., label="B" + str(spar)) 
plt.scatter(range(fpar), result1,color='red', label="B" + str(fpar))

plt.grid(True)
plt.legend()
plt.show()
#************************************************************************


#************************************************************************
# Задание №2
print("Погрешность В5 %d = %f" %(fpar,abs(Function(fpar)-BernshtanePolinome(fpar, fpar))))
print("Погрешность В10 %d = %f"%(spar, abs(Function(spar)-BernshtanePolinome(spar, spar))))
#************************************************************************

#************************************************************************
# Задание №3
for i in range(len(user_points)):
    print("Для значения B5 %f = %f" % (user_points[i], BernshtanePolinome(user_points[i],fpar)))
    print("Для значения B10 %f = %f" % (user_points[i], BernshtanePolinome(user_points[i],spar)))
 #************************************************************************                                                                         

