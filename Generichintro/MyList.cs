using System;
using System.Collections.Generic;
using System.Text;

namespace Generichintro
{   
    class MyList<T>
    {
        T[] İtems;
        //constuructor
        public MyList()
        {
            İtems = new T[0];
        }
        public void Add( T item )
        {
            T[] tempArray = İtems;  //yeni dizi tanımlandığında önceki elemanın kaybolmaması için yazılır.
            İtems = new T[İtems.Length + 1]; //dizinin eleman sayısını 1 arttır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                İtems[i] = tempArray[i];
            }

            İtems[İtems.Length - 1] = item;
        }
    }
}
