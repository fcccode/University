domains
	s = symbol
predicates
	parallel(s,s)
	perpendicular(s,s)
	is_parallel_com(s,s)
	is_parallel_aso(s,s)
	is_perpendicular_com(s,s)
	is_perpendicular_aso(s,s)
	is_present_paral_perpend(s,s)
clauses
	parallel(a,c).
	parallel(c,a).
	perpendicular(a,b).
	perpendicular(b,a).
	is_parallel_com(X,Y):-parallel(X,Y);parallel(Y,X).
	is_parallel_aso(X,Y):-parallel(X,Z),parallel(Z,Y);parallel(Z,X),parallel(X,Y).
	is_perpendicular_com(X,Y):-perpendicular(X,Y);perpendicular(Y,X).
	is_perpendicular_aso(X,Y):-perpendicular(X,Z),perpendicular(Z,Y);perpendicular(Z,X),perpendicular(X,Y).
	is_present_paral_perpend(X,Y):-is_parallel_com(X,Y),is_perpendicular_com(X,Y).
	

	