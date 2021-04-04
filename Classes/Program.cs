using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs()
            {
                KursAdi = "Yazılım Geliştirici Yetiştirme Kampı",
                Egitmen = "Engin Demirog",
                IzlenmeOrani = 86
            };

            Kurs kurs2 = new Kurs()
            { 
                KursAdi = "C#",
                Egitmen = "Engin Demirog",
                IzlenmeOrani = 85
            };

            Kurs kurs3 = new Kurs()
            {
                KursAdi = "C++",
                Egitmen = "Engin Demirog",
                IzlenmeOrani = 75
            };

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
