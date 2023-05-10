using Bill_Payment_System_DAL.Context;
using Bill_Payment_System_DAL.Entities;
using Bill_Payment_System_DAL.Entities_Repositories.Interfaces;
using Bill_Payment_System_DAL.Generic_Repository_Pattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Entities_Repositories
{
    internal class CustomersRepository : GenericRepository<Customers>, ICustomersRepository
    {
        private readonly BillPaymentContext _context;

        public CustomersRepository(BillPaymentContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customers>> GetAllCustomersByName(string name)
        {
            return await _context.Set<Customers>().Where(x => x.Name == name).ToListAsync();
        }
    }
}
