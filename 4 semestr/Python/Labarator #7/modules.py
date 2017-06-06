import os

def read_file(path_to_file):
    """
    Read text from file
    :param path_to_file: take path to file
    :return:  text
    """
    file = open(path_to_file)
    temp = file.read()
    file.close()

    return temp


def analysis(data):

    result = {}

    for letter in range (len(data)):
        counter = 0
        if data[letter] != ' ':
            for l in range (len(data)):
                if data[letter] == data[l]:
                    counter += 1

            for l in range (len(data)):
                if data[letter] == data[l]:
                    dic = {data[letter]: counter}
                    result.update(dic)
    return result


def check_punctuation(data):
    result = {}
    q = 0
    v = 0
    t = 0
    for i in range(len(data)):
        if data[i] == '!':
            v += 1
        if data[i] == '?':
            q += 1
        if data[i] == '.' and \
           data[i+1] == '.' and data[i+2] == '.':
            t += 1

    result.update({'...': t})
    result.update({'!': v})
    result.update({'?': q})

    return result
