
using Microsoft.EntityFrameworkCore;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
    public class ImgStorageDAL : IImgStorageDAL
    {
     
        public ImgStorageDAL()
        {
        }

       
        public void Delete(List<int> listdel)
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
        public void Add(List<ImgStorage> listadd)
        {

            AppDbContext.Instance.ImgStorages.AddRange(listadd);
            AppDbContext.Instance.SaveChanges();

        }

        public List<ImgStorage> FindByIDRoomtype(int id)
        {
            List< ImgStorage> result = AppDbContext.Instance.ImgStorages.Where(x => x.ImgstoIdrootyp ==id).ToList();
            return result;
        }
    }
}

