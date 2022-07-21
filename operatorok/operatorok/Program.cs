using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Libs.MediaFoundation.OPM;
using System.IO;

namespace operatorok
{
   public class Program
    {
         public static void Main(string[] args)
        {
           

            //Deklarálás:

            int a,b,c,d;



            //Értékadó operátor
            int f = 19;



            //Definiálás -> = 

            a = 15;
            b = 16;
            c = 17;
            d = 18;
            


            //Aretmatikai operátorok: +, -, *, /, %;

           int g = a + b;
           int h = a - b;
           int i = a * b;
           int j = a / g;

           int k = 15 % 13;

            Console.WriteLine("g = {0}", g);



            //Összehasonlító operátorok, relációs operátorok:

            bool bo = a == b;
            Console.WriteLine(bo);

            bool bo2 = a != b;
          

            bool bo3 = a < b;
            

            bool bo4 = a > b;
           

            bool bo5 = a <= b;
       

            bool bo6 = a >= b;
           
            Console.WriteLine(" bo = {0}, bo2 = {1}", bo, bo2);



            //Logikai operátorok
            string favColor1 = "kék";
            string favColor2 = " zöld";
            
          
            bool bo7 = favColor1 != favColor2 && favColor2 == "zöld";
            Console.WriteLine("bo7 = {0}", bo7);

            //Operátorok precedencia:

            int z =(65 +9) *2;
            Console.WriteLine(z);

            //Rövidítések
            a = a + 9;
            a += 8;
            Console.WriteLine(a);
            a = a - 8;
            a -= 8;
            Console.WriteLine(a);

            //Postfix
            a++;
            a--;
            
            //Prefix
            ++a;
            --a;

            a = 1;
            b = a++;
           
            Console.WriteLine("a = {0}, b = {1}", a, b);


            Console.ReadKey();

        }
    }
}
