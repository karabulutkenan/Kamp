using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Kamp1";
            string kurs2 = "Kamp2";
            string kurs3 = "Kamp3";

            string[] kurslar = new string[] { "Kamp1", 
                "Kamp2", "Kamp3", "KampYeni" };


            
            
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) { 
            
                Console.WriteLine(kurs);
            
            }

            Console.WriteLine("SayfaSonu");


        }
    }
}
