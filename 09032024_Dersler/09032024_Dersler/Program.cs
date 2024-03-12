using _09032024_Dersler.Entities.Concreate;
using System;
using System.Data.SqlClient;

namespace _09032024_Dersler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            ////Urun urun = 

            //Kola lekola = new Kola();

            //Cikolata ciko = new Cikolata();

            //Urun urun = new Kola();

            //lekola.UrunBilgileri();
            //ciko.UrunBilgileri();

            //Arac a = new Arac();

            //Lassa123 s1 = new Lassa123();
            //Petlas321 s2 = new Petlas321();
            //Lassa123 s3 = new Lassa123();
            //Petlas321 s4 = new Petlas321();

            //ITekerlek t = new Lassa123();

            //a.TekerlekTak(s1);
            //a.TekerlekTak(s2);
            //a.TekerlekTak(s3);
            //a.TekerlekTak(s4);



            #region Exception Handling (Hata Yönetimi)

            try
            {

                //MyException my = new MyException();
                Console.WriteLine("1. Sayi Giriniz :");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("2. Sayi Giriniz :");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
           
                Console.WriteLine("-----------");



            }

            catch (Exception my)
            {
                Console.WriteLine("bir hata oluştu.......");
                // Hatayı Log .... 
                Console.WriteLine($"{my.Message}\n Trace : {my.StackTrace} \n InnerMessage . {my.InnerException} ");

            }
            SqlConnection conn = new SqlConnection();
            try
            {

                
                conn.ConnectionString = @"Server=LAB8-OGRETMEN\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True";
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select ProductName From Products", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}",reader[0]);
                    }
                }           
              
            }
            catch (Exception ex)
            {
                // Veritabanı kapatırım
                // Loglama
                
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                conn.Close();

            }

            #endregion
        }



    }
    #region Abstract

    //abstract class Urun
    //{


    //    public string Adi { get; set; }
    //    public string STarihi { get; set; }
    //    public int Fiyati { get; set; }
    //    public int Gramaj { get; set; }
    //    public string Paketlenme { get; set; }

    //    public abstract void UrunBilgileri();
    //}
    abstract class Urun
    {

        public string Adi { get; set; }
        public string STarihi { get; set; }
        public int Fiyati { get; set; }
        public int Gramaj { get; set; }
        public virtual string Paketlenme { get; set; }

        public virtual void UrunBilgileri()
        {
            Console.WriteLine("Urun Bilgileri Virtual.");
        }
    }

    class Cikolata : Urun
    {
        public Cikolata()
        {

        }
        public Cikolata(int kOrani)
        {
            KakaoOrani = kOrani;
        }
        public int KakaoOrani { get; set; }
        public override string Paketlenme { get; set; }
        public override void UrunBilgileri()
        {
            Console.WriteLine("Benim Dediğim Olsun.");
        }
    }

    class Kola : Urun
    {
        public int SekerOrani { get; set; }


    }
    #endregion

    class Arac
    {
        public int KapiSayisi { get; set; }
        public string Marka { get; set; }
        public string Renk { get; set; }


        public void GazaBas()
        {


        }

        public void TekerlekTak(Tekerlek tekerlek)
        {
            Console.WriteLine("Tekerlek Takıldı.");
        }


    }


    interface ITekerlek
    {
        int BijonSayisi { get; set; }
        int TabanGenisligi { get; set; }
        int YanakGenisligi { get; set; }

        void DonmeSayisi();


    }

    class Tekerlek : ITekerlek
    {
        public int BijonSayisi { get; set; }
        public int TabanGenisligi { get; set; }
        public int YanakGenisligi { get; set; }

        public void DonmeSayisi()
        {
            throw new NotImplementedException();
        }
    }
    class Lassa123 : Tekerlek, ITekerlek
    {

    }

    class Petlas321 : Tekerlek, ITekerlek
    {

    }



}
