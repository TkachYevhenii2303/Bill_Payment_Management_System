using Bill_Payment_System_DAL.Fluent_Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Entities
{
    public class Customers : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string Password { get; set; } = string.Empty;

        public ICollection<PaymentMethods> PaymentMethods { get; set; } = null!;
    }
}
