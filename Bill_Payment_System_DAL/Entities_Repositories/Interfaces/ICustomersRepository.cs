using Bill_Payment_System_DAL.Entities;
using Bill_Payment_System_DAL.Generic_Repository_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Entities_Repositories.Interfaces
{
    internal interface ICustomersRepository : IGenericRepository<Customers>
    {
        public Task<IEnumerable<Customers>> GetAllCustomersByName(string name);
    }
}
