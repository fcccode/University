#include <iostream.h>
#include <string.h>
#include <conio.h>
#include "db.h"
class TRecord
{
private:
	 char name[41];
public:
	 TRecord()
	 {
	 name[0]=0;
	 }
	 TRecord(const char *s)
	 {
	 Assign(s);
	 }
	 void Assign(const char *s)
	 {
		strncpy(name, s, 40);
	 }
	 char *GetName(void)
	 {
		return name;
	 }
};

main()
{
int rn;                     //indeks chisla zapusiv
TDatabase<TRecord> db(3);   //baza danih iz 3 TRecords
TDatabase<TRecord*> dbp(3); //baza danih iz 3 ukazateley
TDatabase<TRecord> *pdb;    //ukazatel na bazu danih
TDatabase<TRecord*> *ppdb;   //ukazatel na bazu danih ukazateley na TRecord

cout<<"\n\nDatabase of 3 TRecords\n";
db.GetRecord(0).Assign("George Washington");
db.GetRecord(1).Assign("John Adams");
db.GetRecord(2).Assign("Thomas Jefferson");
	for(rn = 0; rn <= 2; rn++)
	cout<<db.GetRecord(rn).GetName()<<'\n';

cout<<"\n\nDatabase of 3 TRecord pointers\n";
dbp.GetRecord(0) = new TRecord("George Bush");
dbp.GetRecord(1) = new TRecord("Ronald Reagan");
dbp.GetRecord(2) = new TRecord("Jimmy Carter");
	for(rn = 0; rn <= 2; rn++)
	cout<<dbp.GetRecord(rn)->GetName()<<'\n';

cout<<"\n\nPointer to database of 3 TRecords\n";
pdb = new TDatabase<TRecord>(3);
pdb->GetRecord(0).Assign("John Adams");
pdb->GetRecord(1).Assign("Tomas Jefferson");
pdb->GetRecord(2).Assign("Aron Burr");
	for(rn = 0; rn<=2; rn++)
	cout << pdb->GetRecord(rn).GetName()<<'\n';

cout<<"\n\nPointer to database of 3 TRecord pointers\n";
ppdb = new TDatabase<TRecord *>(3);
ppdb->GetRecord(0) = new TRecord("Dan Quayle");
ppdb->GetRecord(1) = new TRecord("George Bush");
ppdb->GetRecord(2) = new TRecord("Walter Mondale");
	for(rn = 0; rn <=2; rn++)
	cout<<ppdb->GetRecord(rn)->GetName()<<'/n';
    getch();
	return 0;
}