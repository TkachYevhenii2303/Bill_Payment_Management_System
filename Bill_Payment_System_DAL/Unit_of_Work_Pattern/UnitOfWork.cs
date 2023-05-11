using Bill_Payment_System_DAL.Context;
using Bill_Payment_System_DAL.Entities_Repositories;
using Bill_Payment_System_DAL.Entities_Repositories.Interfaces;
using Bill_Payment_System_DAL.Unit_of_Work_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Unit_of_Work_Pattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BillPaymentContext _context;

        public UnitOfWork(BillPaymentContext context)
        {
            _context = context;

            CustomersRepository = new CustomersRepository(_context);
        }

        public ICustomersRepository CustomersRepository { get; set; }

        public int Complete() => _context.SaveChanges();

        public async void Dispose() => await _context.DisposeAsync();
    }
}
