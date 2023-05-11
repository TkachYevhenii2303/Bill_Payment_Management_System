using Bill_Payment_System_BLL.Business_Services;
using Bill_Payment_System_BLL.Business_Services.Interfaces;
using Bill_Payment_System_DAL.Context;
using Bill_Payment_System_DAL.Generic_Repository_Pattern;
using Bill_Payment_System_DAL.Generic_Repository_Pattern.Interfaces;
using Bill_Payment_System_DAL.Unit_of_Work_Pattern;
using Bill_Payment_System_DAL.Unit_of_Work_Pattern.Interfaces;
using Bill_Payment_System_DTO.MappingSettings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMapster();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BillPaymentContext>(configuration =>
{
    configuration.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
        migrations => migrations.MigrationsAssembly("Bill_Payment_Management_Migrations"));
});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<ICustomersServices, CustomersServices>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();