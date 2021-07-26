using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IBookingDAL
    {
        public List<Booking> FindByProperty(int start, int length, CalendarVM searchByDate, string search, string orderby, string status);
        public Booking FindById(int idbook);

        public Booking FindForInvoice(string code);
        public void UpdateBooking(Booking booking);
        public void AddBooking(Booking booking);
        public void DelBooking(int idbook);
        public void CheckinBooking(int idbook);
        public int GetTotalRow(CalendarVM searchByDate, string search, string status);
        public int Getnextid();


    }
}
