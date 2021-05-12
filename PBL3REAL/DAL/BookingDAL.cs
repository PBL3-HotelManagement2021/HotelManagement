

using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBL3REAL.DAL
{
    public class BookingDAL
    {
        private AppDbContext _appDbContext;
        public BookingDAL()
        {
            _appDbContext = new AppDbContext();
        }

        public List<Booking> getAllBooking()
        {
            List<Booking> result = _appDbContext.Bookings
                                .Include(x =>x.BookIdclientNavigation)
                                .Include(x =>x.BookIduserNavigation)
                                .AsNoTracking()
                                .ToList();


            return result;
        }

        public Booking findById(int idbook)
        {
            Booking result = _appDbContext.Bookings
                            .Include(x => x.BookingDetails)
                            .ThenInclude(y => y.BoodetIdroomNavigation)
                            .Include(x => x.BookIdclientNavigation)
                            .Include(x => x.BookIduserNavigation)
                            .Where(x => x.IdBook == idbook)
                            .SingleOrDefault();
             return result;     
        }

        public Booking findForInvoice(string code)
        {
            Booking result = (from book in AppDbContext.Instance.Bookings
                              join client in AppDbContext.Instance.Clients on book.BookIdclient equals client.IdClient
                              join bkdt in AppDbContext.Instance.BookingDetails on book.IdBook equals bkdt.BoodetIdbook
                           /* join room in AppDbContext.Instance.Rooms on bkdt.BoodetIdroom equals room.IdRoom
                              join roty in AppDbContext.Instance.RoomTypes on room.RoomIdroomtype equals roty.IdRoomtype*/
                              where book.BookCode.Equals(code)
                              select new Booking()
                              {
                                  IdBook = book.IdBook,
                                  BookCheckindate = book.BookCheckindate,
                                  BookCheckoutdate = book.BookCheckoutdate,
                                  BookTotalprice = book.BookTotalprice,
                                  BookIdclientNavigation = new Client
                                  {
                                       CliCode = client.CliCode,
                                       CliName =client.CliName,
                                       CliPhone = client.CliPhone                                     
                                  }
                              }
                              ).FirstOrDefault();
            return result;
        }
       

        public void updateBooking(Booking booking)
        {
            AppDbContext.Instance.Update(booking);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(booking).State = EntityState.Detached;
        }

        public List<BookingDetail>getBookingDetail(int idbook)
        {
            List<BookingDetail> result = _appDbContext.BookingDetails.Where(x => x.BoodetIdbook == idbook).ToList();
            return result;
        }

        public void addBooking(Booking booking)
        {
         
                _appDbContext.Add(booking);
                _appDbContext.SaveChanges();
     
        }

        public void delBooking(int idbook)
        {

            /* List<Booking> list = new List<Booking>();
             foreach (int id in listdel)
             {

                 list.Add(booking);
             }*/
            Booking booking = _appDbContext.Bookings.Find(idbook);
            _appDbContext.Remove(booking);
            _appDbContext.SaveChanges();
          
        }
        public void delBookingDetail(List<int> listdel_detail)
        {
            List<BookingDetail> list = new List<BookingDetail>();
            foreach(int id in listdel_detail)
            {
                BookingDetail bookingDetail = _appDbContext.BookingDetails.Find(id);
                list.Add(bookingDetail);
                _appDbContext.Entry(bookingDetail).State = EntityState.Detached;
            }
        }
        public void addBookingDetail(List<BookingDetail> list)
        {
            try
            {
                _appDbContext.BookingDetails.AddRange(list);
                _appDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void completeBooking(int idbook)
        {
            Booking booking = AppDbContext.Instance.Bookings.Find(idbook);
            booking.BookStatus = "Finish";
            AppDbContext.Instance.Bookings.Update(booking);
            AppDbContext.Instance.SaveChanges();
            _appDbContext.Entry(booking).State = EntityState.Detached;
        }

        public int getnextid()
        {
            int id;
            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT IDENT_CURRENT('booking')+1";
                _appDbContext.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    result.Read();
                    id = Decimal.ToInt32((decimal)result[0]);
                }
            }
            return id;
        }
    }
}
