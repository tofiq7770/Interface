using Domain.Models;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
        public class ProductService : IProduct
        {

            private Category[] categories;
            private int productCount = 0;

            private Product[] products;

            public ProductService()
            {
                categories = new Category[]
                {
            new Category { Id = 1, Name = "Android" },
            new Category { Id = 2, Name = "IOS" },
            new Category { Id = 3, Name = "Smartphone" },
                };

                products = GetProducts();
            }

            private Product[] GetProducts()
            {
                return new Product[]
                {
            new Product { Id = 1, Name = "Iphone", Price = 5000, CreatedDate = new DateTime(2001, 10, 7), Category = categories[1] },
            new Product { Id = 2, Name = "Samsung", Price = 2500, CreatedDate = new DateTime(2023, 10, 9), Category = categories[0] },
            new Product { Id = 3, Name = "Xiaomi", Price = 500, CreatedDate = new DateTime(2023, 10, 9), Category = categories[2] },
            new Product { Id = 4, Name = "SamsungS23", Price = 4000, CreatedDate = new DateTime(2022, 11, 6), Category = categories[0] },
            new Product { Id = 5, Name = "Nokia", Price = 100, CreatedDate = new DateTime(2019, 7, 15), Category = categories[2] },
            new Product { Id = 6, Name = "Iphone13Pro", Price = 3000, CreatedDate = new DateTime(2021, 10, 10), Category = categories[1] },
            new Product { Id = 7, Name = "SamsungA10", Price = 700, CreatedDate = new DateTime(2015, 7, 22), Category = categories[0] },
            new Product { Id = 8, Name = "Iphone14", Price = 1700, CreatedDate = new DateTime(2015, 7, 22), Category = categories[1] },
            new Product { Id = 9, Name = "Iphone15", Price = 2700, CreatedDate = new DateTime(2015, 7, 22), Category = categories[1] },
            new Product { Id = 10, Name = "Iphone12pm", Price = 1300, CreatedDate = new DateTime(2015, 7, 22), Category = categories[1] },
            
                };
            }


            public Product[] GetAll()
            {
                return GetProducts();
            }

          Product[] IProduct.GetCountOfProduct()
            {
                Product[] products = GetAll();
                return products;
            }

            Product[] IProduct.SortName(string productname)
            {
                Product[] product = GetAll();
                return product.Where(x => x.Name == productname).ToArray();
            }
         Product[] IProduct.SortByDateTime()
            {
                Product[] product = GetAll();
                return product.OrderByDescending(x => x.CreatedDate).ToArray();
            }
       

    }
    
}
