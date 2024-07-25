using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eastwind.DataAccess.Abstract;
using Eastwind.Entities.Concrete;

namespace Eastwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,EastwindContext>,ICategoryDal
    {
    }
}
