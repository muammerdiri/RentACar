using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageRules:AbstractValidator<CarImage>
    {
        public CarImageRules()
        {
            RuleFor(c => c.ImagePath).NotEmpty();
            RuleFor(c => c.CarId).NotEmpty();
        }
    }
}
