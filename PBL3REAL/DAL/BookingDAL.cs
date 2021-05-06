

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
    }
}
