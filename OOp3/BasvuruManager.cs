using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection kullanıcağı krediyi ve loglayıcıyı enjekte ediyoruz
        public void BasvuruYap(IKrediManager krediManager, ILogerService logerService)
        {

            krediManager.Hesapla();
            logerService.Log();
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
