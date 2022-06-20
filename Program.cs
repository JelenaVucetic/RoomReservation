using RoomReservation.Hellpers;
using RoomReservation.Services;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<RoomReservationContext>(opt => opt.UseInMemoryDatabase("RoomReservation"));


builder.Services.AddScoped<BookingCreateA>();
builder.Services.AddScoped<BookingCreateB>();


builder.Services.AddScoped<Func<string, IBookingCreate>>(serviceProvider => key =>
{
    switch (key)
    {
        case "A":
            Debug.WriteLine("A");
            return serviceProvider.GetService<BookingCreateA>();
        default:
            Debug.WriteLine("B");
            return serviceProvider.GetService<BookingCreateB>();
    }
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
