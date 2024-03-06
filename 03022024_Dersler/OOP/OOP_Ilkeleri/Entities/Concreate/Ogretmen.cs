using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Ilkeleri.Entities.Concreate
{
    public  class Ogretmen
    {

        public string AdSoyadi { get; set; }
        public string Brans{ get; set; }
        public int TecrubeSuresi{ get; set; }
        public string Sehir{ get; set; }

        public Ogrenci[] Ogrenciler{ get; set; }
    }
}
