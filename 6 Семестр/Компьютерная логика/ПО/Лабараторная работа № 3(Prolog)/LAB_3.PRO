domains
	s=symbol
predicates
	mother(s,s)
	father(s,s)
	parent(s,s)
	parent_m(s,s)
	parent_f(s,s)
clauses
	mother("Olga","Me").
	mother("Yuliya","Olga").
	mother("Praskovya","Vitaliy").
	mother("Anna","Yuliya").
	mother("Nastya","Praskovya").
	mother("Ganna","Kolya").
	mother("Evdokiya","Vasiliy").
	father("Vitaliy","Me").
	father("Vasiliy","Olga").
	father("Kolya","Vitaliy").
	father("Nikolay","Yuliya").
	father("Dmitriy","Vasiliy").
	father("Aleksandr","Praskovya").
	father("Ivan","Kolya").
	parent_m(X,Z):-mother(X,Z).				% Поиск предков женского пола
	parent_m(X,Z):-mother(X,Y), parent(Y,Z).
	parent_f(X,Z):-father(X,Z).				% Поиск предков мужского пола
	parent_f(X,Z):-father(X,Y),parent(Y,Z).
	parent(X,Y):-mother(X,Y);father(X,Y).	% Поиск предков родителя
	parent(X,Y):-mother(Z,Y),parent(X,Z);father(Z,Y),parent(X,Z).


	