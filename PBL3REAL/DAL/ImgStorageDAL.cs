
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
    public class ImgStorageDAL
    {
        public static ImgStorageDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ImgStorageDAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private static ImgStorageDAL _Instance;
        public ImgStorageDAL()
        {
        }

       
        public void delete(List<int> listdel)
        {
            List<ImgStorage> list = new List<ImgStorage>();
            foreach(int id in listdel)
            {
                ImgStorage imgStorage = AppDbContext.Instance.ImgStorages.Where(x =>x.IdImgsto == id).SingleOrDefault();
                AppDbContext.Instance.Entry(imgStorage).State = EntityState.Detached;
                if (imgStorage != null) list.Add(imgStorage);
            }

            AppDbContext.Instance.ImgStorages.RemoveRange(list);
            AppDbContext.Instance.SaveChanges();
        }
        public void add(List<ImgStorage> listadd)
        {

            AppDbContext.Instance.ImgStorages.AddRange(listadd);
            AppDbContext.Instance.SaveChanges();

        }

        public List<ImgStorage> findByIDRoomtype(int id)
        {
            List< ImgStorage> result = AppDbContext.Instance.ImgStorages.Where(x => x.ImgstoIdrootyp ==id).ToList();
            return result;
        }
    }
}

