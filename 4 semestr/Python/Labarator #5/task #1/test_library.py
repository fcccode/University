import home_library as lib

object = lib.HomeLibrary()      # create new object library

new_book = lib.Book()           # create new book
new_book.setter("Война и мир", "Л.Н.Толстой ", "Роман", "Мир", 2000)

object.add(new_book)
object.show_all()

new_book = lib.Book()           # create new book
new_book.setter("Робинзон Крузо", "Д.Дефо ", "Приключения", "Мир", 2000)
object.add(new_book)


new_book = lib.Book()           # create new book
new_book.setter("Три Мушкетера", "А.Дюма ", "Роман", "Мир", 2000)
object.add(new_book)


new_book = lib.Book()           # create new book
new_book.setter("Тарзан", "Э.Берроуз ", "Роман", "Мир", 2000)
object.add(new_book)

object.show_all()

result = object.find_book("Три Мушкетера")
print(result)
object.display_book("Тарзан")



