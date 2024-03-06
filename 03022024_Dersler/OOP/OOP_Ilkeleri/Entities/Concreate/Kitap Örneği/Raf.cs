using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Ilkeleri.Entities.Concreate.Kitap_Örneği
{
    public class Raf
    {
        public string  KategoriAdi{ get; set; }
        public string  Konumu { get; set; }
        public string  YetkiliKisisi{ get; set; }
        public string RenkKodu { get; set; }
        public Kitap[] Kitaplar { get; set; }
    }
}
