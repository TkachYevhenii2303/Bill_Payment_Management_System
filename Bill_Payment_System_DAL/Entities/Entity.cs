using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid ID { get; set; }

        public virtual DateTime CreatedDateTime { get; set; } 

        public virtual DateTime? UpdatedDateTime { get; set; }

        public BaseEntity() { ID = Guid.NewGuid(); CreatedDateTime = DateTime.Now; UpdatedDateTime = null; }
    }
}
