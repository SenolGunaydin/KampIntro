using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi. " + urun.UrunAdi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi )
        {
            Console.WriteLine("Sepete Eklendi. " + urunAdi);
        }
    }
}
