using FluentValidation;
using RestaurantAlimentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAlimentos.Validation
{
    public class CustomerValidator:AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().Length(2, 20)
                .WithMessage("Please Provide a Valid {PropertyName}")
                .Must(RuleHelperForValidation.BeAValidName).WithMessage("Please enter a valid {PropertyName}");

            RuleFor(p => p.LastName)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().Length(2, 20)
               .WithMessage("Please Provide a Valid {PropertyName}")
               .Must(RuleHelperForValidation.BeAValidName).WithMessage("Please enter a valid {PropertyName}");

            RuleFor(p => p.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().Length(10, 10)
                .Must(RuleHelperForValidation.BeAValidPhoneNumber).WithMessage("Please enter a valid Phone Number");

            RuleFor(p => p.Date)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Must(RuleHelperForValidation.BeAValidDay).WithMessage("Please enter a valid day");
        }
    }
}
