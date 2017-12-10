// minmax.h -- Шаблоны функций min и max 

 #ifndef 	__MINMAX_H
 #define 	__MINMAX_H 1 // Предотвращение повторных S

 template<class T> T max(T a, T b) 
 {
 if (a > b) 
 return a; 
 else 
 return b;
 } 

 template<class T> T min(T a, T b) 
 {
 if (a < b) 
 return a; 
 else 
	return b;
 } 

 #endif // 	__MINMAX_H
