
class Book:
    name = ''
    authors = ''
    genre = ''
    publishing_house = ''
    publishing_year = 0
    def __init__(self, name_='' , authors_=' ', genre_=' ', house_='', year_=0):
        self.name = name_
        self.authors = authors_
        self.genre = genre_
        self.publishing_house = house_
        self.publishing_year = year_

    def getter(self):
        info = [self.name,self.authors, self.genre, self.publishing_house, self.publishing_year]
        return info
    def setter(self,name_,authors_,genre_, house_, year_):
        self.name = name_
        self.authors = authors_
        self.genre = genre_
        self.publishing_house = house_
        self.publishing_year = year_

class HomeLibrary:
    library_name = ''
    library = []

    def __init__(self, name_=''):
        self.library_name = name_

    def add(self):
        name = input("Введите название книги: ")
        authors = input("Введите автора книги: ")
        genre = input("Введите жанр книги: ")
        house = input("Введите издателя книги: ")
        year = input("Введите год издания книги: ")
        book = Book()
        book.setter(name,authors, genre, house,year)
        self.library.append(book)

    def add(self, book):
        self.library.append(book)

    def delete(self,name_ = '',authors_= '',genre_= '', house_ = '', year_ =0):
        for book in self.library:
            if book.genre == genre_ \
                    or book.name == name_ \
                    or book.publishing_house == house_ \
                    or book.publishing_year == year_:
                    self.library.remove(book)

    def find_book(self,name_ = '',authors_= '',genre_= ' ', house_ = ' ', year_ = 0):
        book_ = []
        iter = 0
        for book in self.library:
            iter += 1
            if book.genre == genre_ \
                    or book.name == name_ \
                    or book.publishing_house == house_ \
                    or book.publishing_year == year_:
                     book_.append(book)
        for i in book_:
            print(" Название книги :", i.name)
            print(" Автор книги :", i.authors)
            print(" Жанр книги :", i.genre)
            print(" Издатель книги :", i.publishing_house)
            print(" Год издания книги :", i.publishing_year)
        return iter

    def display_book(self, name_ = '', authors_= '', genre_= '', house_ = '', year_ =0):
        for book in self.library:
            if book.genre == genre_ \
                    or book.name == name_ \
                    or book.publishing_house == house_ \
                    or book.publishing_year == year_:
                print(" Название книги :", book.name)
                print(" Автор книги :", book.authors)
                print(" Жанр книги :", book.genre)
                print(" Издатель книги :", book.publishing_house)
                print(" Год издания книги :", book.publishing_year)


    def show_all(self):
        for book in self.library:
            print(" \n\n\nНазвание книги :", book.name)
            print(" Автор книги :", book.authors)
            print(" Жанр книги :", book.genre)
            print(" Издатель книги :", book.publishing_house)
            print(" Год издания книги :", book.publishing_year)
