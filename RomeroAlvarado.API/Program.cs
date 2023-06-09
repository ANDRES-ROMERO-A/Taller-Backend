using Microsoft.EntityFrameworkCore;
using RomeroAlvarado.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Get connection String
//var connectionString = builder.Configuration.GetConnectionString("DevConnection");


//Add dbcontext
builder.Services.AddDbContext<SalesDB2023DbContext>(options =>{
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"));

});
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
