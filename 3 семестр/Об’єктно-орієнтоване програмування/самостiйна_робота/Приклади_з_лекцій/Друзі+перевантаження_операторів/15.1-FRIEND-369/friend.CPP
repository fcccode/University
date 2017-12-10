                                                                               #include <iostream.h>
class Pal {
 friend class Buddy;
private :
int x;
 protected:
void doublex(void) { x *= x; } // Доступен в Pal и Buddy
public:
Pal(){x=100;}
Pal(int n){x=n;}// Доступна всем пользователям
};
class Buddy{
private:
Pal palObject;
public:
void ShowValues();
};
main()
{
Buddy aBuddy;
aBuddy.ShowValues();
return 0;
}
void Buddy::ShowValues(void)
{
Pal aPal(1234);
cout <<'\n'<<"Before, palObject.x == " << palObject.x;
palObject.doublex();
cout <<'\n'<<"After, palObject.x == " <<palObject.x;
cout <<'\n'<<"aPal.x == " << aPal.x << '\n';
}
