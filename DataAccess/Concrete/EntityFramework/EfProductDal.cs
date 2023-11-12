using DataAccess.Abstracts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //bir class'ı newlediğinde garbage collector belirli bir zamanda gelir ve atar.
            //using içerisinde yazılan nesneler using bittiğinde garbage collector'a gelir.
            //IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                //karşısına hangi veri tipi gelirse onu tutan değişken anahtarı.
                var addedEntity = context.Entry(entity);
                //State = durum;
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //karşısına hangi veri tipi gelirse onu tutan değişken anahtarı.
                var deletedEntity = context.Entry(entity);
                //State = durum;
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //karşısına hangi veri tipi gelirse onu tutan değişken anahtarı.
                var updatedEntity = context.Entry(entity);
                //State = durum;
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
