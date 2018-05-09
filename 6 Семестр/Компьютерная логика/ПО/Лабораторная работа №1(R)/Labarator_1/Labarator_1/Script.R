library(dplyr)
library(ggplot2)

# Загрузка дата фрейма
# При необходимости указать путь
#setwd("~/works/")
flats <- read.csv("flats.csv", stringsAsFactors = FALSE, dec = ",", encoding = "UTF-8")
# Определение типа загружаемых данных
class(flats)
# Отображение структуры загруженных данных
str(flats)

# Определение количество измерений
dim(flats)
# Отобразить первые 6 строк
head(flats, 6)
# Отобразить первые 15 строк
head(flats, 15)
# Отобразить последние 6 строк
tail(flats, 6)
# Отобразить имена дата фреймов
names(flats)


# Определение данных о дата фрейме
glimpse(flats)
# Количество городов с учетом районов
count(flats, vars = Місто)
# Количество городов без учета района
flats %>% count(Місто) %>% filter(Місто != "Києво-Святошинський")
# Количество 3 ком. кв в городе Одесса 
flats %>% filter(Кімнат == 3) %>% count(Місто) %>% filter(Місто == "Одеса")
# Количество 3 ком. кв в городе Одесса 
flats %>% filter(Кімнат == 1) %>% filter(Місто == "Львів") %>% summarise(mean = median(Загальна_площа))


# Построение коробчатой диаграммы
ggplot(flats, aes(x = Кімнат, y = Ціна)) + geom_boxplot() + coord_flip()
# Построение графика рассеивания
ggplot(flats, aes(x = Загальна_площа, y = Ціна)) + geom_point()
# Построение гистограммы
ggplot(flats, aes(x = Ціна)) + geom_histogram(fill = "lightblue", col = "grey") + ylab('Кількість')

