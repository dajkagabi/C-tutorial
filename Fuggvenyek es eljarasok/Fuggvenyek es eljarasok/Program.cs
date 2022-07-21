using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek_es_eljarasok
{
    public class Program
    {
        static void/*eljaras*/ Greetings(string nev, string partOfTheDay)
        {
            string greetings = "Szia " + nev + "! Jó "+partOfTheDay;
            Console.WriteLine(greetings);
        }

        static string StrGreetings(string nev, string partOfTheDay)
        {
            string greetings = "Szia " + nev + "! Jó " + partOfTheDay;
            return greetings;
            Console.WriteLine("Nincs itt");
        }
        static void Main(string[] args)
        {

            //Kód újrafelhasználhatóság

            //Függvény hívás:

            Greetings("Pista", "reggelt");
            //Vagy
            string nev2 = "Sanyi";
            string partOfTheDay = "estét";

            Greetings(nev2, partOfTheDay);

            //Eljárások (void és nincs return)

            string greetings2 = StrGreetings("Béla", "napot");
            Console.WriteLine(greetings2);



            Console.ReadLine();



        }
    }
}
