domains
  s= symbol
predicates
  fact1 r1 end_fact1(s) 
  fact2  end_fact2(s) 
  fact3  end_fact3(s) 
  fact4  end_fact4(s) 
  fact5  end_fact5(s)
clauses
  r1.
  r1:-r1.
  fact1:-write("Data osnovaniya CNTU"), nl,
      r1,readln(N),end_fact1(N),!.
  end_fact1(X):-X="1929",write("Correct!"),nl.
  fact2:-write("Skolko budet 2+ 2"), nl,
      r1,readln(N),end_fact2(N),!.
  end_fact2(X):-X="4",write("Correct!"),nl.
  fact3:-write("Chemu raven resultat logicheskoy operacii TRUE and FALSE"), nl,
      r1,readln(N),end_fact3(N),!.
  end_fact3(X):-X="FALSE",write("Correct!"),nl.
  fact4:-write("V kakom godu Ukraina poluchila Nezavisimost"), nl,
      r1,readln(N),end_fact4(N),!.
  end_fact4(X):-X="1991",write("Correct!"),nl.
  fact5:-write("Skolko bit v odnom bayte"), nl,
      r1,readln(N),end_fact5(N),!.
  end_fact5(X):-X="8",write("Correct!").
goal
  fact1,fact2,fact3,fact4,fact5.
