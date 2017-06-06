class String(str):
    string = ''
    def __init__(self, string):
        self.string = string
    def is_have_repeat(self, s):
        print(s, self.string)
        iterator = 0
        result = 0
        for i in range(len(self.string)):
            result = self.string.find(s, result + 1, len(self.string))
            print(result)
            if result >= len(self.string) \
                    or result == -1:
                return False
            iterator += 1
            if iterator >= 3:
                return True

    def is_polindrom(self):
        if len(self.string) == 0:
            return True
        else:
            beg = 0
            end = len(self.string)-1
            for i in range(int((end +1)/ 2)):
                if self.string[beg] != self.string[end]:
                    return False
                else:
                    beg += 1
                    end -= 1
            return True
