using Bill_Payment_System_DAL.Fluent_Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Entities
{
    public class BankAccounts : BaseEntity
    {
        public string BankTitle { get; set; } = string.Empty;

        public decimal Balance { get; set; }

        public string SwithCode { get; set; } = string.Empty;

        public PaymentMethods? PaymentMethods { get; set; }
    }
}
