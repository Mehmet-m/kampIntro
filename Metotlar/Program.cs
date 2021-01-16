using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Açıklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Açıklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };
            //type safe -- tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Açıklama);
                Console.WriteLine("--------------------");

            }

            Console.WriteLine("-----Metotlar------");
            //instance - örnek
            //encapsulation - kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut","Yeşil Armut", 12, 15);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 12);
            sepetManager.Ekle2("Salatalık", "Yeşil Salatalık", 12, 11);
        }
        
    }
    
}



//Dont Repead Your Self - DRY - Clean Code - Best Practice