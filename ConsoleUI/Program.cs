using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //GetAllCategoryIdTest(productManager);





            //productManager.Add(new Product { ProductName = "Tiryaki Çay", UnitPrice= 34550, CategoryId = 3, UnitsInStock = 45});

          

            GetAllTest(productManager);

        }

        private static void GetAllTest(ProductManager productManager)
        {
            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }
        }

        private static void GetAllCategoryIdTest(ProductManager productManager)
        {
            foreach (var product in productManager.GetAllCategoryId(2).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }






    }
}
