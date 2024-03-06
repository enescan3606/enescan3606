using OOP_Ilkeleri.Entities.Concreate;
using OOP_Ilkeleri.Entities.Concreate.Kitap_Örneği;
using System;

namespace OOP_Ilkeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP_1

            //Ogrenci ogr = new Ogrenci();
            //Ogrenci ogr1 = new Ogrenci();


            //Ogretmen ogretmen = new Ogretmen();
            //ogretmen.AdSoyadi = "Berk Hoca";
            //ogretmen.Brans = ".net Yazılım";
            //ogretmen.Sehir = "Ankara";
            //ogretmen.Ogrenciler = new Ogrenci[] { ogr, ogr1 };


            //ogr.AdSoyadi = "ali Veli";
            //ogr.DogumYili = 1989;
            //ogr.Cinsiyet = "Emre";
            //ogr.Ogretmen = ogretmen;


            //ogr1.AdSoyadi = "mehmet veli";
            //ogr1.Cinsiyet = "Emre";
            //ogr1.DogumYili = 1990;
            //ogr1.Ogretmen = ogretmen;




            // Console.WriteLine(ogr.BenKimim());
            #endregion

            Yazar yazar = new Yazar()
            {
                Sehir ="Ankara",
                YazarAdi = "Resat Nuri"
            };
            Yazar basYazar = new Yazar()
            {
                Sehir = "Kalbimiz",
                YazarAdi = "M. Kemal Atatürk"
            };
            Yazar yazar1 = new Yazar()
            {
                Sehir="İstanbul",
                YazarAdi = "Can Yücel"
            };

            YayinEvi yayinEvi = new YayinEvi();
            yayinEvi.AdiSoyadi = "MaviBulut Yayin";
            yayinEvi.Adres = "Ankara";

            YayinEvi yayinEvi1 = new YayinEvi()
            {
                AdiSoyadi = "Vektorel Yayin",
                Adres = "İstanbul"
            };

            Raf raf = new Raf()
            {
                KategoriAdi = "Roman",
                Konumu = "Alt-4",
                RenkKodu = "Pembe",
                YetkiliKisisi = "Osman"
            };
            Raf raf2 = new Raf()
            {
                KategoriAdi = "Macera",
                Konumu = "Alt-1",
                RenkKodu = "Mavi",
                YetkiliKisisi = "Emre"
            };

            Kitap kitap = new Kitap()
            {
                KitapAdi = "Çalıkuşu",
                Fiyati = 150,
                SayfaSayisi = 350,
                Yazar = yazar,
                Turu = "Roman",
                YayinEvi = yayinEvi,
                Raf = raf
            };
            Kitap kitap1 = new Kitap()
            {
                KitapAdi = "Simyaci",
                Fiyati = 175,
                SayfaSayisi = 450,
                Yazar = yazar1,
                Turu = "Roman",
                YayinEvi = yayinEvi1,
                Raf = raf2
            };

            Kitap kitap2 = new Kitap()
            {
                KitapAdi = "Babilin En Zengin Adamı",
                Fiyati = 675,
                SayfaSayisi = 550,
                Yazar = yazar1,
                Turu = "Roman",
                YayinEvi = yayinEvi1,
                Raf = raf2
            };

            Kitap kitap3 = new Kitap()
            {
                KitapAdi = "Nutuk",
                Fiyati = 175,
                SayfaSayisi = 550,
                Yazar = basYazar,
                Turu = "Roman",
                YayinEvi = yayinEvi1,
                Raf = raf2
            };

            raf.Kitaplar = new Kitap[] { kitap };
            raf2.Kitaplar = new Kitap[] { kitap1,kitap2,kitap3};

            yazar1.Kitaplar = new Kitap[] { kitap1, kitap2 };
            yazar.Kitaplar = new Kitap[] { kitap };
            basYazar.Kitaplar = new Kitap[] { kitap3 };

            Raf[] raflar = new Raf[] { raf, raf2 };

            // Soru : raftaki 1. kitabın yazarını sehri neresi?

            //Console.WriteLine(raf.Kitaplar[0].Yazar.Sehir);


            Console.WriteLine(kitap3.Kunye());

            // Raflar deki KitapKünyeleri nasıl yazarım ?
            for (int i = 0; i < raflar.Length; i++)
            {
                Console.WriteLine($"{raflar[i].RenkKodu} renkli raftaki kitaplar......");
                for (int j = 0; j < raflar[i].Kitaplar.Length; j++)
                {
                    Console.WriteLine(raflar[i].Kitaplar[j].Kunye());
                }
                Console.WriteLine($"{raflar[i].YetkiliKisisi} Kişisi ile iletişime geçebilirsiniz.");
                Console.WriteLine("-------------");

            }

            /*
             OOP 
             class
             oop ilkeleri
                Encapsulation      
                Inhertance
             

            Yapıcı Methodlar (Constructor.)
             */ 
       }


    }


}
