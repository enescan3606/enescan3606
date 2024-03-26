using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor.Entities.Concreate.Kalıtım
{
    public class Forvet : Futbolcu
    {
        public int  Bitiricilik { get; set; }

        public void GolAt()
        {
            Console.WriteLine("Şut ve Gol");
        }

    }
}
