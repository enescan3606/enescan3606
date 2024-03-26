using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Entities.Concreate
{
    public class Kitap
    {

        public Kitap()
        {

        }
        public Kitap(string kAdi)
        {
            KitapAdi = kAdi;
        }
        public Kitap(Yazar yazar, string pKitapAdi, string pTuru, int pSayfaSayisi, int pFiyati)
        {
            KitapAdi = pKitapAdi;
            Turu = pTuru;
            SayfaSayisi = pSayfaSayisi;
            Fiyati = pFiyati;
            Yazar = yazar;
        }

        public string KitapAdi { get; set; }
        public string Turu { get; set; }
        public int SayfaSayisi { get; set; }
        public int Fiyati { get; set; }

        public Yazar Yazar{ get; set; }

    }
}
