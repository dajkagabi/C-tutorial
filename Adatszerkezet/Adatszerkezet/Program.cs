using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatszerkezet
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Random számok:
            //Osztály példány->
            Random r = new Random();
           /* Console.WriteLine(r.Next(0, 100));
          */
            //Tömbök: (array)
             int [] te = new int[100];
            Console.WriteLine();

            te[0] = 22;
            te[1] = 23;
            te[2] = 24;
            te[3] = 32;

             for (int i = 0; i < te.Length; i++)
              {
                  te[i] = r.Next(0, 100);
              }
            

            for (int i = 0; i < te.Length; i++)
            {
                Console.WriteLine("i = {0}", te[i]);
            }

            //Mátrix:(nem működik)
            Random t = new Random();
            int [,] matrix = new int [5, 10];
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; i < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = t.Next(10, 90);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; i < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i,j]+ " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
