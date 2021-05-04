
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.DAL.Implement
{
    public class ImgStorageDAL
    {
        private AppDbContext _appDbContext;
        public ImgStorageDAL()
        {
            _appDbContext = new AppDbContext();

        }
        public void delete(int id)
        {
            ImgStorage imgStorage = _appDbContext.ImgStorages.Find(id);
            _appDbContext.ImgStorages.Remove(imgStorage);
            _appDbContext.SaveChanges();
        }
    }
}

