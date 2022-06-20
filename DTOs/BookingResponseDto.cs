

namespace RoomReservation.DTOs;

public class BookingResponseDto
{

    public string Title { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}
