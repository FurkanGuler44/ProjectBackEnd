using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using (var context = new ProjectDbContext())
            {
                return context.Set<Product>().ToList();
            }
        }
    }
}
