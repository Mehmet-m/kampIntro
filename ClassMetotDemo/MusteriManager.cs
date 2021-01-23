using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+ " " +musteri.LastName+ " : " +musteri.PhoneNumber+ " - " +"Kişisi eklendi.");
        }

        public void MSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " : " + musteri.LastName + " : " + musteri.PhoneNumber+ " - " +"Kişi kayıtlardan silindi.");
        }

        public void MListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " : " + musteri.LastName + " : " + musteri.PhoneNumber );
        }
        

    }
}
