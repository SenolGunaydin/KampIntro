using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety ----> Tip güvenliği
            //deger tutucu -- > alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool girisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Asagi Ok Image");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Yukari Ok Image");
            }
            else
            {
                Console.WriteLine("Eşittir Image");
            }

            if (girisYapmisMi)
            {
                Console.WriteLine("Kullanıcı ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yapılmamıs");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
