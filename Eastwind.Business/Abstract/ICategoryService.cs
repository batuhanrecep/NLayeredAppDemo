﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eastwind.Entities.Concrete;

namespace Eastwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
