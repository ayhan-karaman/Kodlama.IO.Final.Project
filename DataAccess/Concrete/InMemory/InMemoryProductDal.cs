using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 2, ProductName = "Ütü", UnitPrice = 200, UnitsInStock = 32},
                new Product{ProductId = 2, CategoryId = 2, ProductName = "Blender", UnitPrice = 180, UnitsInStock = 52},
                new Product{ProductId = 3, CategoryId = 3, ProductName = "Bardak", UnitPrice = 20, UnitsInStock = 60},
                new Product{ProductId = 4, CategoryId = 3, ProductName = "Vazo", UnitPrice = 21, UnitsInStock = 28},
                new Product{ProductId = 5, CategoryId = 7, ProductName = "Telefon", UnitPrice = 4200, UnitsInStock = 12}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
