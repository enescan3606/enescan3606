using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Constructor.Entities.Concreate.Kalıtım
{
    public class Defans : Futbolcu
    {
        public int TopCalmaYetenegi { get; set; }
        public void HavaTopHakimiyeti()
        {
            Console.WriteLine("Kafayi Vurdum");

        }
        public void PressYap()
        {
            Console.WriteLine("Press Yapıyorum.");
        }

    }
}
