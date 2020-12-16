# IRF_Project

Cél: Egy általános iskolai tanár adott ki beadandó házifeladatot a tanulóinak az informatika alapjai című órán. A diákok feladata az volt, hogy vesszőkkel elválasztva kellett alakzatokat írni és hozzácsatolni azoknak sorbeli hosszúságát. Mivel a tanár egyedül vezeti az egész évfolyamot, ezért létre hoztunk neki egy rendszert, ahol egyszerűen navigálhat a tanulók beadandói közt és azokat értékelheti. A megadott osztályzatok nullánál kezdődnek, azokat manuálisan írhatja át. A tanár szigorúsága miatt akik későn adták be, azok egy jeggyel rosszabbat kapnak. A szoftvert átadtuk a tanárnak 10 db teszt adattal, hogy tesztelje le ő is a működését.

Classok:

Shape: Név, dimenziók(sor),adat
Student: Név, Shape, id, late(későn adta-e be)
Grade: Student, osztályzat


Főbb függvények:

init: A főbb értékek megadása és fő UI elementek eltárolása
ReadData: Az adatok beimportálásért felelős
TestData: Az output szekcióban lehet ellenőrizni az adatok integritását
ReAlignButtons: A gombok elhelyezése a felületre
AppendList: Az adatokból a lista feltöltése
CreateTable: Excel exporthoz konfiguráció
Egyéb event függvények: button export és grade click, list selectedIndexChange


Adatok:

A data mappában található .csv fájl.
