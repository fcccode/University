from random import shuffle, choice
class Card:
    name = ''
    number = -1
    def __init__(self, n, num):
        self.name = n
        self.number = num

    def get_info(self,):
        lists = [self.name, self.number]
        return lists

    def set_info(n, num):
        self.name = n
        self.number = num

    def display(self):
        print(" Масть       :", self.name)
        print(" Номер карты :", self.number)

class Coloda:
    card_count = 36
    mast = ["Бубен", "Сердце", "Треф", "Пики"]
    kart = ["Шесть", "Семь", "Восемь", "Девять", "Десять","Валет", "Дама","Король","Туз"]
    coloda = []
    def __init__(self):
        for i in self.mast:
            for j in self.kart:
                new_card = Card(j,i)
                self.coloda.append(new_card)
        shuffle(self.coloda)

    def mix_coloda(self):
        shuffle(self.coloda)

    def show_card(self):
        card = choice(self.coloda)
        print(card.name, "-", card.number, ":", )

    def show_six(self):
        list_ = []
        for card in range(6):
            list_.append(choice(self.coloda))
        for card in list_:
            print(card.name, "-", card.number, ":", )


    def show_all(self):
        for card in self.coloda:
            print( card.name, "-" , card.number, ":",)


