namespace RoomReservation.Models;

public class Booking
{
    public int Id { get; set; }
    public string Title { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}
