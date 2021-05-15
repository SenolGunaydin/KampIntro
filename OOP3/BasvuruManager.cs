using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    public class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // basvuru bilgilerini degerlendirme
            //
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
