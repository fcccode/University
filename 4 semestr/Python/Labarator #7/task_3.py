import modules
from pandas import DataFrame
from pylab import *

path_to_file = "D:\\1.txt"

result = modules.read_file(path_to_file)
result = modules.check_punctuation(result)

mark = []
count = []
v = result.values()
k = result.keys()

for i in k:
    mark.append(i)


for i in v:
    count.append(i)

grad = DataFrame({'count': count, 'letter': mark})
plt.figure(figsize=(6, 6))
pos = np.arange(len(count))

plt.title('Задание №3', size =14)
plt.xlabel(' частота появления в тексте', size = 14)
plt.ylabel(' знак пунктуации ', size = 14)
plt.barh(pos, count)

for p, c, ch in zip(pos, mark, count):
    plt.annotate(ch, xy=(ch , p ), va='center')

ticks = plt.yticks(pos , mark)
xt = plt.xticks()[0]
plt.xticks(xt, [' '] * len(xt))

plt.grid(axis ='x', color ='white', linestyle='-')

plt.ylim(pos.max()+.5, pos.min()-1)
plt.xlim(0, 5)
plt.savefig('task_2.png', dpi=200)
plt.show()
