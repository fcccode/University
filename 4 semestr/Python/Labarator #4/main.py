import functions

print("Лабараторная работа №4")
print("Определить, какие слова чаще всего встречаются "
      "\(перед или после\) слова указанном пользователем")

word = str(input("Введите слово : "))
path_file = r'D:\Repositor\University\4 семестр\Python\Labarator #4\test_text.txt'

data_from_file = functions.read(path_file)
prev, next_ = functions.check_text(data_from_file, word)

prev = functions.statistics(prev)
next_ = functions.statistics(next_)

result_prev = functions.most_often_found(prev)
result_next = functions.most_often_found(next_)

print("result about word which prev : " , result_prev )
print("result about word which next : " , result_next )

