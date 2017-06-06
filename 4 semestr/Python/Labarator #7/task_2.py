import modules
from pandas import DataFrame
from pylab import *

path_to_file = "D:\\1.txt"

result = modules.read_file(path_to_file)
result = modules.analysis(result)

letter = []
count = []
v = result.values()
k = result.keys()

for i in k:
    letter.append(i)

for i in v:
    count.append(i)

grad = DataFrame({'count': count, 'letter': letter})
plt.figure(figsize=(8, 8))
pos = np.arange(len(count))

plt.title('Задание №2', size =14)
plt.xlabel(' количество букв в тексте', size = 14)
plt.ylabel(' буква ', size = 14)
plt.barh(pos, count)

for p, c, ch in zip(pos, letter, count):
    plt.annotate(ch, xy=(ch , p ), va='center')

ticks = plt.yticks(pos , letter)
xt = plt.xticks()[0]
plt.xticks(xt, [' '] * len(xt))

plt.grid(axis ='x', color ='white', linestyle='-')

plt.ylim(pos.max(), pos.min() - 1)
plt.xlim(0, 10)
plt.savefig('task_2.png', dpi=200)
plt.show()
