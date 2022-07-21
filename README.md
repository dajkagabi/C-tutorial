# C#
https://reiteristvan.files.wordpress.com/2018/01/reiter-istvc3a1n-c-programozc3a1s-lc3a9pc3a9src591l-lc3a9pc3a9sre.pdf

A C# nyelv egy objektumorientált programozási nyelv. 

Az Objektum orientált programnyelvet kint a c# és még sok más arra épülnek hogy egy csoportba tesz egy adag változót és az azokhoz tartotó függvényeket például van egy autó legyen ez az autó a csoport ennek az autónak van színe mérete stb, ezek a változók és tud menni fordulni ezek legyenek a függvények ezeket egy csoportba teszi a c# és ilyen csoportokból áll egy program ellentétben másféle programnyelvekkel.


A c#-ban minden parancsot egy ; jellel kell lezárni például a Consol.Wirite()-ot is le kell zárni egy pontosvesszővel 

Egy egyszerű C# program:

public class ExampleClass
{

    public static void Main()
    {
        System.Console.WriteLine("Helló világ!");
    }

}


Ez a rész felel meg a feladat végrehajtásának. A Console egy rendszerobjektum, ami egy parancssort jelképez. A Console objektum WriteLine metódusának meghívása a paraméterként átadott szöveget kiírja a parancssorba.
Változók és deklarációk

Ahhoz, hogy értékeket tudjunk megadni, először változót kell deklarálni, és utána inicializálni azt. deklaráció: int x; inicializálás: x = 10; Ezt lehet egyszerre is: int x = 10;

Egy példa a változókra:

class Változók                           // A nyelv támogatja az Unicode-karakterek használatát, így pl. ékezetek is tehetők a nevekbe.
{

    public static void Main()
    {
        int i = 10;                      // Az egész típusú i változó értéke 10.
        System.Console.WriteLine(i);     // Kírjuk a képernyőre.

        int i2 , i3;                     // Többszörös deklarálás
        i2 = 12;                         // Inicializáció
        i3 = 13;
        Console.WriteLine(i2);
        Console.WriteLine(i3);

        const double állandó = 3.1415;   //Egy állandó deklarációja és inicializálása
        double d = 12.3;                 //Tizedestört
        float f = 0.65F;                 //Az F betűvel jelezzük, hogy lebegőpontosan ábrázolandó.

        char c = 'c';                    // A char 1 karaktert tud tárolni (és azt ' ' jelek között kell megtenni).
        string s = "Helló világ!";       // A string karaktersorozatot tud tárolni "" jelek között.
        Console.WriteLine("double: {0}, float: {1}, char: {2}, string: {3}, állandó: {4}",d,f,c,s,állandó); //kiírjuk a képernyőre az eredményeket. A {0} helyére a d, az {1} helyére az f... fog kerülni.
        Console.ReadKey();               // A program egy billentyű lenyomására vár,
                                         //tehát nem fog véget érni a programunk, míg meg nem nyomunk egy gombot.
    }

}
