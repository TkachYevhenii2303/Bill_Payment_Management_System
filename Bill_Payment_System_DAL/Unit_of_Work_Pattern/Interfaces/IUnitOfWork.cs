using Bill_Payment_System_DAL.Entities_Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Unit_of_Work_Pattern.Interfaces
{
    internal interface IUnitOfWork : IDisposable
    {
        public ICustomersRepository _CustomersRepository { get; }
    }
}
