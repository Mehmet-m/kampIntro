using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "Notebook";
            product1.UrunFiyati = 10000;

            Product product2 = new Product();
            product2.UrunAdi = "Televizyon";
            product2.UrunFiyati = 5000;

            Product product3 = new Product();
            product3.UrunAdi = "Sweatshirt";
            product3.UrunFiyati = 70;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.UrunAdi);
                Console.WriteLine(product.UrunFiyati);
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Pub(product1);
            sepetManager.Pub(product2);
            sepetManager.Pub(product3);

        }
    }
    class Product
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
    }
        

}
