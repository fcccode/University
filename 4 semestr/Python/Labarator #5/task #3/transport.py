class Transport:
    produced_year = 0
    name = ''
    cost = 0
    max_speed = 0
    weight = 0
    coor_x  = 0
    coor_y = 0
    pass_count = 0
    def __init__(self, cost_= 0,prod_ = 0, max_s = 0, weight_ = 0):
        self.cost = cost_
        self.max_speed = max_s
        self.produced_year = prod_
        self.weight = weight_

    def set_coordinate(self,x,y):
        self.coor_x = x
        self.coor_y = y

    def get_coordinate (self):
        return self.coor_x, self.coor_y

    def set_paramet(self,prod_,  max_s, cost_, pas, weight_):
        self.cost = cost_
        self.max_speed = max_s
        self.produced_year = prod_
        self.weight = weight_

    def get_parametr(self):
        lis = [self.produced_year, self.max_speed, self.cost, self.pass_count, self.weight]
        return lis


class Auto(Transport):
    gas_tank =0
    width = 0
    height = 0
    door_count =0
    def __init__(self):
        Transport.__init__(self)

    def display_info(self):
        print("год производства :", self.produced_year)
        print("стоимость        :", self.cost)
        print("Обьем бензобака  :", self.gas_tank)
        print("макс скорость    :", self.max_speed)
        print("текущии коорд.   :", self.coor_x, self.coor_y)
        print("Ширина           :", self.width)
        print("Высота           :", self.height)

    def setter(self, gas, w, h):
        self.gas_tank = gas
        self.width = w
        self.height = h
    def getter (self):
        listi = [self.gas_tank, self.width, self.height]
        l = self.get_parametr()
        listi.append(l)
        return l

class Jet(Transport):
    holder = ''
    max_height =0
    def __init__(self):
        Transport.__init__(self)

    def display_info(self):
        print("владелец         :", self.holder)
        print("год производства :", self.produced_year)
        print("стоимость        :", self.cost)
        print("Макс. высота     :", self.max_height)
        print("макс скорость    :", self.max_speed)
        print("текущии коорд.   :", self.coor_x, self.coor_y)


    def getter(self):
        lis = [self.holder, self.capacity]
        res = self.get_parametr()
        lis.append(res)
        return lis


    def setter(self, hold, max_height_):
        self.holder = hold
        self.max_height = max_height_



class Sheep(Transport):
    holder = ''
    capacity = 0
    def __init__(self):
        Transport.__init__(self)

    def setter(self, hol, cap ):
        self.capacity = cap
        self.holder = hol


    def display_info(self):
        print("владелец         :", self.holder)
        print("год производства :", self.produced_year)
        print("стоимость        :", self.cost)
        print("грузоподьемность :", self.capacity)
        print("макс скорость    :", self.max_speed)
        print("текущии коорд.   :", self.coor_x, self.coor_y)


    def getter(self):
        listt = [self.holder, self.capacity]
        res = self.get_parametr()
        listt.append(res)
        return listt