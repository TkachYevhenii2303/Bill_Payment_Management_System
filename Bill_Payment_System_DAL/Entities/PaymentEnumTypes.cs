using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Entities
{
    public enum PaymentEnumTypes
    {
        Cash = 0,

        Checks = 1,
        
        Debit_cards = 2,
        
        Credit_cards = 3,
        
        Mobile_payments = 4,
        
        Electronic_bank_transfers = 5
    }
}
