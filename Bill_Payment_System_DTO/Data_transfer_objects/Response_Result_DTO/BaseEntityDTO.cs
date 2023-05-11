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
    public abstract class BaseEntityDTO<TDataTransgerObjetc, TEntity> : IRegister
        where TDataTransgerObjetc : class, new()
        where TEntity : class, new()
    {
        public TEntity ToEntity() => this.Adapt<TEntity>();

        public TEntity ToEntity(TEntity entity) => (this as TDataTransgerObjetc).Adapt(entity);

        public static TDataTransgerObjetc FromEntity(TEntity entity) => entity.Adapt<TDataTransgerObjetc>();

        private TypeAdapterConfig? Config { get; set; }

        public virtual void AddCustomMappings() { }

        protected TypeAdapterSetter<TDataTransgerObjetc, TEntity> SetCustomMappings()
        => Config.ForType<TDataTransgerObjetc, TEntity>();

        protected TypeAdapterSetter<TEntity, TDataTransgerObjetc> SetCustomMappingsInverse()
            => Config.ForType<TEntity, TDataTransgerObjetc>();

        public void Register(TypeAdapterConfig config)
        {
            Config = config;

            AddCustomMappings();
        }
    }
}
