import function  

print ("Лабараторная работа №3")



path = 'G:\\4 семестр\\Програмування\\Программы на Python\\Лабараторная №3\\'
filename = 'file.txt'


print("\n\nФункция № 1\n")
print("Считывание текста с файла")      
l = function.read(path, filename)
print ("Результат считывания с файла " , l)

print("\n\nФункция № 2\n")
print("Запись текста в файла")
ls ="Hello"
l = function.write(path, filename, ls)
print ("Результат записи в файла выполнился " , l)


print("\n\nФункция № 3\n")
print("Добавить запись в файла")
ls ="Hello"
l = function.writeAppend(path, filename, ls)
print ("Результат записи в файла выполнился " , l)


print("\n\nФункция № 4\n")
print("Поиск файла в каталоге")
l = function.findFileInCatalog(path, filename)
print ("Результат поиска " , l)


print("\n\nФункция № 5\n")
print("Сортировка списка по оценке")
l= {}
l = function.sort(path, 'dic.txt')
print ("Результат сортировки " , l)


print("\n\nФункция № 6\n")
print("Поиск данных в файле")
l = function.findDataInFile(path, 'dic.txt', 'Aka')
print ("Результат поиска данных " , l)









