using NtierBusinessLayer;
using System;

namespace NTier_Arch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductOp op = new ProductOp();
            var products = op.GetAll();
        }
    }
}
