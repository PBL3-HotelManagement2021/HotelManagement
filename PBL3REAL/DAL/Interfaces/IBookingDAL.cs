using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IBookingDAL : SharedInterface <Booking>
    {
        public List<Booking> FindByProperties(int start, int length, CalendarVM searchByDate, string search, string orderby, string status);
  /*      public Booking FindById(int idbook);*/

        public Booking FindForInvoice(string code);
/*        public void Update(Booking booking);
        public void Add(Booking booking);
        public void Delete(int idbook);*/
        public void CheckinBooking(int idbook);
        public int GetTotalRow(CalendarVM searchByDate, string search, string status);


    }
}
