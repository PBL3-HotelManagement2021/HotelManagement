using AutoMapper;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL
{
    class BookingBLL
    {
        private BookingDAL _bookingDAL;
        private MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Booking, BookingVM>().ReverseMap();
            cfg.CreateMap<Booking, BookingDetailVM>().ReverseMap();
            cfg.CreateMap<BookingDetail, SubBookingDetailVM>().ReverseMap();

        });
        private Mapper mapper;
        public BookingBLL()
        {
            _bookingDAL = new BookingDAL();
            mapper = new Mapper(config);
        }

        public List<BookingVM> getAll()
        {
            List<BookingVM> listVM = new List<BookingVM>();
            foreach (Booking val in _bookingDAL.getAllBooking())
            {
                BookingVM bookingVm = mapper.Map<BookingVM>(val);
                bookingVm.CliCode = val.BookIdclientNavigation.CliCode;
                bookingVm.UserCode = val.BookIduserNavigation.UserCode;
                listVM.Add(bookingVm);
            }
            return listVM;
        }

        public BookingDetailVM getDetail(int id)
        {
            Booking booking = _bookingDAL.findById(id);
            BookingDetailVM result = mapper.Map<BookingDetailVM>(booking);
            result.CliPhone = booking.BookIdclientNavigation.CliPhone;
            result.CliCode = booking.BookIdclientNavigation.CliCode;
            
            result.CliName = booking.BookIdclientNavigation.CliName;
            result.CliGmail = booking.BookIdclientNavigation.CliGmail;

            foreach(BookingDetail val in booking.BookingDetails)
            {
                SubBookingDetailVM subBookingDetailVM = mapper.Map<SubBookingDetailVM>(val);
                subBookingDetailVM.IdRoomType = val.BoodetIdroomNavigation.RoomIdroomtype;
                result.List.Add(subBookingDetailVM);
            }
            return result;
        }
    }
}
