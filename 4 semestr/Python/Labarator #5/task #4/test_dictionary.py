import dictionary as d



new_word = d.Word("Hello" )
l = ["Привет", "Здравствуйте"]
new_word.set_translate(l)


new_dictionary = d.Dictionary(new_word)
new_dictionary.show("Hello")

new_word = d.Word("Call" )
l = ["Звонить", "Звать"]
new_word.set_translate(l)
new_dictionary.add(new_word)

new_dictionary.show_dictionary()










