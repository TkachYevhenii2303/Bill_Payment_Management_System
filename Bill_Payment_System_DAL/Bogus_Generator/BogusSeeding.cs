using Bill_Payment_System_DAL.Entities;
using Bill_Payment_System_DAL.Fluent_Validations;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Bogus_Generator
{
    public static class BogusSeeding
    {
        public static List<Customers> Customers { get; set; } = new();

        public static List<BankAccounts> BankAccounts { get; set; } = new();
        
        public static List<CreditCards> CreditCards { get; set; } = new();  
        
        public static List<PaymentMethods> PaymentMethods { get; set; } = new();

        private const int CUSTOMER = 100;
        private const int BANKS_ACCOUNTS = 50;
        private const int CREDIT_CARDS = 50;
        private const int PAYMENTS = 50;

        public static void Seeding()
        {
            Customers = new Faker<Customers>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Email, (f, o) => f.Internet.Email(o.Name))
                .RuleFor(x => x.Password, f => f.Internet.Password())
                .Generate(CUSTOMER);

            BankAccounts = new Faker<BankAccounts>()
                .RuleFor(x => x.BankTitle, f => f.Company.CompanyName())
                .RuleFor(x => x.Balance, f => f.Finance.Amount())
                .RuleFor(x => x.SwithCode, f => f.Finance.CreditCardCvv())
                .Generate(BANKS_ACCOUNTS);

            CreditCards = new Faker<CreditCards>()
                .RuleFor(x => x.ExpirationDate, f => f.Date.Future())
                .RuleFor(x => x.Limit, f => f.Finance.Amount())
                .RuleFor(x => x.MoneyOwned, f => f.Random.Bool())
                .Generate(CREDIT_CARDS);

            var bankAccountsId = BankAccounts.Select(x => x.ID).ToList();

            var creditCardsId = CreditCards.Select(x => x.ID).ToList();

            PaymentMethods = new Faker<PaymentMethods>()
                .RuleFor(x => x.PaymentTypes, f => f.PickRandom<PaymentEnumTypes>())
                .RuleFor(x => x.CustomersId, f => f.PickRandom(Customers).ID)
                .Generate(PAYMENTS);

            for (int i = 0; i < PaymentMethods.Count; i++)
            {
                PaymentMethods[i].BankAccountsId = bankAccountsId[i];
                PaymentMethods[i].CreditCardsId = creditCardsId[i];
            }
        }
    }
}
