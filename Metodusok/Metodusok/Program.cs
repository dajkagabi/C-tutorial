using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodusok
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Metódusok:

            string str = "Szép idő van ma! ljkfsljakfjlkajslkfljkakjl";
            Console.WriteLine(str[0]);

            string  subStr = str.Substring(5);
            Console.WriteLine("Substring = {0}", subStr);

            int index = str.IndexOf("ma");
            Console.WriteLine("IndexOf = {0}", index);

            int lastIndex = str.LastIndexOf("ép");
            Console.WriteLine("LastIndexOf = {0}", lastIndex);

            string replace = str.Replace("idő", "zivatar");
            Console.WriteLine(replace);

            string lowercase = str.ToLower();
            Console.WriteLine("ToLower = {0}", lowercase);

            string uppercase = str.ToUpper();
            Console.WriteLine("ToUpper = {0}", uppercase);

            string [] split = str.Split('!');
            for (int i = 0; i < split.Length; i++)
            {
                Console.WriteLine("i-edik szó: {0}", split[i]);
            }

            if (str.Contains("ég"));
            {
                Console.WriteLine("Szerepel benne a szó!");
            }

           

            Console.ReadKey();
        }
    }
}
