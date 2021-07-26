using HotelManagement.DAL.Implement;
using PBL3REAL.DAL.Implements;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Facade
{
    public class BookingDALManageFacade
    {
        private IBookingDAL _bookingDALProvider;
        private IBookingDetailDAL _bookingDetailDALProvider;
        private IRoomDAL _roomDALProvider;
        private IClientDAL _clientDALProvider;
        public BookingDALManageFacade()
        {
            _bookingDALProvider = new BookingDAL();
            _roomDALProvider = new RoomDAL();
            _clientDALProvider = new ClientDAL();
            _bookingDetailDALProvider = new BookingDetailDAL();
        }

        public List<Booking> FindBooking(int start, int length, CalendarVM searchByDate, string search, string orderby, string status)
        {
            return _bookingDALProvider.FindByProperty(start, length, searchByDate, search, orderby, status);
        }
        public Booking FindBookingById(int idbook)
        {
            return _bookingDALProvider.FindById(idbook);
        }

        public Booking FindBookingForInvoice(string code)
        {
            return _bookingDALProvider.FindForInvoice(code);
        }
        public void UpdateBooking(Booking booking)
        {
            _bookingDALProvider.UpdateBooking(booking);
        }
        public void AddBooking(Booking booking)
        {
            _bookingDALProvider.AddBooking(booking);
        }
        public void DelBooking(int idbook)
        {
            _bookingDALProvider.DelBooking(idbook);
        }
        public void CheckinBooking(int idbook)
        {
            _bookingDALProvider.CheckinBooking(idbook);
        }
        public int GetBookingTotalRow(CalendarVM searchByDate, string search, string status)
        {
            return _bookingDALProvider.GetTotalRow(searchByDate, search, status);
        }
        public int GetBookingnextid()
        {
            return _bookingDALProvider.Getnextid();
        }

        public List<Room> FindRoomByIdBook(int idbook)
        {
            return _roomDALProvider.FindByIdBook(idbook);
        }

        public int AddClient(Client client)
        {
            return _clientDALProvider.Add(client);
        }
        public int UpdateClient(Client client)
        {
            return _clientDALProvider.Update(client);
        }

        public void AddBookingDetail(List<BookingDetail> list)
        {
             _bookingDetailDALProvider.AddBookingDetail(list);
        }
        public void DelBookingDetail(List<int> listdel_detail)
        {
             _bookingDetailDALProvider.DelBookingDetail(listdel_detail);
        }
        public List<BookingDetail> GetBookingDetail(int idbook)
        {
            return _bookingDetailDALProvider.GetBookingDetail(idbook);
        }
    }
}
