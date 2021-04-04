using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {   // array ---> dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Prograölamaya Başlangıç İçin Temel Kurs", "Java" };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
