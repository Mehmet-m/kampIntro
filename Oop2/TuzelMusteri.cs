using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Coorporate
    //miras inheritance - müşteride olanlar tüzelde ve gerçek müşteride de vardır demek

    class TuzelMusteri:Musteri
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
