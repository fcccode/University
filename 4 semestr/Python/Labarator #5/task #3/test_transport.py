import transport

auto = transport.Auto()
jet = transport.Jet()
sheep = transport.Sheep()


auto.set_coordinate(25,20)
auto.setter(75, 3, 2)
auto.set_paramet(2015,200,12000,4,2000)
res = auto.getter()
auto.display_info()
print(res)

jet.set_coordinate(25,20)
jet.setter("Firm.corp", 12000)
jet.set_paramet(2015,200,12000,4,2000)
res = auto.getter()
jet.display_info()
print(res)

sheep.set_coordinate(25,20)
sheep.setter("Hold.comp", 50000)
sheep.set_paramet(2015,200,12000,4,2000)
res = auto.getter()
sheep.display_info()
print(res)


