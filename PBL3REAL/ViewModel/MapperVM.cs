using AutoMapper;
using HotelManagement.ViewModel;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
   public class MapperVM
    {
        public static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Booking, BookingVM>()
                .ForMember(dest => dest.Code, act => act.MapFrom(src => src.BookCode))
                .ForMember(dest => dest.CheckinDate, act => act.MapFrom(src => src.BookCheckindate))
                .ForMember(dest => dest.CheckoutDate, act => act.MapFrom(src => src.BookCheckoutdate))
                .ForMember(dest => dest.DueDate, act => act.MapFrom(src => src.BookDuedate))
                .ForMember(dest => dest.BookDate, act => act.MapFrom(src => src.BookBookdate))
                .ForMember(dest => dest.TotalPrice, act => act.MapFrom(src => src.BookTotalprice))
                .ForMember(dest => dest.Status, act => act.MapFrom(src => src.BookStatus))
                .ForMember(dest => dest.Deposit, act => act.MapFrom(src => src.BookDeposit))
                .ReverseMap();
            cfg.CreateMap<Booking, BookingDetailVM>()
                .ForMember(dest => dest.Code, act => act.MapFrom(src => src.BookCode))
                .ForMember(dest => dest.CheckinDate, act => act.MapFrom(src => src.BookCheckindate))
                .ForMember(dest => dest.CheckoutDate, act => act.MapFrom(src => src.BookCheckoutdate))
                .ForMember(dest => dest.DueDate, act => act.MapFrom(src => src.BookDuedate))
                .ForMember(dest => dest.BookDate, act => act.MapFrom(src => src.BookBookdate))
                .ForMember(dest => dest.TotalPrice, act => act.MapFrom(src => src.BookTotalprice))
                .ForMember(dest => dest.Status, act => act.MapFrom(src => src.BookStatus))
                .ForMember(dest => dest.Deposit, act => act.MapFrom(src => src.BookDeposit))
                .ReverseMap();
            cfg.CreateMap<BookingDetail, SubBookingDetailVM>().ReverseMap();
            cfg.CreateMap<Client, ClientVM>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.CliName))
                .ForMember(dest => dest.Phone, act => act.MapFrom(src => src.CliPhone))
                .ForMember(dest => dest.Code, act => act.MapFrom(src => src.CliCode))
                .ForMember(dest => dest.Gmail, act => act.MapFrom(src => src.CliGmail))
                .ReverseMap();
            cfg.CreateMap<Room, RoomVM>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.RoomName))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.RoomDescription))
                .ReverseMap();
            cfg.CreateMap<Status, StatusVM>().ReverseMap();
            cfg.CreateMap<StatusTime, StatusTimeVM>().ReverseMap();
            cfg.CreateMap<Room, RoomDetailVM>().ReverseMap();
            cfg.CreateMap<RoomType, RoomTypeVM>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.RotyName))
                .ForMember(dest => dest.Price, act => act.MapFrom(src => src.RotyCurrentprice))
                .ForMember(dest => dest.Code, act => act.MapFrom(src => src.RotyCode))
                .ForMember(dest => dest.Description, act => act.MapFrom(src => src.RotyDescription))
                .ForMember(dest => dest.Capacity, act => act.MapFrom(src => src.RotyCapacity))
                .ReverseMap();
            cfg.CreateMap<ImgStorage, ImageVM>().ReverseMap();
            cfg.CreateMap<User, UserVM>().ReverseMap();
            cfg.CreateMap<Role, RoleVM>().ReverseMap();
            cfg.CreateMap<Invoice, InvoiceVM>().ReverseMap();
            cfg.CreateMap<Room, AvailableRoomVM>()
                .ForMember(dest => dest.RoTyName, act => act.MapFrom(src => src.RoomIdroomtypeNavigation.RotyName))
                .ForMember(dest => dest.RotyCode, act => act.MapFrom(src => src.RoomIdroomtypeNavigation.RotyCode))
                .ForMember(dest => dest.RotyCurrentprice, act => act.MapFrom(src => src.RoomIdroomtypeNavigation.RotyCurrentprice))
                .ReverseMap();
        });
    }
}
