using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezerlesi_szerkezetek
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             Vezérlési szerkezetek: 
            - ciklus
            - elágazás
            */


            //Ciklusok: 
            //Előltesztelő:
            int counter = 0;
            while (counter <15) //ciklusfej
            {
                counter++;
                Console.WriteLine("counter: {0}", counter);

            }

            //Hátultesztelő
            counter = 45;
            do
            {

                counter++;
                Console.WriteLine("counter: {0}", counter);


            } while (counter <15);


            //Számláló
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(" i = {0}", i);
            }

            //Elágazások:

            if (5<6)
            {
                Console.WriteLine("A 5 kisebb, mint a 6");
            }
            else
            {
                Console.WriteLine("Nem kisebb");
            }

          /*  int age = 15;
            if (age >=18)
            {
                Console.WriteLine("A felhasználó már nagykorú");
            }
            else
            {
                Console.WriteLine("A felhasználó még nem nagykorú");
            }
          */

            int age = 16;
            if (age >= 18)
            {
                Console.WriteLine("A felhasználó már nagykorú");
            }
            else if (age >= 16 && age <18)
            {
                Console.WriteLine("Büntethető");
            }
            else
            {
                Console.WriteLine("A felhasználó még nem nagykorú");
            }

            //Kapcsoló

        

            switch (age)
            {
                case 1:
                    Console.WriteLine("egy");
                    break;

                    case 2:
                    Console.WriteLine("kettő");
                    break ;

                    case 3:
                    Console.WriteLine("három");
                    break;

                default:
                    Console.WriteLine("Nincs ilyen");
                    break;
            }



            Console.ReadLine();
        }
    }
}
