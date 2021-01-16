using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "yazılmcı eğitim kampı";
            string kurs3 = "java";

            string[] Kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , 
                "yazılmcı eğitim kampı" , "java" ,"pyton" };

            for (int i = 0; i < Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }




                    Console.WriteLine("Sayfa sonu");
        }

    }
    

}
