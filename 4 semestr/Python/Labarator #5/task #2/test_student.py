import student as s

obj = s.StudentInfo("Aska", 5)
obj.set_lab_result(1, 5)
obj.set_lab_result(2, 5)
obj.set_lab_result(3, 3)
obj.set_lab_result(4, 5)
obj.set_lab_result(5, 5)

obj.set_ind_result(1,4)
obj.set_ind_result(2,2)
obj.set_ind_result(3,4)

obj.result_info()
obj.is_allowed_to_exam()
