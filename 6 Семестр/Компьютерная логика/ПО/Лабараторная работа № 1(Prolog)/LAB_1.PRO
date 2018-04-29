domains
	name = symbol
predicates
	student(name)
	has_right(name)
clauses
	student("Annaev").
	student("Ivanov").
	student("Smirnov").
	has_right(STUDENT):-student(STUDENT),nl,write("Student ", STUDENT," has right ").