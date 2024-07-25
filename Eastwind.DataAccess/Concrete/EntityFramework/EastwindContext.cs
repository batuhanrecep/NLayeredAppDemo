using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eastwind.Entities.Concrete;

namespace Eastwind.DataAccess.Concrete.EntityFramework
{
    public class EastwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
