using Microsoft.EntityFrameworkCore;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBL3REAL.DAL.Implements
{
    public class BookingDetailDAL : IBookingDetailDAL
    {
        public List<BookingDetail> GetBookingDetail(int idbook)
        {
            List<BookingDetail> result = AppDbContext.Instance.BookingDetails.Where(x => x.BoodetIdbook == idbook).ToList();
            return result;
        }

        public void Delete(List<int> listdel_detail)
        {
            List<BookingDetail> list = new List<BookingDetail>();
            foreach (int id in listdel_detail)
            {
                BookingDetail bookingDetail = AppDbContext.Instance.BookingDetails.Where(x => x.IdBoodet == id).AsNoTracking().FirstOrDefault();
                list.Add(bookingDetail);
            }
            AppDbContext.Instance.BookingDetails.RemoveRange(list);
            AppDbContext.Instance.SaveChanges();
            foreach (BookingDetail bookingDetail1 in list)
            {
                AppDbContext.Instance.Entry(bookingDetail1).State = EntityState.Detached;
            }
        }
        public void Add(List<BookingDetail> list)
        {
            try
            {
                AppDbContext.Instance.BookingDetails.AddRange(list);
                AppDbContext.Instance.SaveChanges();
                foreach (BookingDetail bookingDetail1 in list)
                {
                    AppDbContext.Instance.Entry(bookingDetail1).State = EntityState.Detached;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
