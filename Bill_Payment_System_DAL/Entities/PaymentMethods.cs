using Bill_Payment_System_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Fluent_Validations
{
    public class PaymentMethods : BaseEntity
    {
        public PaymentEnumTypes PaymentTypes { get; set; } = PaymentEnumTypes.Cash;

        public Customers Customers { get; set; } = null!;

        public Guid CustomersId { get; set; }

        public BankAccounts BankAccounts { get; set; } = null!;

        public Guid BankAccountsId { get; set; }

        public CreditCards CreditCards { get; set; } = null!;

        public Guid CreditCardsId { get; set; }
    }
}
