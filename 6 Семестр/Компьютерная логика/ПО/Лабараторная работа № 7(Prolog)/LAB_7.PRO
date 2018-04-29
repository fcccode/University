domains
  country, city, region = symbol
  square 			    = real
  population 			= integer
database-region_info
  region_info(country, region, city, square, population)
clauses
   region_info("Turkmenistan", "Mary",    "Mary" ,         87.0,  11468).
   region_info("Turkmenistan", "Ahal",    "Anau",          95.0,  7228).
   region_info("Turkmenistan", "Lebap",   "Turkmenabat",   94.0,  10347).
   region_info("Turkmenistan", "Balkan",  "Turkmenbashy",  138.0, 4247).
   region_info("Turkmenistan", "Dashoguz","Dashoguz",      74.0,  10598).
goal
     save("c:region.dba",region_info).  

