import os

# read from file
def read(path):
    file = open(path)
    temp = file.read()
    file.close()
    return temp


# check text and fill dictionary
def check_text(data_from_file, word):
    counter = 0
    list_prev = []
    list_next = []
    string_line = data_from_file.split(" ")
    for line in string_line:
        line = line.strip(" ")
        if line == word.strip(" "):
            if counter == 0:
                list_next.append(string_line[counter + 1])
            else:
                list_prev.append( string_line[counter-1])
                list_next.append(string_line[counter + 1])
        counter += 1
    return list_prev, list_next


# change information from list to dictionary
def statistics(list_):
    """
    change information from list to dictionary
    :param list_: list with information about word
    :return: dictionary whose have
    """
    dic_ = {}
    for val in list_:
        counter = 0
        temp = val
        dic_.setdefault(val, counter)
        for j in list_:
            if temp == j:
                counter += 1
        for i in list_:
            if val == i:
                list_.remove(temp)
        dic_d = {temp: counter}
        dic_.update(dic_d)
    return dic_


# sort dictionary and find most_often_found
def most_often_found(dic_):
    """
    sort dictionary and find most_often_found
    :param dic_: dictionary
    :return: most_often_found
    """
    points = dic_
    l = lambda x: x[0]
    m = sorted(points.items(), key=l, reverse=False)
    return m[0]
