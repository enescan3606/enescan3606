using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Ilkeleri.Entities.Concreate.Kitap_Örneği
{
    public class Yazar
    {
        public string YazarAdi { get; set; }
        public string Sehir { get; set; }
        public Kitap[] Kitaplar { get; set; }
        //public List<Kitap> Kitaplar { get; set; }
    }
}
