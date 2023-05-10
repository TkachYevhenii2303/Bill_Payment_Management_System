using Bill_Payment_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DATA.Configurations
{
    internal class CustomersConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder
                .HasMany(x => x.PaymentMethods)
                .WithOne(e => e.Customers)
                .HasForeignKey(fk => fk.CustomersId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
