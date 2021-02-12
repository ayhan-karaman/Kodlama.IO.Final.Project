using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Delete(Product product)
        {
            var deleteProduct =_productDal.Get(p=>p.ProductId == product.ProductId);
            _productDal.Delete(deleteProduct);
            return new SuccessResult(Messages.ProductDelete);

        }
        public IResult Add(Product product)
        {

            if (product.ProductName.Length < 2)
            {
                return new ErrorResult("Ürün ismi en az iki karakter olmalı");
            }
            else
            {
                _productDal.Add(product);
                return new SuccessResult(Messages.ProductDelete);
            }
            

        }

        public IDataResult <List<Product>> GetAll()
        {
           
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductList);
        }

        public IDataResult<List<Product>> GetAllCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
            
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>( _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public  IDataResult <List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>( _productDal.GetProductDetails());
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult <Product> (_productDal.Get(p => p.ProductId == productId));
        }
    }
}
