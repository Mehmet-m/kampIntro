using System;
using System.Collections.Generic;
using System.Text;

namespace Odev
{
    class SepetManager
    {
        public void Pub(Product product)
        {
            Console.WriteLine("Ürün Sepete Eklendi :" + product.UrunAdi);
            
        }
    }
}
