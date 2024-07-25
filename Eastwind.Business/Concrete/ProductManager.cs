using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eastwind.DataAccess.Concrete;
using Eastwind.Entities.Concrete;

namespace Eastwind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();
        public List<Product> GetAll()
        {
            //Business Code

            return _productDal.GetAll();
        }
    }
}
