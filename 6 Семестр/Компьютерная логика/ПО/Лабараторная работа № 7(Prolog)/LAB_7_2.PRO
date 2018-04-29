domains
  country, city, region = symbol
  square 			    = real
  population 			= integer
database-region_info
  region_info(country, region, city, square, population)
predicates
  find_record
  append_record
  remove_record
  display_db
  task(integer)
  repeater
  main_menu
  execute
clauses
	
	% поиск записи
	find_record:- makewindow(2,14,14,"Find by region",12,36,8,36),
            write("Region: "), readln(REGION),
            region_info(COUNTRY, REGION, CITY, SQUARE, POPUL), 
            write("Country : ", COUNTRY), 
            write("\nCity: ", CITY),
            write("\nSquare: ", SQUARE), 
            write("\nPopulation: ", POPUL),
            readln(_); write("Not found "),readln(_),removewindow.
			
	% добавление записи
	append_record:- makewindow(2,14,14,"Append record",12,36,10,36),
            write("Country: "), readln(COUNTRY),
            write("Region: "), readln(REGION),
            write("City: "), readln(CITY),
            write("Square: "), readreal(SQUARE),
            write("Population: "), readint(POPUL),
            assert(region_info(COUNTRY, REGION, CITY, SQUARE, POPUL)),save("region.dba");
            readln(_),write("Not found "),readln(_),removewindow.
			
	% удаление записи
	remove_record:- makewindow(2,14,14,"Remove record", 12,36,10,36),
            write("Region: "), readln(REGION),
            retract(region_info(_,REGION,_,_,_)),save("region.dba");
            write("Not found "),readln(_),removewindow.
			
	% отображение базы даных
	display_db:- makewindow(2,14,14,"Display database", 12,36,10,40),
            region_info(COUNTRY, REGION, CITY, SQUARE, POPUL),
            write("Country: ", COUNTRY),
			write("\nRegion: ", REGION),
            write("\nCity: ", CITY), 
            write("\nSquare: ", SQUARE),
            write("\nPopulation: ", POPUL),
            readln(_), clearwindow, fail; 
            write("The  end"),readln(_),removewindow.

	task(1):-exit.
	task(2):-find_record.
	task(3):-append_record.
	task(4):-remove_record.
	task(5):-display_db.

	
	main_menu:- makewindow(1,14,14,"Run programm", 5,10,8,26),
		write("1 - Exit"),nl,
		write("2 - Find record"),nl,
		write("3 - Append record"),nl,
		write("4 - Remove record"),nl,
		write("5 - Display database"),nl,readint(X),task(X),!.

	
	repeater.
	repeater:-repeater,
	execute:-repeater,main_menu.
goal
  existfile("region.dba"),consult("region.dba",region_info),execute,nl;write("Failed to open database"),nl.
