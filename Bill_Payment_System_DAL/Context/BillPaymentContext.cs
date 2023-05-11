using Bill_Payment_System_DAL.Bogus_Generator;
using Bill_Payment_System_DAL.Entities;
using Bill_Payment_System_DAL.Fluent_Validations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Context
{
    public class BillPaymentContext : DbContext
    {
        public BillPaymentContext(DbContextOptions<BillPaymentContext> options) : base(options) { }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<PaymentMethods> PaymentMethods { get; set; }

        public DbSet<CreditCards> CreditCards { get; set; }

        public DbSet<BankAccounts> BankAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            BogusSeeding.Seeding();

            modelBuilder.Entity<Customers>().HasData(BogusSeeding.Customers);

            modelBuilder.Entity<BankAccounts>().HasData(BogusSeeding.BankAccounts);

            modelBuilder.Entity<CreditCards>().HasData(BogusSeeding.CreditCards);

            modelBuilder.Entity<PaymentMethods>().HasData(BogusSeeding.PaymentMethods);
        }
    }
}
