using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //injektion
       IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları yazılır.
            // bir iş sınıf başka sınıfları newlemez. injektion yapılır. 
            //InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal();  xxxx
           
            return _productDal.GetAll();
          
        }

        public List<Product> GetAllByCategoryId(int Id)
        {
            return _productDal.GetAll(p => p.CategoryId == Id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p =>p.UnitPrice>=min && p.UnitPrice
            <=max);
        }
    }
}
