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
        private ClientDAL clientDAL;
        private Mapper mapper;
        public BookingBLL()
        {
            _bookingDAL = new BookingDAL();
            mapper = new Mapper(MapperVM.config);
            clientDAL = new ClientDAL();
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
            try
            {
                Booking booking = _bookingDAL.findById(id);
                BookingDetailVM result = mapper.Map<BookingDetailVM>(booking);
                result.clientVM = mapper.Map<ClientVM>(booking.BookIdclientNavigation);
            

                foreach (BookingDetail val in booking.BookingDetails)
                {
                    SubBookingDetailVM subBookingDetailVM = mapper.Map<SubBookingDetailVM>(val);
                    subBookingDetailVM.IdRoomType = val.BoodetIdroomNavigation.RoomIdroomtype;
                    result.ListSub.Add(subBookingDetailVM);
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        public void delBooking(int id , string status)
        {
            try
            {
                if (!status.Equals("Finish")) _bookingDAL.delBooking(id);
                else throw new ArgumentException("Completed booking can't be deleted");
            }
            catch (Exception)
            {
                throw;
            }
 
        }

        public void completeBooking(int idbook)
        {
            try
            {
                _bookingDAL.completeBooking(idbook);
            }catch(Exception)
            {
                throw;
            }
        }

      

        public void addBooking(BookingDetailVM result)
        {
            int idRoom = _bookingDAL.getnextid();
            Booking booking = new Booking();
            mapper.Map(result, booking);
            booking.BookIduser = 1;
            Client client = new Client();
            mapper.Map(result.clientVM, client);
            List<BookingDetail> listadd = new List<BookingDetail>();
            foreach (SubBookingDetailVM val in result.ListSub)
            {
                BookingDetail bookingDetail = new BookingDetail();
                mapper.Map(val, bookingDetail);
                bookingDetail.BoodetIdbook = idRoom;
                listadd.Add(bookingDetail);
            }
            try
            {
                if (client.IdClient == 0) booking.BookIdclient = clientDAL.add(client);
                _bookingDAL.addBooking(booking);
                _bookingDAL.addBookingDetail(listadd);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
