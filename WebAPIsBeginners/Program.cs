using Microsoft.EntityFrameworkCore;
using WebAPIsBeginners;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Register the CustomersDataContext.cs
builder.Services.AddDbContext<CustomersDataContext>(opt =>
    opt.UseInMemoryDatabase("Customers"));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    o =>
    {
        o.SwaggerDoc("v1", new()
        {
            Title = "Customers WEB APIs",
            Version = "v1",
        });
    });

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