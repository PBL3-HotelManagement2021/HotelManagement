using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;

namespace HotelManagement.DAL.Impl
{
    public class StatusTimeDAL : IStatusTimeDAL
    {
       
        public StatusTimeDAL()
        {
        }

        public void Add(List<StatusTime> listadd)
        {
            AppDbContext.Instance.StatusTimes.AddRange(listadd);
            AppDbContext.Instance.SaveChanges();


        }
       

        public List<StatusTime> FindByIdRoom(int idroom)
        {
            return AppDbContext.Instance.StatusTimes.Where(x => x.StatimIdroom == idroom).AsNoTracking().ToList();
        }
        public void Delete(List<int> listdel)
        {
            List<StatusTime>list = new List<StatusTime>();
            foreach(int id in listdel){
                StatusTime statusTime = AppDbContext.Instance.StatusTimes.Find(id);
                AppDbContext.Instance.Entry(statusTime).State = EntityState.Detached;
                if(statusTime !=null) list.Add(statusTime);
            }
            AppDbContext.Instance.RemoveRange(list);
            AppDbContext.Instance.SaveChanges();
        }

        public void Update(List<StatusTime> listedit)
        {
                AppDbContext.Instance.StatusTimes.UpdateRange(listedit);
                AppDbContext.Instance.SaveChanges();           
        }
    }
}