class Word:
    word = ''
    translator = []

    def __init__(self, name):
        self.word = name

    def set_translate(self, lis):
        self.translator = lis

    def set(self, w):
        self.word = w.word
        self.translator.append(w.translator)

    def get(self):
        return self.translator

class Dictionary:
   dictionary = []

   def __init__(self, word):
        self.dictionary.append(word)

   def add(self,w):
       self.dictionary.append(w)

   def find_word(self, w):
       for word in self.dictionary:
           if w  == word :
                return word.translator

   def delete(self, w):
       for word in self.dictionary:
           if w == word:
                self.dictionary.remove(w)

   def show(self, w):
       for word in self.dictionary:
           if w == word.word:
                print(" Слово :", word.word)
                print(" Перевод :", word.translator)


   def show_dictionary(self ):
        for word in self.dictionary:
            print(" Слово :", word.word)
            print(" Перевод :", word.translator)







