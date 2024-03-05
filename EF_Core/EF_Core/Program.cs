using EF_Core.Context;
using EF_Core.Entities.Concreate;
using EF_Core.Entities.Concreate.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Product> p = new List<Product>();
            //var x = 10;
            //var y = "merhaba";
            //var z = p;


            NorthwndContext cnt = new NorthwndContext();
            var products = cnt.Products.ToList();

            foreach (var item in products)
            {
                Console.WriteLine($"{item.ProductId}");
                Console.WriteLine($"{item.ProductName}");
                Console.WriteLine("--------------");
            }

            //var products = cnt.Products.Where(x => x.ProductId > 5).ToList();

            //var products = cnt.Products.Where(x => x.UnitPrice > 10 && x.UnitsInStock < 5).ToList();

            //var products = cnt.Products
            //                .Where(p => p.UnitPrice > 15)
            //                .OrderBy(P => P.UnitPrice)
            //                .ThenBy(p => p.UnitsInStock)
            //                .ThenBy(p => p.Discontinued)
            //                .ThenByDescending(p => p.ProductId)
            //                .ThenByDescending(p => p.ProductName)
            //                .ToList();
            //var products = cnt.Products.ToList();


            //if (products.Count()>0)
            //{
            //    var rowCount = 10;

            //    var count = products.Count();

            //    var totalPageNumber = Math.Ceiling((decimal)count / rowCount);
            //    for (int i = 1; i <= totalPageNumber; i++)
            //    {
            //        //int pageNumber = i; // Sayfa Numarası
            //        // Toplam Kaç satır veri sayfada gözükecek


            //        var partialListe = products.OrderBy(x => x.ProductId)
            //                .Skip((i - 1) * rowCount)
            //                .Take(rowCount)
            //                .ToList();


            //        foreach (var item in partialListe)
            //        {
            //            Console.WriteLine($"{item.ProductId} - {item.ProductName}");

            //        }
            //        Console.WriteLine("--------------------");
            //        Console.WriteLine($"Toplam {products.Count()}  Kayıt içinde {i}. sayfayı görüntülemektesiniz.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Kayıt Bulunamadı.");
            //}



            //var min = cnt.Products.Min(p => p.UnitPrice);
            //var max = cnt.Products.Max(p => p.UnitPrice);
            //var total = cnt.Products.Sum(p => p.UnitPrice);
            //var avg = cnt.Products.Average(p => p.UnitPrice);

            //Console.WriteLine($"Min {min} - Max {max} - Total {total} - Average {avg}");

            // Product ID = 2 olan ürünü bulalım.

            //var products = cnt.Products.Where(p=>p.ProductId == 2).ToList();
            //var product = cnt.Products.SingleOrDefault(p => p.ProductId == 2);

            //if (product != null)
            //{
            //    Console.WriteLine($"{product.ProductId} - {product.ProductName}");
            //}
            //else
            //{
            //    Console.WriteLine("Böyle Bir Ürün Bulunamadı...");
            //}

            //var product = cnt.Products.FirstOrDefault(p => p.UnitPrice > 25);
            //var products = cnt.Products
            //                    .Include("Category")
            //                    .Include("Supplier")
            //                    .Select(x => new
            //                    {
            //                        UrunAdi = x.ProductName,
            //                        Kategori = x.Category.CategoryName,
            //                        Tedarikci = x.Supplier.CompanyName
            //                    }).ToList();


            #region Anonymous Type  (isimsiz Tipler)

            var prd = new
            {
                UrunAdi = "Elma",
                Fiyati = 15,
                Stok = 30
            };


            #endregion
            //var products = cnt.Products
            //          .Include("Category")
            //          .Include("Supplier")
            //          .Select(x => new ProductInfoDto
            //          {
            //              UrunAdi = x.ProductName,
            //              Kategori = x.Category.CategoryName,
            //              Tedarikci = x.Supplier.CompanyName
            //          }).ToList();

            //var result = cnt.Suppliers.GroupBy(x => x.Country)
            //                .Select(grp => new
            //                {
            //                    Ulke = grp.Key,
            //                    Adet = grp.Count()
            //                }).ToList();


            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.Ulke} - {item.Adet} ");
            //}


            //var result2 = cnt.Products.Include("Supplier")
            //    .GroupBy(x => x.Supplier.CompanyName)
            //    .Select(grp => new
            //    {
            //        Tedarikci = grp.Key,
            //        Adet = grp.Count()
            //    }).ToList(); 

            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.Tedarikci} - {item.Adet} ");
            //}






            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductId} - {item.ProductName}  -  {item.Category.CategoryName} - {item.Supplier.CompanyName}");

            //}


            //Product newProduct = new Product()
            //{
            //    ProductName = "Elma",
            //    UnitPrice = 10,
            //    UnitsInStock=15,
            //    CategoryId=1,
            //    SupplierId =2
            //};
            //cnt.Products.Add(newProduct);
            //cnt.SaveChanges();


        }
    }
}
