using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IBookingDetailDAL
    {
        public void Add(List<BookingDetail> list);
        public void Delete(List<int> listdel_detail);
        public List<BookingDetail> GetBookingDetail(int idbook);

    }
}
