using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        //contructor injection
        public ProductManager(IProductDal IProductDal)
        {
            _productDal = IProductDal;
        }
        public List<Product> GetAll()
        {
            //iş kodları
            //Bir iş sınıfı, başka sınıfları new'lemez.

            return _productDal.GetAll();

            //InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();

        }
    }
}
