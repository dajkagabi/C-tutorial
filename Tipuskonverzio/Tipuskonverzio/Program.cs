using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipuskonverzio
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Típusverziók:
                - érték: float, double, int -> Stack: LIFO;
                - referencia -> osztályok -> Heap: nyers memória 
            */

            //Implicit típuskonverzió:
            float f = 16.6f; /*az érték után mindig tegyük oda az f-t!*/
            double d = f;

            double e2 = 166.7;
            //Kasztolás, típuskényszerítés
            float f2 = (float)e2;

            //Parsolás:
            string strNum = "18";
            int i = int.Parse(strNum);

            //Konvertálás:
            int i2 = 666;
            short s = Convert.ToInt16(i2);


            //Is és as
            if (strNum is string)
            {
                Console.WriteLine("Ez egy string változó");
            }

            object obj = strNum as object;

            Console.ReadLine();

        }
    }
}
