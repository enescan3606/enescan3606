using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Entities.Concreate.Kalıtım
{
    public class Futbolcu
    {
        public string AdiSoyadi { get; set; }
        public string FormaNumarasi { get; set; }
        public int Boyu { get; set; }
        public int Yas { get; set; }
        public int Kilo { get; set; }
        public string Uyrugu { get; set; }


        public void PasVer()
        {
            Console.WriteLine("Top Gönderdim!!");
        }
        public void SutCek()
        {
            Console.WriteLine("Şut Çektim..");
        }
    }
}
