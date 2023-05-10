using Bill_Payment_System_DAL.Entities;
using Bill_Payment_System_DAL.Fluent_Validations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Configurations
{
    internal class BankAccountConfiguration : IEntityTypeConfiguration<BankAccounts>
    {
        public void Configure(EntityTypeBuilder<BankAccounts> builder)
        {
            builder
                .HasOne<PaymentMethods>(x => x.PaymentMethods)
                .WithOne(x => x.BankAccounts)
                .HasForeignKey<PaymentMethods>(x => x.BankAccountId);
        }
    }
}
