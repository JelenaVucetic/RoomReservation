using RoomReservation.DTOs;
using RoomReservation.Hellpers;
using RoomReservation.Models;
using AutoMapper;
namespace RoomReservation.Services;

public interface IBookingService
{
    IEnumerable<BookingDto> GetAll();

    Booking Create(BookingRequestDto bookingRequestDto, string header);
}
public class BookingService : IBookingService
{
    private RoomReservationContext _context;
    private readonly IMapper _mapper;
    private readonly Func<string, IBookingCreate> _bookingCreate;

    public BookingService(RoomReservationContext context, IMapper mapper, Func<string, IBookingCreate> bookingCreate)
    {
        _context = context;
        _mapper = mapper;
        _bookingCreate = bookingCreate;
    }

    public  IEnumerable<BookingDto> GetAll()
    {
        return _mapper.Map<List<BookingDto>>(_context.Bookings);
    }

    public Booking Create(BookingRequestDto bookingRequest, string header)
    {
        return _bookingCreate(header).CreateBooking(bookingRequest);
    }
}
