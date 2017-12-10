#include <string.h>
#include "db.h"
class TRecord {
private:
char name[41];
public:
TRecord()
{ name[0] = 0; }
TRecord(const char *s)
{ Assign(s); }
void Assign(const char *s)
{ strncpy(name, s, 40); }
char *GetName(void)
{ return name; }
};

main()
{
int rn;
TDataBase<TRecord> db(3);
TDataBase<TRecord*> dbp(3);
TDataBase<TRecord> *pdb;
TDataBase<TRecord*> ppdb;
cout << "\n\nDatabase of 3 TRecords\n"; 
db.GetRecord(0).Assign("George Washington"); 
db.GetRecord(1).Assign("John Adams"); 
db.GetRecord(2).Assign("Thomas Jefferson"); 
for (rn = 0; rn <= 2; rn++) 
cout << db.GetRecord(rn).GetName() <<' \n';
cout << "\n\nDatabase of 3 TRecord pointers\n"; 
dbp.GetRecord(0) = new TRecord("George Bush"); 
dbp.GetRecord(1) = new TRecord("Ronald Reagan"); 
dbp.GetRecord(2) = new TRecord("Jimmy Carter"); 
for (rn = 0; rn <= 2; rn++) 
cout << dbp.GetRecord(rn)->GetName() << '\n';
cout << "\n\nPointer to database of 3 TRecords\n"; 
pdb = new TDataBase<TRecord>(3);
pdb->GetRecord(0).Assign("John Adams"); 
pdb->GetRecord(1).Assign("Thomas Jefferson"); 
pdb->GetRecord(2). Assign ("Aaron Burr"); 
for (rn = 0; rn <= 2; rn++) 
cout << pdb->GetRecord(rn).GetName() << "\n";
cout << "\n\nPointer to database of 3 TRecord pointers\n"; 
ppdb = new TDataBase<TRecord *>(3);
ppdb->GetRecord(0) = new TRecord("Dan Quayle"); 
ppdb->GetRecord(1) = new TRecord("George Bush"); 
ppdb->GetRecord(2) = new TRecord("Walter Mondale"); 
for (rn = 0; rn <= 2; rn++) 
cout << ppdb->GetRecord(rn)->GetName() << '\n';
return 0;
}
