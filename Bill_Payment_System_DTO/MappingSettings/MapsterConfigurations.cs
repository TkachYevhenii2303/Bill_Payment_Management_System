using Bill_Payment_System_DTO.Data_transfer_objects.Response_Result_DTO;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Bill_Payment_System_DTO.MappingSettings
{
    public static class MapsterConfigurations
    {
        public static void AddMapster(this IServiceCollection services)
        {
            var typeAdapterConfig = TypeAdapterConfig.GlobalSettings;

            Assembly assembly = typeof(BaseEntityDTO<,>).Assembly;

            typeAdapterConfig.Scan(assembly);
        }
    }
}
