using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();            
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILogerService databaseLoggerService = new DatabaseLoggerService();
            ILogerService fileLoggerSevice = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerSevice);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
