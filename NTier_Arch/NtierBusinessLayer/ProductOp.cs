using Ntier_DataAccess.Context;
using NtierModel.Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NtierBusinessLayer
{
    public class ProductOp
    {
        // Get ALL - GetbyID - Delete - Update


        public List<Product> GetAll()
        {
            NorthwndContext cnt = new NorthwndContext();
            return cnt.Products.ToList();
        }

    }
}
