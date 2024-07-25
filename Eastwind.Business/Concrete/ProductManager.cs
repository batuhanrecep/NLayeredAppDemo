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
        //As a best practice, one layer should not use new statement for another 
        
        ProductDal _productDal = new ProductDal();
        public List<Product> GetAll()
        {
            //Business Code

            return _productDal.GetAll();
        }
    }
}
