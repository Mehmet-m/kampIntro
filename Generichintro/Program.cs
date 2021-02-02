using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string >();
            isimler.Add("Engin");
            isimler.Add("Mehmet");
            isimler.Add("Mehmet");
            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);
          
        
           
        }
    }
}
