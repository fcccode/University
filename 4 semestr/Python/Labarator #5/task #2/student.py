class Dictionary:
    lab_count = 0
    lab_dictionary = {}
    ind_dictionary = {}
    def __init__(self):
        pass


class StudentInfo:
    student_name = ''
    dictionary = Dictionary()


    def __init__(self, name, lab_count):
       self.student_name = name
       self.dictionary.lab_count = lab_count


    def set_lab_result(self, lab_number, lab_mark):
        if lab_number <=self.dictionary.lab_count:
            lab = {lab_number: lab_mark}
            self.dictionary.lab_dictionary.update(lab)
        else:
            print("All lab mark fill")


    def set_ind_result(self, ind_number, ind_mark):
        ind = {ind_number: ind_mark}
        self.dictionary.ind_dictionary.update(ind)

    def get_lab_result(self, lab_number):
        res = self.dictionary.lab_dictionary.get(lab_number)
        return res
    def get_ind_result(self, ind_number):
        res = self.dictionary.ind_dictionary.get(ind_number)
        return res

    def result_info(self):
        for i in self.dictionary.lab_dictionary:
            if i <= self.dictionary.lab_count:
                res = self.get_lab_result(i)
                print("Lab work # ", i, " mark = ", res)
        for i in self.dictionary.ind_dictionary:
            res = self.get_ind_result(i)
            print("Individual work # ", i, " mark = ", res)

    def is_allowed_to_exam(self):
        lab = 0
        iter= 0
        ind = 0
        for i in self.dictionary.lab_dictionary:
            if i <= self.dictionary.lab_count:
                lab += self.get_lab_result(i)
                iter += 1
        lab = lab / iter
        iter = 0
        for i in self.dictionary.ind_dictionary:
            ind += self.get_ind_result(i)
            iter += 1
        ind =ind / iter
        is_allowed = False
        if lab >= 3 and ind >= 3:
            is_allowed =  True

        print("Total mark for lab work = ", lab)
        print("Total mark for ind work = ", ind)
        print("Is Allowed to exam : ", is_allowed)
