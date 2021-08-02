using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager,IloggerService loggerService)
        {
            //başvuran bilgilerini dğerlendirme
            //
            krediManager.Calculate();
            loggerService.log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>Krediler)
        {
            foreach (var kredi in Krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
