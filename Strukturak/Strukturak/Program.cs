using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturak
{
    public class Program
    {
        struct PC
        {
            //Mezők:
            //public int csiga;

            public string procType;
            public string memoryType;
            public string hardDriveType;
            public int procClockSpeed;
            public int memoryClockSpeed;

            //Konstruktor:
            public PC(string procType, string memoryType, 
                string hardDriveType, int procClockSpeed, 
                int memoryClockSpeed)
            {
                this.procType = procType;
                this.memoryType = memoryType;
                this.hardDriveType = hardDriveType;
                this.procClockSpeed = procClockSpeed;
                this.memoryClockSpeed = memoryClockSpeed;
            }

        /*    //Metódusok:
            public void Metodus()
            {
                Console.WriteLine("Metodus vagyok: ");
            }
        */

            static void DisplayPc(string fileName)
            {
                StreamReader de = new StreamReader(fileName);
                List<PC> pcList = new List<PC>();
                while (de.EndOfStream)
                {
                    string[] pcInfo = de.ReadLine().Split();

                    int procSpeed = int.Parse(pcInfo[3]);

                    int memorySpeed = int.Parse(pcInfo[4]);

                    PC pc = new PC(pcInfo[0], pcInfo[1], pcInfo[2], procSpeed, memorySpeed);

                    pcList.Add(pc);
                }

                de.Close();

                foreach (PC item in pcList)
                {
                    Console.WriteLine("Processzor típus = {0}, " +
                        "Memória típus = {1}," +
                        "Meremlemez típus = {2}" +
                        "Processzor órajel = {3}" +
                        "Memória órajel = {4}"
                        );
                }
            }

        }
        static void Main(string[] args)
        {
            /*   PC pc = new PC();
            pc.csiga = 45;
              Console.WriteLine(pc.csiga);
            */

            /* PC pc = new PC("AMD", "DDR4", "SSD", 2666, 3200);
             pc.Metodus();
             Console.WriteLine(pc.memoryClockSpeed+ "Mhz");
            */

            DisplayPc("pc_list.txt");

            Console.ReadLine();

        }
    }
}
