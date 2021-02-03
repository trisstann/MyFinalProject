using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        void Add(Product entity);
        void Delete(Product entity);
        Product Get(Expression<Func<Product, bool>> filter);
        Product GetAll(Expression<Func<Product, bool>> filter = null);
        void UpDate(Product entity);
    }
}
