using AutoMapper;
using HotelManagement.DAL.Implement;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.DAL;
using PBL3REAL.DAL.Facade;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL
{
    class QLBookingBLL : IBookingBLL
    {
        private Mapper mapper;
        private BookingDALManageFacade _bookingDALManageFacade;
        public QLBookingBLL()
        {
            mapper = new Mapper(MapperVM.config);
            _bookingDALManageFacade = new BookingDALManageFacade();
        }

        public List<BookingVM> FindByProperty(int pages , int rows ,CalendarVM searchDate , string search , string orderBy, string status)
        {
            int start = (pages - 1) * rows;
            int length = rows;
            List<BookingVM> listVM = new List<BookingVM>();
            foreach (Booking val in _bookingDALManageFacade.FindBooking(start,length,searchDate,search,orderBy,status))
            {
                BookingVM bookingVm = mapper.Map<BookingVM>(val);
                bookingVm.Index = ++start;
                bookingVm.CliCode = val.BookIdclientNavigation.CliCode;
                bookingVm.UserCode = val.BookIduserNavigation.UserCode;
                listVM.Add(bookingVm);
            }
            return listVM;
        }

        public BookingDetailVM GetDetail(int id)
        {
            try
            {
                int i = 0;
                Booking booking = _bookingDALManageFacade.FindBookingById(id);
                List<Room>listRoom = _bookingDALManageFacade.FindRoomByIdBook(id);
                BookingDetailVM result = mapper.Map<BookingDetailVM>(booking);
                result.clientVM = mapper.Map<ClientVM>(booking.BookIdclientNavigation);
                foreach (BookingDetail val in booking.BookingDetails)
                {
                    SubBookingDetailVM subBookingDetailVM = mapper.Map<SubBookingDetailVM>(val);
                    subBookingDetailVM.RoomName = listRoom[i].RoomName;
                    subBookingDetailVM.RoomType = listRoom[i].RoomIdroomtypeNavigation.RotyName;
                    subBookingDetailVM.Duration = result.CheckoutDate.Subtract(result.CheckinDate).Days;
                    subBookingDetailVM.Amount = subBookingDetailVM.Duration * subBookingDetailVM.BoodetPrice;
                    i++;
                    result.ListSub.Add(subBookingDetailVM);
                }
 
                return result;
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        public void DelBooking(int id , string status)
        {
            try
            {
                if (status.Equals("Processed")) _bookingDALManageFacade.DelBooking(id);
                else throw new ArgumentException("Only booking with status 'Processed' can delete");
            }
            catch (Exception)
            {
                throw new Exception("Error while deleting");
            }
 
        }

        public void CheckinBooking(int idbook)
        {
            try
            {
                _bookingDALManageFacade.CheckinBooking(idbook);
            }catch(Exception)
            {
                throw;
            }
        }

        public int GetPagination(int rows , CalendarVM searchByDate, string search , string status)
        {
            int totalRows = _bookingDALManageFacade.GetBookingTotalRow(searchByDate, search , status);
            int totalpage;
            if (totalRows % rows == 0)
            {
                totalpage = totalRows / rows;
            }
            else
            {
                totalpage = totalRows / rows + 1;
            }
            return totalpage;
        }

  

        public void UpdateBooking(BookingDetailVM bookingDetailVM, List<int> listDel)
        {
            Booking booking = new Booking();
            mapper.Map(bookingDetailVM, booking);
            booking.BookIdclient = bookingDetailVM.clientVM.IdClient;
            booking.BookIduser = QLUserBLL.stoUser.IdUser;         //user se dc luu o tang BLL khi dang nhap 
            List<BookingDetail> listadd = new List<BookingDetail>();
            foreach (SubBookingDetailVM valVM in bookingDetailVM.ListSub)
            {
                BookingDetail bookingDetail = new BookingDetail();
                mapper.Map(valVM, bookingDetail);
                bookingDetail.BoodetIdbook = booking.IdBook;
                if (bookingDetail.IdBoodet == 0) listadd.Add(bookingDetail);
            }

            try
            {              
                if(listDel.Count!=0) _bookingDALManageFacade.DelBookingDetail(listDel);
                _bookingDALManageFacade.UpdateBooking(booking);
                if (listadd.Count != 0) _bookingDALManageFacade.AddBookingDetail(listadd);            
            }
            catch (Exception e)
            {
                /*  Console.WriteLine(e.Message);*/
                throw;
            }
        }

        public void AddBooking(BookingDetailVM result)
        {
            int idBook = _bookingDALManageFacade.GetBookingnextid();
            Booking booking = new Booking();
            mapper.Map(result, booking);
            booking.BookIduser = QLUserBLL.stoUser.IdUser;
            Client client = new Client();
            mapper.Map(result.clientVM, client);
            List<BookingDetail> listadd = new List<BookingDetail>();
            foreach (SubBookingDetailVM val in result.ListSub)
            {
                BookingDetail bookingDetail = new BookingDetail();
                mapper.Map(val, bookingDetail);
                bookingDetail.BoodetIdbook = idBook;
                listadd.Add(bookingDetail);
            }
            try
            {
                if (client.IdClient == 0) booking.BookIdclient = _bookingDALManageFacade.AddClient(client);
                else booking.BookIdclient = client.IdClient;
                _bookingDALManageFacade.AddBooking(booking);
                _bookingDALManageFacade.AddBookingDetail(listadd);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
