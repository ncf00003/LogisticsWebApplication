// add using statements for integration
using LogisticsWebAppAPI.Data;
using LogisticsWebAppAPI.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// NF Services
builder.Services.AddScoped<INFDeliveryTracking, NFDeliveryTrackingService>();
// Add Second API
builder.Services.AddScoped<INFVehicleDriver, NFVehicleDriverService>();
builder.Services.AddDbContext<NFDbContextClass>();



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

app.UseAuthorization();
app.MapControllers();
app.Run();
