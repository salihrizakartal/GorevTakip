using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class TestValidator : AbstractValidator<Test>
    {
        public TestValidator()
        {
            RuleFor(t => t.TestName).MinimumLength(2);
            RuleFor(t => t.TestName).NotEmpty();
            

        }
    }
}
