using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eastwind.Business.ValidationRules.FluentValidation;
using Eastwind.Entities.Concrete;
using FluentValidation;

namespace Eastwind.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            //ITS THE OLD VERSION OF FLUENT VALIDATION
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }

            //FOR NEW VERSION

            //public static class ValidationTool
            //{
            //    public static void Validate(IValidator validator, object entity)
            //    {
            //        // Create a ValidationContext for the entity
            //        var context = new ValidationContext<object>(entity);

            //        // Validate the entity using the context
            //        ValidationResult result = validator.Validate(context);
            //        if (result.Errors.Count > 0)
            //        {
            //            throw new ValidationException(result.Errors);
            //        }
            //    }
            //}
        }
    }
}
