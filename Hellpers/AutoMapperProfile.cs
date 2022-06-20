using RoomReservation.DTOs;
using RoomReservation.Models;
using AutoMapper;

namespace RoomReservation.Hellpers;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<BookingRequestDto, Booking>();
        CreateMap<Booking, BookingResponseDto>();
        CreateMap<Booking, BookingDto>();
    }

}
