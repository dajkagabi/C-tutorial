using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbekeres
{
   public class Program
    {
        static void Main(string[] args)
        {

            //Gyök (sqrt)
            double sqrt = Math.Sqrt(16);
            Console.WriteLine("Sqtr = {0}", sqrt);
            //Hatványozás(pow):
            double pow = Math.Pow(2, 9);
            Console.WriteLine("Pow = {0}", pow);
            //Kerekítés
            double round = Math.Round(18.6);
            Console.WriteLine(" Round = {0}", round);
            double floor = Math.Floor(17.6);
            Console.WriteLine("Floor = {0}", floor);
            double ceiling = Math.Ceiling(15.2);
            Console.WriteLine("Ceiling = {0}", ceiling);

            //3-mal és 5-tel osztható számok:

            //Drótváz:
            int num;
            bool again;

            do
            {
                Console.WriteLine("Adj meg egy öttel és három osztható számot: ");
                num = int.Parse(Console.ReadLine());
                if (num%5 == 0 && num%3 ==0)
                {
                    again = false;
                }
                else
                {
                    Console.WriteLine("Nem jó számot adtál meg!");
                    again = true;
                }
            } while (again);
            

            



            Console.ReadKey();
        }
    }
}
