using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DTO.Data_transfer_objects.Interfaces
{
    public interface IBaseEntityDTO
    {
        public Guid ID { get; set; }
    }
}
