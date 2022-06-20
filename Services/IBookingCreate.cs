using RoomReservation.Models;
using RoomReservation.DTOs;

namespace RoomReservation.Services;

public interface IBookingCreate
{
    public Booking CreateBooking(BookingRequestDto bookingRequest);
}
