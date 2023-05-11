using Bill_Payment_System_DTO.Data_transfer_objects.Request_Result_DTO;
using Bill_Payment_System_DTO.Data_transfer_objects.Response_Result_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_BLL.Business_Services.Interfaces
{
    public interface ICustomersServices
    {
        public Task<IEnumerable<GetCustomersDTO>> GetAllCustomersAsync();

        public Task<GetCustomersDTO> GetCustomersByIdAsync(Guid ID);

        public Task<IEnumerable<GetCustomersDTO>> InsertCustomerAsync(InsertCustomersDTO newCustomers);

        public Task<IEnumerable<GetCustomersDTO>> UpdateCustomerAsync(UpdateCustomersDTO updateCustomers);

        public Task<IEnumerable<GetCustomersDTO>> DeleteCustomersAsync(Guid ID);
    }
}
