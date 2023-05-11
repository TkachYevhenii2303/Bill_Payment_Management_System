using Bill_Payment_System_DAL.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Payment_System_DTO.Data_transfer_objects.Response_Result_DTO
{
    public abstract class BaseEntityDTO<TEntity, TDataTransgerObject> : IRegister
        where TDataTransgerObject : class, new()
        where TEntity : class, new()
    {
        public TEntity ToEntity() => this.Adapt<TEntity>();

        public TEntity ToEntity(TEntity entity) => (this as TDataTransgerObject).Adapt(entity);

        public static TDataTransgerObject FromEntity(TEntity entity) => entity.Adapt<TDataTransgerObject>();

        private TypeAdapterConfig? Config { get; set; }

        public virtual void AddCustomMappings() { }

        protected TypeAdapterSetter<TEntity, TDataTransgerObject> SetCustomMappings()
        => Config.ForType<TEntity, TDataTransgerObject>();

        protected TypeAdapterSetter<TEntity, TDataTransgerObject> SetCustomMappingsInverse()
            => Config.ForType<TEntity, TDataTransgerObject>();

        public void Register(TypeAdapterConfig config)
        {
            Config = config;

            AddCustomMappings();
        }
    }
}
