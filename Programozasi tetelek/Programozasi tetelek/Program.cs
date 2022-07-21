using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programozasi_tetelek
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*/Programozási tételek:
                - megszámlásás:
                - összegzés: 
                - MIN ÉS MAX:
                - eldöntés:
                - kiválasztás:
            */

            //Megszámlálás
            int[] tomb = { 4,5,7,86,12,348,57,646,79};
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            

                if (tomb [i]>5)
                
                    szamlalo++;

                

                Console.WriteLine("A fetételnek {0} elem felel meg.", szamlalo);

            //Ha csak a for ciklus csak egyet feltételt vizsgál meg akkor nem muszáj a kapcsos zárójelek

            //Összegzés
            int[] az = { 4, 5, 7, 77, 89};
            int osszeg = 0;

            for (int i = 0; i < az.Length; i++)
            {
                osszeg += az[i];
            }
            Console.WriteLine("Összeg = {0} ", osszeg);


            //MIN ÉS MAX
            int [] te = {-127, 5, 66, 78, 98, 123, 45, 789, 45, 66, 124 };
            int min = te [0];
            

            for (int i = 0; i < te.Length; i++)
            
                if (te [i] < min)
                
                    min = te[i];
                

                Console.WriteLine("A legkisebb érték = {0}", min);


            //Eldöntés:

            int[] vs = { 54, 78, 123, 46, 77, 999, 0 };
            int szamlalo2 = 0;
            int keresett = 54;

            while (szamlalo2< vs.Length && vs[szamlalo2] != keresett)
            {
                szamlalo2++;
            }

            if (szamlalo2 < vs.Length)
            {
                Console.WriteLine(" A keresett érték a tömben van!");
            }
            else
            {
                Console.WriteLine("A keresett értkék nem található meg a tömben!");
            }

            //Kiválasztás: de csak akkor ha benne van a tömben

            Console.WriteLine("Az elem a {0}", szamlalo2+1);





            Console.ReadLine();
        }
    }
}
