using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();

            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.MusteriAdi = "Şenol";
            gercekMusteri.MusteriSoyadi = "Günaydın";
            gercekMusteri.TcNo = "22222222222";
            gercekMusteri.Id = 1;

            TuzelMusteri tuzelMusteri = new TuzelMusteri();

            tuzelMusteri.MusteriNo = "654321";
            tuzelMusteri.SirketAdi = "kodlama.io";
            tuzelMusteri.Id = 2;
            tuzelMusteri.VergiNo = "1111111111111";







            Musteri musteri = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(gercekMusteri);
            customerManager.Add(tuzelMusteri);
        }
    }
}
