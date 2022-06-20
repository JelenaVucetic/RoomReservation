using RoomReservation.Models;
using RoomReservation.DTOs;
using AutoMapper;
using RoomReservation.Hellpers;

namespace RoomReservation.Services;

public class BookingCreateB : IBookingCreate
{
    private RoomReservationContext _context;
    private readonly IMapper _mapper;

    public BookingCreateB(RoomReservationContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public Booking CreateBooking(BookingRequestDto bookingRequest)
    {
        var booking = _mapper.Map<Booking>(bookingRequest);
        _context.Bookings.Add(booking);
        _context.SaveChanges();
        return booking;
    }
}
