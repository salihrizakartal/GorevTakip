using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EmplyoeeValidator : AbstractValidator<Emplyoee>
    {
        public EmplyoeeValidator()
        {
            RuleFor(e => e.EmplyoeeName).MinimumLength(2);
            RuleFor(e => e.EmplyoeeName).NotEmpty();
           
          

        }

       
    }
}
