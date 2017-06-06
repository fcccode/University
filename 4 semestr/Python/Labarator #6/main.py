import module


print("\tЛабараторная работа №6")
print("\tПарсинг вебстаниц\n")

URL = 'http://itnews.com.ua/'

result = module.count_href_on_website(URL)
print("Количество ссылок на странице", result)


result = module.count_image_on_website(URL)
print("Количество изображений на странице", result)

result = module.parse_html(URL)
dictionary = module.counting(result)
print(dictionary)

take_all_text = module.take_text(URL)
for i in take_all_text:
    print(i)
