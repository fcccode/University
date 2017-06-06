import string as s

string = "шалаш"

obj = s.String(string)
repeat = obj.is_have_repeat("ал")
palindrom = obj.is_polindrom()


print("String have repeat substring :", repeat)
print("String is a palindrom", palindrom)





