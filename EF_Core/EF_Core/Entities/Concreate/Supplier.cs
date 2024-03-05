using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.Entities.Concreate
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
    }
}
