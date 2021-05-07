

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

        public Booking findById(int id)
        {
            Booking result = _appDbContext.Bookings
                            .Include(x => x.BookingDetails)
                            .ThenInclude(y => y.BoodetIdroomNavigation)
                            .Include(x => x.BookIdclientNavigation)
                            .Include(x => x.BookIduserNavigation)
                            .Where(x => x.IdBook == id)
                            .SingleOrDefault();
             return result;     
        }

        public List<BookingDetail>getBookingDetail(int idbook)
        {
            List<BookingDetail> result = _appDbContext.BookingDetails.Where(x => x.BoodetIdbook == idbook).ToList();
            return result;
        }

        public void addBooking(Booking booking)
        {
            try
            {
                _appDbContext.Add(booking);
                _appDbContext.SaveChanges();
            }catch(Exception)
            {
                throw; 
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
