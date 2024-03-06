using Constructor.Entities.Concreate;
using Constructor.Entities.Concreate.Kalıtım;
using Constructor.Entities.Concreate.Kalıtım2;
using System;
using System.Net.Http.Headers;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 01

            //Test test = new Test(52);
            //test.Sayisal = 53;
            //Test test1 = new Test("MerhabaDünya");
            //Test test2 = new Test(35,"MerhabaDünya");

            //Test testDef = new Test();
            //Yazar y = new Yazar();
            //y.YazarAdi ="R.N.G";

            //Kitap kitap = new Kitap()
            //{

            //    KitapAdi = "Nutuk",
            //    SayfaSayisi = 550,
            //    Fiyati = 150,
            //    Turu = "Söylev"
            //};


            //Kitap kitap1 = new Kitap(y,"Çalıkuşu", "Roman", 350, 125);

            //Console.WriteLine(kitap1.KitapAdi);
            //Console.WriteLine(kitap1.SayfaSayisi);
            //Console.WriteLine(kitap1.Turu);
            //Console.WriteLine(kitap1.Fiyati);

            //test.Sayisal = 52;

            #endregion

            var kaleci = new Kaleci() { AdiSoyadi ="K1",Boyu=180,Kilo=75,FormaNumarasi="99",Refleks="Kuvvetli",TopTutmaYetegi=99,Uyrugu="TC",Yas=32};
            var def1 = new Defans() { AdiSoyadi="D1",Boyu=185,FormaNumarasi="95",Kilo=100,TopCalmaYetenegi=95,Uyrugu="TC",Yas=23};
            var ort1 = new OrtaSaha() { AdiSoyadi="O1",Boyu=195,FormaNumarasi="12",KanatOyuncusuMu="Hayır",Kilo=75,OyunKurmaYetenegi=95,Uyrugu="TC",Yas=45};
            var frv1 = new Forvet() { AdiSoyadi = "F1", Boyu = 195, FormaNumarasi = "15",Bitiricilik=99,Kilo=75,Uyrugu="TC",Yas=25 };


            Futbolcu[] takim = new Futbolcu[4]
            {
               kaleci,
               def1,
               ort1,
               frv1
              
            };

            for (int i = 0; i < takim.Length; i++)
            {
                Console.WriteLine($"{takim[i].AdiSoyadi} - Forma Numarası : {takim[i].FormaNumarasi} ");

                if (takim[i] is Kaleci)
                {
                    Console.WriteLine($" Top Tutma Yeteneği : {(takim[i] as Kaleci).TopTutmaYetegi}");

                }
                else if (takim[i] is Defans)
                {
                    Console.WriteLine($" Top Çalma Yeteneği : {(takim[i] as Defans).TopCalmaYetenegi}");

                }
                else if (takim[i] is OrtaSaha)
                {
                    Console.WriteLine($" Oyun Kurma Yeteneği : {(takim[i] as OrtaSaha).OyunKurmaYetenegi}");

                }
                else if (takim[i] is Forvet)
                {
                    Console.WriteLine($" Bitiricilik Yeteneği : {(takim[i] as Forvet).Bitiricilik}");
                }
                Console.WriteLine("----------");
            }

            AkilliTelefon a = new iOSTelefon();
            iOSTelefon akilliTelefon = new iOSTelefon();
            AndriodTelefon akilliTelefon1 = new AndriodTelefon();
            






        }

    }
}
