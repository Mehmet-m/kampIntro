using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Mehmet";
            musteri1.LastName = "Tiksöz";
            musteri1.PhoneNumber = "0555 555 5555";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Engin ";
            musteri2.LastName = "Demiroğ";
            musteri2.PhoneNumber = "0555 555 5555";

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Kerem ";
            musteri3.LastName = "Varış";
            musteri3.PhoneNumber = "0555 555 5555";

            Musteri musteri4 = new Musteri();
            musteri4.Name = "Berkay";
            musteri4.LastName = "Bilgin";
            musteri4.PhoneNumber = "0555 555 5555";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };


            Console.WriteLine("\nKişiler");
            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.Name+ " " +Musteri.LastName+ " " +Musteri.PhoneNumber);
            }
            Console.WriteLine("\n\n----------------------------------");


            MusteriManager musteri = new MusteriManager();
            Console.WriteLine("\n\nSilinen kişiler");
            musteri.MSil(musteri1);            
            musteri.MSil(musteri3);
            
            Console.WriteLine("\n\n----------------------------------");


            Console.WriteLine("\n\nKişiler liste");           
            for (int i = 0; i < musteriler.Length; i++)
            {
                musteri.MListele(musteriler[i]);
            }
        }
    }
}
