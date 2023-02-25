using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Mal";
            product1.Aciklama = "Beyaz Mal";
            product1.Fiyati = 200;

            Product product2 = new Product();
            product2.Adi = "Mal2";
            product2.Aciklama = "Siyah Mal";
            product2.Fiyati = 300;


            Product[] products = new Product[] {product1, product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("..................");
            }
            Console.WriteLine(".............Metotlar.........");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("Mal3","KırmızımAL",20);
        }
    }
}
