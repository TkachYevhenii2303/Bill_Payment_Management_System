using Bill_Payment_System_DAL.Fluent_Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Entities
{
    public class CreditCards : BaseEntity
    {
        public DateTime ExpirationDate { get; set; } 

        public decimal Limit { get; set; }

        public bool MoneyOwned { get; set; } = false;

        public PaymentMethods? PaymentMethods { get; set; }
    }
}
