using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.Interfaces
{
    interface IBookingBLL
    {
        public List<BookingVM> FindByProperty(int pages, int rows, CalendarVM searchDate, string search, string orderBy, string status);
        public BookingDetailVM GetDetail(int id);
        public void DelBooking(int id, string status);
        public void CheckinBooking(int idbook);
        public int GetPagination(int rows, CalendarVM searchByDate, string search, string status);
        public void UpdateBooking(BookingDetailVM bookingDetailVM, List<int> listDel);
        public void AddBooking(BookingDetailVM result);
    }
}
