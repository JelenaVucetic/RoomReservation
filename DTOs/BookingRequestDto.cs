using System.ComponentModel.DataAnnotations;

namespace RoomReservation.DTOs;

public class BookingRequestDto
{
    [Required]
    public string Title { get; set; }
    [Required]
    public TimeSpan StartTime { get; set; }
    [Required]
    public TimeSpan EndTime { get; set; }
}
