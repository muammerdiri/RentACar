using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator: AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnTime).NotEmpty();
            RuleFor(r => r.RentDate).Must(RentDateProtect);
            RuleFor(r => r.ReturnTime).Must(ReturnTimeProtect);
        }

        private static bool RentDateProtect(DateTime rentDate)
        {
            var date = DateTime.Now;
            
            return rentDate<date ;
        }
        private static bool ReturnTimeProtect(DateTime returnTime)
        {
            var date = DateTime.Now;

            return returnTime < date;
        }

    }



}
