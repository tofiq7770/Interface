using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Service;
using Domain.Models;

namespace Interface
{
    internal class ProductController
    {

        private readonly IProduct product;
        public ProductController()
        {
            product = new ProductService();
        }

        public void ShowProducts()
        {
            Product[] products = product.GetAll();
            foreach (Product product in products)
            {
                Console.WriteLine($"{ product.Name } { product.Price} {product.Category.Name} {product.CreatedDate}");
            }
        }
        public void ShowCategory()
        {
        }

        public int CountOfProduct()
        {
            Product[] products = product.GetAll();
            int count = 0;
            for (int i = 0; i < products.Length; i++)
            {
                count++;
            }
            return count;
        }
        public void AveragePrice()
        {
            Product[] products = product.GetAll();
            int avg = 1;
            int count = 0;
            for (int i = 0; i < products.Length; i++)
            {
                count++;
            }
            foreach (Product product in products)
            {
                avg += product.Price;

            }
            avg /= count;
            Console.WriteLine(avg);
        }

        public void ShowProductByName()
        {
            Console.WriteLine("Enter Product Name");
            string productname = Console.ReadLine();
            Product[] products = product.GetAll();
            foreach (Product product in products)
            {
                if (product.Name == productname)
                {
                    Console.WriteLine($"{product.Id}  {product.Name}  {product.Price}  {product.Category.Name}  ");
                }
            }

        }

        public void ShowProductByDate()
        {
            string productname = Console.ReadLine();

            Product[] products = product.GetAll();

            foreach (Product product in products)
            {
            }

        }
        public void SortProductsByCreationDate()
        {

            Product[] products = product.GetAll();
            Product[] existingProducts = products.Where(p => p != null).ToArray();
            Array.Sort(existingProducts, (p1, p2) => p1.CreatedDate.CompareTo(p2.CreatedDate));

            for (int i = 0; i < existingProducts.Length; i++)
            {
                products[i] = existingProducts[i];
                Console.WriteLine($"{ products[i].Name} - { products[i].CreatedDate}");
            }
        }
        public void GetProductsByCategories()
        {
            string categoryText =Console.ReadLine();
            Product[] products = product.GetAll();
            Console.WriteLine(products.Where(p => p != null && p.Category.Name.Equals(categoryText)).ToArray());
        } 

        public void GetProductsByCategoryId()
        {
            int categoryId=int.Parse(Console.ReadLine());
            Product[] products = product.GetAll();
            Console.WriteLine(products.Where(p => p != null && p.Category.Id == categoryId).ToArray());
        }
    }
}
