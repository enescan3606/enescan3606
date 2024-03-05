using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.Entities.Concreate.Dtos
{
    // Dto : Database Transfer Object

    public class ProductInfoDto
    {
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public string Tedarikci { get; set; }
    }
}
