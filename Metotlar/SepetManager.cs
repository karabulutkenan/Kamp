using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
   class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler Eklendi: " +
                product.Adi);
            Console.WriteLine(".............  ");
        }
        public void Ekle2(string Adi, string Aciklama, int Fiyat)

        {
            Console.WriteLine("Eklendi: " + Adi );
        }
    }
}
