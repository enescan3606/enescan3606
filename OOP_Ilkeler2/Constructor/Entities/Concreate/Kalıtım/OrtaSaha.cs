using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Entities.Concreate.Kalıtım
{
    public class OrtaSaha:Futbolcu
    {
        public int OyunKurmaYetenegi { get; set; }
        public string KanatOyuncusuMu{ get; set; }
    
        public void OynKur()
        {
            Console.WriteLine("Oyunu Kurdum");
        }
        public void TopCal()
        {
            Console.WriteLine("Topu çaldım");

        }
    }
}
