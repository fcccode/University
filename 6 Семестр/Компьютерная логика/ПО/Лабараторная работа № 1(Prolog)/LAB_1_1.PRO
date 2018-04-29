domains
	s = symbol
predicates
	algorithm(s)
	proced(s)
clauses
	algorithm("C").
	algorithm("Pascal").
	proced(LANGUAGE):-algorithm(LANGUAGE).
