using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Fluent_Validations
{
    internal class PaymentMethodsFluentValidation : AbstractValidator<PaymentMethods>
    {
        public PaymentMethodsFluentValidation() { }
    }
}
