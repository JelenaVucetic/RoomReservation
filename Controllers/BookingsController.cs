using Microsoft.AspNetCore.Mvc;
using RoomReservation.Services;
using RoomReservation.DTOs;
using AutoMapper;

namespace RoomReservation.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingsController : ControllerBase
{
    private readonly IBookingService _bookingsService;
    private readonly IMapper _mapper;

    public BookingsController(IBookingService bookingsService, IMapper mapper)
    {
        _bookingsService = bookingsService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {      
        var bookings = _bookingsService.GetAll();
        return Ok(bookings);
    }

    [HttpPost]
    public IActionResult Create(BookingRequestDto bookingRequestDto)
    {
        //add accessor
        string header = HttpContext.Request.Headers["Reservation"];

        var booking = _bookingsService.Create(bookingRequestDto, header);
        var bookingResponse = _mapper.Map<BookingResponseDto>(booking);
        return Ok(bookingResponse);
    }
}
