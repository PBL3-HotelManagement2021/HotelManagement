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
                listVM.Add(bookingVm); 
            }
            return listVM;
        }

      
    }
}
