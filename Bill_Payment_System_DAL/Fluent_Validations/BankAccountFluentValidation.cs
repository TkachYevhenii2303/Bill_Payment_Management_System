using Bill_Payment_System_DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Fluent_Validations
{
    internal class BankAccountFluentValidation : AbstractValidator<BankAccounts>
    {
        public BankAccountFluentValidation()
        {
            RuleFor(x => x.BankTitle).NotNull().MaximumLength(255).WithMessage("The Bank's title must be less than 255 characters!!!");
        }
    }
}
