using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eastwind.DataAccess.Abstract;
using Eastwind.Entities.Concrete;

namespace Eastwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            using (EastwindContext context=new EastwindContext())
            {
                return context.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (EastwindContext context = new EastwindContext())
            {
                return context.Products.SingleOrDefault(p=>p.ProductId==id);
            }
        }

        public void Add(Product product)
        {
            using (EastwindContext context = new EastwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();

            }
        }
        public void Update(Product product)
        {
            using (EastwindContext context = new EastwindContext())
            {
                
                context.SaveChanges();

            }
        }
        public void Delete(Product product)
        {
            using (EastwindContext context = new EastwindContext())
            {

                context.SaveChanges();

            }
        }
    }
}
