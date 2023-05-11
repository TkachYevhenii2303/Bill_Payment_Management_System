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
    internal class PaymentsMethodsConfigurations : IEntityTypeConfiguration<PaymentMethods>
    {
        public void Configure(EntityTypeBuilder<PaymentMethods> builder)
        {
            builder
                .HasOne(e => e.BankAccounts)
                .WithOne(e => e.PaymentMethods)
                .HasForeignKey<PaymentMethods>(fk => fk.BankAccountsId)
                .IsRequired();

            builder
                .HasOne(e => e.CreditCards)
                .WithOne(e => e.PaymentMethods)
                .HasForeignKey<PaymentMethods>(fk => fk.CreditCardsId)
                .IsRequired();
        }
    }
}
