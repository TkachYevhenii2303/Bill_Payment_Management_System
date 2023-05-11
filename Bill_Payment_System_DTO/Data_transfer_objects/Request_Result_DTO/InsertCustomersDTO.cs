using Bill_Payment_System_DAL.Entities;
using Bill_Payment_System_DTO.Data_transfer_objects.Response_Result_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DTO.Data_transfer_objects.Request_Result_DTO
{
    public class InsertCustomersDTO : BaseEntityDTO<Customers, InsertCustomersDTO>
    {
        public string Name { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string Password { get; set; } = string.Empty;
    }
}
