using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Entities.Concreate.Kalıtım2
{
    public class Telefon
    {
        public string Arama { get; set; }
        public string SMS { get; set; }
        public string SarjTipi { get; set; }

        public void Ara(string telNo)
        {
            Console.WriteLine($"{telNo} aranıyor...");
        }
        public void Cal()
        {
            Console.WriteLine("Ring ring");
        }
    }
}
