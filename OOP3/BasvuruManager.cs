using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

        //birbirinin alternatifi olan ama kod icerikleri farklı olanlar için kullanılır. -- > interface
    }
}
