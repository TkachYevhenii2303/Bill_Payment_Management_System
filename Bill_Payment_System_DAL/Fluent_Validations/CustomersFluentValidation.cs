using Bill_Payment_System_DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Fluent_Validations
{
    internal class CustomersFluentValidation : AbstractValidator<Customers>
    {
        public CustomersFluentValidation() 
        {
            RuleFor(x => x.Name).NotNull().MaximumLength(255).WithMessage("The Customer's name cann't be more than 255 characters!!!");

            RuleFor(x => x.Email).Empty().EmailAddress();

            RuleFor(x => x.Password).NotNull().WithMessage("The Password cann't be null or empty!!!")
                
                .MinimumLength(10).WithMessage("The Password cann't less than 10 characters!!!")

                .MaximumLength(250).WithMessage("The Password cann't more than 250 characters!!!")
                
                .Matches(@"[A-Z]+").WithMessage("Your Password must contain at least one uppercase letter!!!")
                
                .Matches(@"[a-z]+").WithMessage("Your Password must contain at least one lowercase letter!!!")
                
                .Matches(@"[0-9]+").WithMessage("Your Password must contain at least one number!!!");
        }   
    }
}
