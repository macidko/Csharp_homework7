using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts

{    //Dal, dao
    public interface IProductDal
    {
        List<Product> GetAll(); //Hepsini getir.
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);


        List<Product> GetAllByCategory(int categoryId);
    }
}
