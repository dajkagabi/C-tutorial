using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fajlkezeles
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Fáljkezelés fajtái:
                - relatív : mappa / fájl
                - abszolute: D:\\....\...\fajl
            */

            List<string> vasarlas = new List<string>()
            {
                "csiga", 
                    "kakaó", 
                    "tej",
                    "vaj", 
                    "alma", 
                    "répa",
            };

            /*Fáljbe írás:
                - ASCII 7 bites 128
                - Unicode: 2 bite: 65536
                - UTF-8: 2,3,4 bite: változó hosszúságú karakter kódolás.
             
             */
            StreamWriter van = new StreamWriter("bevasarlolista.txt");
            foreach (string item in vasarlas)
            {
                van.WriteLine(" - " + item);
            }

            //Egyszerre csak egy tud futni.
            van.Flush();
            van.Close();

            //Fáljolvasás:
            StreamReader de = new StreamReader("bevasarlolista.txt", Encoding.UTF8);
            while (!de.EndOfStream)
            {
                Console.WriteLine( de.ReadLine());
            }

            de.Close(); 
            Console.ReadLine();



        }
    }
}
