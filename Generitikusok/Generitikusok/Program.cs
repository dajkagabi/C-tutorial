using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Generitikusok
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Generikusok:

            //List:
            List<string> valami = new List<string>();

            valami.Add("fahéjas csiga");
            valami.Add("kockás valami");
            valami.Add("valaki járt itt");
            valami.Add("vaj");
            valami.Add("sör");

            //Elvételi formák: Remove, RemoveAt-indexet vár!
            valami.Remove("csiga");
            valami.RemoveAt(0);


            int capacity = valami.Capacity;
            
            foreach (string item in valami)
            {
                Console.WriteLine("item = {0}", item);
            }

            //Törlés (clear): 

            valami.Clear();

            //ArrayList:

            ArrayList blist = new ArrayList();

            blist.Add("string");
            blist.Add("5");
            blist.Add(true);
            var barmilyenTipus = 2;

            //Var bármilyen típus:
            foreach (var item in blist)
            {
                Console.WriteLine(item);
            }

            //Szótár:
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("kályha", "car");
            dict.Add("föld", "moon");
            dict.Add("lapos", "white");
            dict.Add("tűz", "black");
            dict.Add("nyelv", "green");

            foreach (var /*KeyValuePair*/ item in dict)
            {
                Console.WriteLine("magyar szó = {0}, angol szó = {1}", item.Key, item.Value);
            }
            
            Console.ReadLine();
        }
    }
}
