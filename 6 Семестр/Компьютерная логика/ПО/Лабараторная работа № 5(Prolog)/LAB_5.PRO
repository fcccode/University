domains
	s=symbol
predicates
	word(s,s,s,s,s)
	translate(s,s)
	conc
	dlina
	fronts
	g
	repeat
clauses
	word(car,"mashina","imennyk","mashinnyy","prykmetnyk").
	word(cat,"koshka","imennyk","koshachiy","prykmetnyk").
	word(dog,"sobaka","imennyk","sobachiy","prykmetnyk").
	
	repeat.
	repeat:- repeat.

	g:-  	repeat, nl, 
			write ("Pervoye slovo"),nl, 
			readln(X), 
			write ("Vtoroe"),nl, 
			readln(Y), word(X1,_,_,_,_), X1=X, 
			word(Y1,_,_,_,_), Y1=Y, 
			write (" OK "), translate (X,Y),!.
	translate(X,Y):- word(X,_,_,X2,_), word(Y,Y2,_,_,_),nl, 
			write("pereklad"), nl, 
			write(X2,"   ",Y2).

	conc:- 	write ("Pervoye slovo"), nl, 
			readln(A), 
			write("Vtoroe slovo"), nl, 
			readln(B), 
			concat(A,B,C), 
			write(C),nl.


	dlina:- write ("Vvedite slovo"), nl, 
			readln(A), str_len(A,B), 
			write("dlina slova=",B), nl.

	fronts:-write("Vvedite slovo"), nl, 
			readln(A), 
			write("Vvedite dlinu"), nl, 
			read-int(L), 
			frontstr(L,A,B,C), 
			write("Pervaya Stroka =",B), nl, 
			write("Resultat=",C), nl.
