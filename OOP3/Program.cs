using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterface lerde o interface yi implemente eden classın referansını tutmaktadır.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

           
        }
    }
}
