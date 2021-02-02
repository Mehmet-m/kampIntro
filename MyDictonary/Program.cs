using System;
using System.Collections.Generic;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> pita = new MyDictonary.MyDictonary<int, string>();
            pita.Add(15, "Kıymalı Pide");
            pita.Add(19, "Kuşbaşılı Pide");
            pita.Add(7, "Lahmacun");
            pita.Add(17, "Kaşarlı Pide");
            pita.Add(10, "Otlu Pide");

            Console.WriteLine(pita.Length);
        }
    }
}
