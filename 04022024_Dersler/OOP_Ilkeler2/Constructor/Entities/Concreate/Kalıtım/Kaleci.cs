using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Entities.Concreate.Kalıtım
{
    public  class Kaleci : Futbolcu 
    {

        public int TopTutmaYetegi { get; set; }
        public string Refleks { get; set; }


        public  void DegajYap()
        {
            Console.WriteLine("Oyun Başlasın.");
        }
        public void TopYakala()
        {
            Console.WriteLine("Top Tuttum.");
        }
    }
}
