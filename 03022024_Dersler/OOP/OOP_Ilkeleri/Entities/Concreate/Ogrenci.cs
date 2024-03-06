using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;

namespace OOP_Ilkeleri.Entities.Concreate
{
    public class Ogrenci
    {
        // Field
        private string _adSoyadi;
        // Property
        public string AdSoyadi
        {
            get
            {
                return _adSoyadi;
            }
            set
            {

                if (value.Length > 2)
                {
              
                    _adSoyadi = IlkHarfBuyuk(value);
                }
                else
                {
                    throw new Exception("Bir Hata oluştu.");
                }

            }
        }

        private int yas;

        // Read only Property : Yani Bana dışardan bir veri gönderemezsin.
        public int Yas
        {
            get
            {
                return yas;
            }
            private set
            {
                yas= value;
            }
        }


        private string cinsiyet;
        public string Cinsiyet
        {
            get {

                return cinsiyet.Substring(0,1); 
            }


            set
            {
                // gelen ERKEK , ERK , E cinsiyet = Erkek; 
                // gelen KADIN, KDN ,K cinsiyet = Kadin;

                switch (value.ToUpper())
                {
                    case "ERKEK":
                    case "ERK":
                    case "E":
                    case "EMRE":
                        cinsiyet = "Erkek";
                        break;
                    case "KADIN":
                    case "KDN":
                    case "K":
                        cinsiyet = "Kadın";
                        break;
                    default:
                        throw new Exception("Bir Hata Oluştu.");
                        break;
                }

            }
        }

        private int dogumYili;
        public int DogumYili
        {
            get
            {
                return dogumYili;
            }
            set
            {
                if (value>0)
                {
                    dogumYili = value;
                }
                else
                {
                    throw new Exception("Doğum Yılı negatif olamaz.");
                }
                Yas = DateTime.Now.Year - dogumYili;
            }
        }

        // Navigation Property
        public Ogretmen Ogretmen { get; set; }

        private string IlkHarfBuyuk(string deger)
        {

            string ilkBuyukHarf = deger[0].ToString().ToUpper();
            deger = deger.Remove(0, 1);
            deger = deger.Insert(0, ilkBuyukHarf);
            return deger;
        }


        public string BenKimim()
        {
            return $"Merhaba Benim Adim: {_adSoyadi}. {dogumYili} yılında karli bir kiş günü doğdum ve yaşım {yas} ve cinsiyetim {cinsiyet.Substring(0,1)}";
        }


    }
}
