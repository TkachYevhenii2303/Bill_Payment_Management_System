using Bill_Payment_System_DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Fluent_Validations
{
    internal class CreditCardsFluentValidation : AbstractValidator<CreditCards>
    {
        public CreditCardsFluentValidation() 
        {
            RuleFor(x => x.ExpirationDate).Must(CurrentDateValidation).WithMessage("The Expiration Date must be less than today!!!");
        }

        private bool CurrentDateValidation(DateTime expirationDate)
        {
            return DateTime.Compare(DateTime.Now, expirationDate) < 0 ? true : false;
        }
    }
}
