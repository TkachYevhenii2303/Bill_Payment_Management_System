using Bill_Payment_System_DAL.Context;
using Bill_Payment_System_DAL.Entities;
using Bill_Payment_System_DAL.Generic_Repository_Pattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DAL.Generic_Repository_Pattern
{
    internal class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly BillPaymentContext _context;

        public GenericRepository(BillPaymentContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> DeleteEntityAsync(Guid ID)
        {
            var result = await _context.Set<TEntity>().FirstOrDefaultAsync(x => x.ID == ID);

            if (result is null)
            {
                throw new Exception($"Entity with ID {ID} not found!");
            }

            _context.Set<TEntity>().Remove(result);

            await _context.SaveChangesAsync();

            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllEntitiesAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity?> GetEntityByIdAsync(Guid ID)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.ID == ID);
        }

        public async Task<IEnumerable<TEntity>> InsertEntityAsycn(TEntity entity)
        {
            entity.CreatedDateTime = DateTime.Now;
            
            await _context.Set<TEntity>().AddAsync(entity);

            await _context.SaveChangesAsync();

            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> UpdateEntityAsync(TEntity entity)
        {
            entity.UpdatedDateTime = DateTime.Now;

            try
            {
                var result = await this.GetEntityByIdAsync(entity.ID);

                if (result is null)
                {
                    throw new Exception($"Entity with ID {entity.ID} not found!");
                }

                _context.Set<TEntity>().Update(entity);

                await _context.SaveChangesAsync();

                return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            catch (Exception exception)
            {
                throw new Exception($"Something went wrong...", exception);
            }
        }
    }
}
