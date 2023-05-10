using Bill_Payment_System_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Generic_Repository_Pattern.Interfaces
{
    internal interface IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        public Task<IEnumerable<TEntity>> GetAllEntitiesAsync();

        public Task<TEntity?> GetEntityByIdAsync(Guid ID);

        public Task<IEnumerable<TEntity>> InsertEntityAsycn(TEntity entity);

        public Task<IEnumerable<TEntity>> UpdateEntityAsync(TEntity entity);

        public Task<IEnumerable<TEntity>> DeleteEntityAsync(Guid ID);
    }
}
