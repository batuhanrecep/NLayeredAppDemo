using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eastwind.Business.Abstract;
using Eastwind.Business.Utilities;
using Eastwind.Business.ValidationRules.FluentValidation;
using Eastwind.DataAccess.Abstract;
using Eastwind.DataAccess.Concrete.EntityFramework;
using Eastwind.Entities.Concrete;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

namespace Eastwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        //As a best practice, one layer should not use new statement for another 

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business Code

            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {

            try
            {
                _productDal.Delete(product);
            }
            catch 
            {
                throw new Exception("Update is not available for now");
            }
        }
    }
}
