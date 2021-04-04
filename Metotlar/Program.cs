using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product
            {
                UrunAdi = "Elma",
                Id = 1,
                Fiyati = 15,
                Aciklama = "Amasya Elması"
            };

            Product product2 = new Product
            {
                Id = 2,
                UrunAdi = "Karpuz",
                Fiyati = 80,
                Aciklama = "Adana Karpuzu"
            };

            Product[] products = new Product[] { product1, product2 };

            foreach (var productList in products) 
            {
                Console.WriteLine(productList.UrunAdi);
            }

            SepetManager sepetManager = new SepetManager();
             
            sepetManager.Ekle(product1);
            //sepetManager.Ekle();
            //sepetManager.Ekle();
            //sepetManager.Ekle();
            //sepetManager.Ekle();

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Adana Karpuzu", 12, 8);
        }
    }
}
