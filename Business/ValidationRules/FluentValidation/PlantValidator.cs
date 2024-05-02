using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PlantValidator : AbstractValidator<Plant>
    {
        public PlantValidator()
        {
            RuleFor(p => p.PowerPlantName).MinimumLength(2);
            RuleFor(p => p.PowerPlantName).NotEmpty();
            RuleFor(p => p.City).MinimumLength(2);
            RuleFor(p => p.PowerPlantPower).NotEmpty();

        }
    }
}
