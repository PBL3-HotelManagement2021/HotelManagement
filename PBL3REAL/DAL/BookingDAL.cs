

using HotelManagement.Extention;
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
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

        public List<Booking> findByProperty(int start, int length,CalendarVM searchByDate ,string search ,string orderby,string status)
        {
            var predicate = PredicateBuilder.True<Booking>();
            if (search != "") 
               predicate = predicate.And(x => x.BookCode.Contains(search) || x.BookIdclientNavigation.CliCode.Contains(search) || x.BookIduserNavigation.UserCode.Contains(search));
            if (searchByDate.type.Equals("Booked Date"))
            {
                predicate = predicate.And(x => x.BookBookdate >= searchByDate.fromDate && x.BookBookdate <= searchByDate.toDate);
            }
           
            if (searchByDate.type.Equals("Due Date"))
            {
                predicate = predicate.And(x => x.BookDuedate >= searchByDate.fromDate && x.BookDuedate <= searchByDate.toDate);
            }
          
            if (searchByDate.type.Equals("Checkin Date"))
            {
                predicate = predicate.And(x => x.BookCheckindate >= searchByDate.fromDate && x.BookCheckindate <= searchByDate.toDate);
            }
            if(searchByDate.type.Equals("Checkout Date"))
            {
                predicate = predicate.And(x => x.BookCheckoutdate >= searchByDate.fromDate && x.BookCheckoutdate <= searchByDate.toDate);
            }
            if (status != "All")
                predicate = predicate.And(x => x.BookStatus == status);
            IQueryable<Booking> query = _appDbContext.Bookings
                                .Include(x => x.BookIdclientNavigation)
                                .Include(x => x.BookIduserNavigation)
                                .Where(predicate);                             
            switch (orderby)
            {
                case "None": break;
                case "Total Price Asc": query = query.OrderBy(x => x.BookTotalprice); break;
                case "Total Price Desc": query = query.OrderByDescending(x => x.BookTotalprice); break;
                default: break;
            }
            
            List<Booking> result = query.Skip(start).Take(length).AsNoTracking().ToList();

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
                            //join room in AppDbContext.Instance.Rooms on bkdt.BoodetIdroom equals room.IdRoom
                            /*  join roty in AppDbContext.Instance.RoomTypes on room.RoomIdroomtype equals roty.IdRoomtype*/
                              where book.BookCode.Equals(code) && book.BookStatus != "Processed"
                              select new Booking()
                              {
                                  IdBook = book.IdBook,
                                  BookBookdate = book.BookBookdate,
                                  BookCheckindate = book.BookCheckindate,
                                  BookCheckoutdate = book.BookCheckoutdate,
                                  BookTotalprice = book.BookTotalprice,
                                  BookDeposit = book.BookDeposit,
                                  BookStatus = book.BookStatus,
                                  BookIdclientNavigation = new Client
                                  {
                                       CliCode = client.CliCode,
                                       CliName =client.CliName,
                                       CliPhone = client.CliPhone,
                                       CliGmail = client.CliGmail
                                  },
   
                                  
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
            Booking booking = _appDbContext.Bookings.Where(x =>x.IdBook == idbook).Include(x => x.BookingDetails).SingleOrDefault();
            _appDbContext.RemoveRange(booking.BookingDetails);
            _appDbContext.SaveChanges();
            _appDbContext.Remove(booking);
            _appDbContext.SaveChanges();
          
        }
        public void delBookingDetail(List<int> listdel_detail)
        {
            List<BookingDetail> list = new List<BookingDetail>();
            foreach(int id in listdel_detail)
            {
                BookingDetail bookingDetail = _appDbContext.BookingDetails.Where(x =>x.IdBoodet == id).AsNoTracking().FirstOrDefault();
                list.Add(bookingDetail);
              
            }
            AppDbContext.Instance.BookingDetails.RemoveRange(list);
            AppDbContext.Instance.SaveChanges();
            foreach(BookingDetail bookingDetail1 in list)
            {
                AppDbContext.Instance.Entry(bookingDetail1).State = EntityState.Detached;
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
            Booking booking = AppDbContext.Instance.Bookings.Where(x =>x.IdBook == idbook).FirstOrDefault();           
            booking.BookStatus = "Checkin";
            AppDbContext.Instance.Bookings.Update(booking);
            AppDbContext.Instance.SaveChanges();
            _appDbContext.Entry(booking).State = EntityState.Detached;
        }

        public int getTotalRow(CalendarVM searchByDate, string search , string status)
        {
            int totalrows = 0;
            var predicate = PredicateBuilder.True<Booking>();
            if (search != "")
                predicate = predicate.And(x => x.BookCode.Contains(search) || x.BookIdclientNavigation.CliCode.Contains(search) || x.BookIduserNavigation.UserCode.Contains(search));
            if (searchByDate.type.Equals("Booked Date"))
                predicate = predicate.And(x => x.BookBookdate >= searchByDate.fromDate && x.BookBookdate <= searchByDate.toDate);
            if (searchByDate.type.Equals("Due Date"))
                predicate = predicate.And(x => x.BookDuedate >= searchByDate.fromDate && x.BookDuedate <= searchByDate.toDate);
            if (searchByDate.type.Equals("Checkin Date"))
                predicate = predicate.And(x => x.BookCheckindate >= searchByDate.fromDate && x.BookCheckindate <= searchByDate.toDate);
            if (searchByDate.type.Equals("Checkout Date"))
                predicate = predicate.And(x => x.BookCheckoutdate >= searchByDate.fromDate && x.BookCheckoutdate <= searchByDate.toDate);
            if (status != "All")
                predicate = predicate.And(x => x.BookStatus == status);

           totalrows = _appDbContext.Bookings
                              .Where(predicate).Count();
            return totalrows;
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
