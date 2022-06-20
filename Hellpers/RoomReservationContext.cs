using Microsoft.EntityFrameworkCore;
using RoomReservation.Models;
namespace RoomReservation.Hellpers;

public class RoomReservationContext : DbContext
{
    public RoomReservationContext(DbContextOptions<RoomReservationContext> options)
           : base(options)
    {
    }

    public DbSet<Booking> Bookings { get; set; }
}
