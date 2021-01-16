using System;

namespace kampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Do Not Repead Your Self = kendini Tekrarlama
            //type safety = tip güvenliği

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.48;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;
            
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else 
            {
                Console.WriteLine("Değişmedi butounu");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            




            int i = 1;
            while(i<=10)
            {
                Console.WriteLine("Merhaba Dünya");
                i++;
            }

            Console.Read();
        }
    }
}
