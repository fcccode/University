"""
Y(x)=5*sin(10*x)*sin(3*x)/(x^(1/2)), x=[1...7]
"""
import math
import numpy as np
import matplotlib.pyplot as plt

x = np.linspace(1, 7, 100)
y = []
for i in x:
     y.append(5*(math.sin(10*i))*(math.sin(3*i)/(i**(1/2))))
plt.figure(num=1, figsize=(8,6))
plt.title('Задание №1', size =14)
plt.xlabel('ось x', size = 14)
plt.ylabel('ось y', size = 14)
plt.plot(x, y, color='b', linestyle = '--',marker='o', label='значение x')
plt.legend(loc='upper right')
plt.savefig('task_1.png', format='png')
plt.show()

