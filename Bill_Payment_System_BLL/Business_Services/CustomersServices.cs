using Bill_Payment_System_BLL.Business_Services.Interfaces;
using Bill_Payment_System_DAL.Unit_of_Work_Pattern.Interfaces;
using Bill_Payment_System_DTO.Data_transfer_objects.Request_Result_DTO;
using Bill_Payment_System_DTO.Data_transfer_objects.Response_Result_DTO;
using Mapster;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_BLL.Business_Services
{
    public class CustomersServices : ICustomersServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomersServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<GetCustomersDTO>> DeleteCustomersAsync(Guid ID)
        {
            var customers = await _unitOfWork.CustomersRepository.DeleteEntityAsync(ID);

            return customers.Adapt<GetCustomersDTO[]>();
        }

        public async Task<IEnumerable<GetCustomersDTO>> GetAllCustomersAsync()
        {
            var customers = await _unitOfWork.CustomersRepository.GetAllEntitiesAsync();

            return customers.Adapt<GetCustomersDTO[]>();
        }

        public async Task<GetCustomersDTO> GetCustomersByIdAsync(Guid ID)
        {
            var customer = await _unitOfWork.CustomersRepository.GetEntityByIdAsync(ID);

            if (customer is null)
            {
                throw new ArgumentNullException($"The customers with ID: {ID} is null!");
            }

            return customer.Adapt<GetCustomersDTO>();
        }

        public async Task<IEnumerable<GetCustomersDTO>> InsertCustomerAsync(InsertCustomersDTO newCustomers)
        {
            var customers = await _unitOfWork.CustomersRepository.InsertEntityAsync(newCustomers.ToEntity());

            return customers.Adapt<GetCustomersDTO[]>();
        }

        public async Task<IEnumerable<GetCustomersDTO>> UpdateCustomerAsync(UpdateCustomersDTO updateCustomers)
        {
            var customers = await _unitOfWork.CustomersRepository.UpdateEntityAsync(updateCustomers.ToEntity());

            return customers.Adapt<GetCustomersDTO[]>(); ;
        }
    }
}
