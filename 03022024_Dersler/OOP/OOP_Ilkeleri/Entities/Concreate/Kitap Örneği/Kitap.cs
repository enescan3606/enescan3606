using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Ilkeleri.Entities.Concreate.Kitap_Örneği
{
    public class Kitap
    {

        public Kitap()
        {

        }
        public Kitap(string kitapAdi,string turu)
        {
            Turu = turu;
            KitapAdi = kitapAdi;
        }
        public Kitap(string kitapAdi, string turu,int sayfaSayisi)
        {
            SayfaSayisi = sayfaSayisi;
            Turu = turu;
            KitapAdi = kitapAdi;
        }

        public string KitapAdi { get; set; }
        public string Turu   { get; set; }
        public int SayfaSayisi   { get; set; }
        public int Fiyati   { get; set; }
        public YayinEvi YayinEvi { get; set; }
        public Yazar Yazar { get; set; }
        public Raf Raf { get; set; }



        public double KdvDahilFiyati()
        {
            return Fiyati * 1.2;
        }

        public string Kunye()
        {

            return $"Kitap Adi: {KitapAdi}, Fiyati : {Fiyati} - Kdv Dahil Fiyati {KdvDahilFiyati()} Yazari: {Yazar.YazarAdi}, YayinEvi : {YayinEvi.AdiSoyadi}, Bu kitabi şurada bulabirsin : {Raf.KategoriAdi}-{Raf.Konumu}";
        }
    }
}
