using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlemeOrani = 88;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "JAVA";
            kurs2.Egitmen = "Kenan";
            kurs2.IzlemeOrani = 55;

            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "PAYTIN";
            kurs3.Egitmen = "Haso";
            kurs3.IzlemeOrani = 100;

            Console.WriteLine(kurs1.Kursadi + ":" + kurs1.Egitmen);
            Console.WriteLine("foriçöncesi");
            Kurs[] kurslar= new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen);

            }
        }
    }


    class Kurs
    {
        public string Kursadi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemeOrani { get; set; }
    }
}
