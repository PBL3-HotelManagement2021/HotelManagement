using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using PBL3REAL.Model;

namespace HotelManagement.DAL.Impl
{
    public class StatusTimeDAL 
    {
        public static StatusTimeDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new StatusTimeDAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private static StatusTimeDAL _Instance;
        public StatusTimeDAL()
        {
        }

        public void add(List<StatusTime> listadd)
        {
            try{
                AppDbContext.Instance.StatusTimes.AddRange(listadd);
                AppDbContext.Instance.SaveChanges();
            }catch(Exception e){
                throw ;
            }

        }
       

        public List<StatusTime> findByIdRoom(int idroom)
        {
            return AppDbContext.Instance.StatusTimes.Where(x => x.StatimIdroom == idroom).AsNoTracking().ToList();
        }
        public void delete(List<int> listdel)
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

        public void update(List<StatusTime>listedit){
                AppDbContext.Instance.StatusTimes.UpdateRange(listedit);
                AppDbContext.Instance.SaveChanges();           
        }
    }
}