using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Constructor.Entities.Concreate
{
    public class Test
    {
        public Test()
        {

        }
        public Test(int sayisal)
        {
            Sayisal = sayisal;
        }
        public Test(string metinsel)
        {
            Metinsel = metinsel;
        }
        public Test(int sayisal,string metinsel)
        {
            Sayisal = sayisal;
            Metinsel= metinsel;
        }


        public int Sayisal { get; set; }
        public string Metinsel { get; set; }
    }
}
