using API.Extensions;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Seed;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
var services  = scope.ServiceProvider;

//GENERANDO MIGRATION AL INICIAL EL APP
try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
    await Seed.SeedData(context);

}catch(Exception Ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(Ex, "Ha ocurrido un problema al realizar la migracion");
}

app.Run();
