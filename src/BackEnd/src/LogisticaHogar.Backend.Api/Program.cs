using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using LogisticaHogar.Backend.Services.Services;
using LogisticaHogar.Backend.Data;
using LogisticaHogar.Backend.Model;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Configuration.AddJsonFile("appsettings.json");

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
       options.UseNpgsql(connectionString));


// Registra servicios personalizados
builder.Services.AddScoped<IProductoService, ProductoService>();

var app = builder.Build();

// Configura el enrutamiento para los controladores
app.MapControllers();


app.Run();
