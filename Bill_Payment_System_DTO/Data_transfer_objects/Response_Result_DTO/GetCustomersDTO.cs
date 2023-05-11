using Bill_Payment_System_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bill_Payment_System_DTO.Data_transfer_objects.Response_Result_DTO
{
    public class GetCustomersDTO : BaseEntityDTO<Customers, GetCustomersDTO>
    {
        [JsonPropertyName("Customer's ID: ")]
        public Guid ID { get; set; }

        [JsonPropertyName("Customer's title: ")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("Customer's email: ")]
        public string? Email { get; set; }
    }
}
