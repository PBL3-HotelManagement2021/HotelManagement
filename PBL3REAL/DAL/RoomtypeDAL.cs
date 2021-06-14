
using HotelManagement.Extention;
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
   public class RoomtypeDAL 
    {
        public static RoomtypeDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RoomtypeDAL();
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private static RoomtypeDAL _Instance;
        public RoomtypeDAL()
        {
        }


        public List<RoomType> findByProperty(string search , string orderby,string status)
        {
            var predicate = PredicateBuilder.True<RoomType>();

            if (!string.IsNullOrEmpty(search)) predicate = predicate.And(x => x.RotyName.Contains(search) || x.RotyCode.Contains(search));

            if (status == "Active") predicate = predicate.And(x => x.RoTyActiveflag == true);
            else  predicate = predicate.And(x => x.RoTyActiveflag == false);

            var query = AppDbContext.Instance.RoomTypes.Where(predicate);
            switch (orderby)
            {
                case "None": break;
                case "Current Price Asc" :  query = query.OrderBy(x => x.RotyCurrentprice); break;
                case "Current Price Desc": query = query.OrderByDescending(x => x.RotyCurrentprice); break;
                default: break;
            }
            List<RoomType> result = query.AsNoTracking().ToList();
            return result;
        }

        public void addRoomtype(RoomType roomType)
        {
            roomType.RoTyActiveflag = true;
            AppDbContext.Instance.RoomTypes.Add(roomType);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(roomType).State = EntityState.Detached;
        }

        public void deleteRoomtype(int idRoomtype)
        {
            RoomType roomType = AppDbContext.Instance.RoomTypes.Where(x =>x.IdRoomtype == idRoomtype).SingleOrDefault();
            if (roomType != null)
            {
                roomType.RoTyActiveflag = false;
                AppDbContext.Instance.Update(roomType);
                AppDbContext.Instance.SaveChanges();
                AppDbContext.Instance.Entry(roomType).State = EntityState.Detached;
            }
            else throw new ArgumentException("Error while deleting roomtype");
        }

        public void restoreRoomtype(int idRoomtype)
        {
            RoomType roomType = AppDbContext.Instance.RoomTypes.Where(x => x.IdRoomtype == idRoomtype).SingleOrDefault();
            if (roomType != null)
            {
                roomType.RoTyActiveflag = true;
                AppDbContext.Instance.Update(roomType);
                AppDbContext.Instance.SaveChanges();
                AppDbContext.Instance.Entry(roomType).State = EntityState.Detached;               
            }
            else throw new ArgumentException("Error while restoring roomtype");
        }

        public void updateRoomtype(RoomType roomType)
        {
            AppDbContext.Instance.RoomTypes.Update(roomType);
            AppDbContext.Instance.SaveChanges();
            AppDbContext.Instance.Entry(roomType).State = EntityState.Detached;
        }


        public int getnextid()
        {
            int id;
            using (var command = AppDbContext.Instance.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT IDENT_CURRENT('room_type')+1";
                AppDbContext.Instance.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    result.Read();
                    id = Decimal.ToInt32((decimal)result[0]);
                }
            }
            return id;
        }

        public RoomType findbyid(int id)
        {
            RoomType roomType = (RoomType)AppDbContext.Instance.RoomTypes.Where(x => x.IdRoomtype == id).Include(x => x.ImgStorages).SingleOrDefault();
            if (roomType != null) AppDbContext.Instance.Entry(roomType).State = EntityState.Detached;
            return roomType;
        }
    }
}

