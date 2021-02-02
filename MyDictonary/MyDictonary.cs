using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictonary<Key, Value>
    {
        Key[] Prices;
        Value[] Products;

        public MyDictonary()
        {
            Prices = new Key[0];
            Products = new Value[0];
        }
        public void Add(Key Price, Value Product)
        {
            Key[] safe = Prices;
            Value[] safe1 = Products;
            Prices = new Key[Prices.Length + 1];
            Products = new Value[Products.Length + 1];

            for (int i = 0; i < safe.Length; i++)
            {
                Prices[i] = safe[i];
                Products[i] = safe1[i];
            }

            Prices[Prices.Length - 1] = Price;
            Products[Products.Length - 1] = Product;

            Console.WriteLine(Price+ " " +Product);
            
        }   
        public int Length
        {
            get { return Prices.Length; }           
        }
        
    }
}
