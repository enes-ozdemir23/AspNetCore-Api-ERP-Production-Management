using Erp.BusinessLayer.Abstract;
using Erp.BusinessLayer.Concrete;
using Erp.DataAccessLayer.Abstract;
using Erp.DataAccessLayer.Concrete.Context;
using Erp.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();

builder.Services.AddScoped<ICityDal, EfCityDal>();
builder.Services.AddScoped<ICityService, CityManager>();

builder.Services.AddScoped<IStockDal, EfStockDal>();
builder.Services.AddScoped<IStockService, StockManager>();

builder.Services.AddScoped<IDistrictDal, EfDistrictDal>();
builder.Services.AddScoped<IDistrictService, DistrictManager>();

builder.Services.AddScoped<IGroupCodeDal, EfGroupCodeDal>();
builder.Services.AddScoped<IGroupCodeService, GroupCodeManager>();

builder.Services.AddScoped<IOrderDal, EfOrderDal>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<IOrderItemDal, EfOrderItemDal>();
builder.Services.AddScoped<IOrderItemService, OrderItemManager>();

builder.Services.AddScoped<IWorkOrderDal, EfWorkOrderDal>();
builder.Services.AddScoped<IWorkOrderService, WorkOrderManager>();

builder.Services.AddScoped<IProductionResultDal, EfProductionResultDal>();
builder.Services.AddScoped<IProductionResultService, ProductionResultManager>();

builder.Services.AddScoped<IStockMovementDal, EfStockMovementDal>();
builder.Services.AddScoped<IStockMovementService, StockMovementManager>();




builder.Services.AddDbContext<ErpContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
