
using HotelManagement.Extention;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelManagement.DAL.Implement
{
    public class RoomDAL
    {
        private AppDbContext _appDbContext;
        public RoomDAL()
        {
            _appDbContext = new AppDbContext();
        }

        public void update(Room room)
        {
            _appDbContext.Rooms.Update(room);
            _appDbContext.SaveChanges();
            _appDbContext.Entry(room).State = EntityState.Detached;           
        }

        public void add(Room room)
        {
            room.RoomActiveflag = true;
            _appDbContext.Rooms.Add(room);
                /*_appDbContext.Entry(room.StatusTimes).State = EntityState.Detached;*/
                _appDbContext.SaveChanges();
                _appDbContext.Entry(room).State = EntityState.Detached;         
        }
        public void delete(int id)
        {
                 Room room = _appDbContext.Rooms.Where(x => x.IdRoom ==id).SingleOrDefault();
                 if (room != null) room.RoomActiveflag = false;
                _appDbContext.Rooms.Update(room);
                _appDbContext.SaveChanges();  
        }

        public void restore(int id)
        {
            Room room = _appDbContext.Rooms.Where(x => x.IdRoom == id).SingleOrDefault();
            if (room != null) room.RoomActiveflag = true;
            _appDbContext.Rooms.Update(room);
            _appDbContext.SaveChanges();
        }
        public Room findbyid(int id)
        {
            var result = _appDbContext.Rooms.Where(x => x.IdRoom == id).Include(x => x.RoomIdroomtypeNavigation)
                                           .Include(x => x.StatusTimes)
                                           .ThenInclude(y => y.StatimIdstatusNavigation)
                                           .AsNoTracking()
                                           .SingleOrDefault();
            return result;
        }

      

        public List<Room> findAvailableRoom(int idRoomType, DateTime fromDate, DateTime toDate)
        {
            SqlParameter parameter0 = new SqlParameter();
            parameter0.ParameterName = "@pa0";
            parameter0.SqlDbType = SqlDbType.Int;
            parameter0.Value = idRoomType;

            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@pa1";
            parameter1.SqlDbType = SqlDbType.DateTime2;
            parameter1.Value = DateTime.Parse(fromDate.ToString());

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@pa2";
            parameter2.SqlDbType = SqlDbType.DateTime2;
            parameter2.Value = DateTime.Parse(toDate.ToString());
            List<Room> list = new List<Room>();
         
            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "exec [GetAvailableRoom] @IdRoomType=@pa0 , @fromDate =@pa1, @toDate=@pa2";
                command.Parameters.Add(parameter0);
                command.Parameters.Add(parameter1);
                command.Parameters.Add(parameter2);
                _appDbContext.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        Room room = new Room();
                        room.RoomIdroomtypeNavigation = new RoomType();
                        room.IdRoom =(int) result[0];
                        room.RoomName = result[1].ToString();
                        room.RoomIdroomtypeNavigation.RotyName = result[2].ToString();
                        room.RoomIdroomtypeNavigation.RotyCurrentprice =(int) result[3];
                        room.RoomIdroomtypeNavigation.RotyCode = result[4].ToString();
                        list.Add(room);
                    }
                }
            }
            return list;
        }
        public List<Room> findByProperty(int start, int length, int idroomtype, string name,int isActive)
        {
            var predicate = PredicateBuilder.True<Room>();

            if (idroomtype != 0) predicate = predicate.And(x => x.RoomIdroomtype == idroomtype);

            if (!string.IsNullOrEmpty(name)) predicate = predicate.And(x => x.RoomName.Contains(name));

            if (isActive == 1) predicate = predicate.And(x => x.RoomActiveflag == true);
            else if (isActive == 2) predicate = predicate.And(x => x.RoomActiveflag == false);

            var result = _appDbContext.Rooms.Where(predicate).Include(x => x.RoomIdroomtypeNavigation)
                                            .Skip(start).Take(length)
                                            .AsNoTracking()
                                            .ToList();
            return result;
        }
        public List<Room>findByIdBook(int idbook)
        {
            Room result = new Room();
            List<Room> joinResult = (from room in AppDbContext.Instance.Rooms
                                     join roty in AppDbContext.Instance.RoomTypes on room.RoomIdroomtype equals roty.IdRoomtype
                                     join bkdt in AppDbContext.Instance.BookingDetails on room.IdRoom equals bkdt.BoodetIdroom
                                     join book in AppDbContext.Instance.Bookings on bkdt.BoodetIdbook equals book.IdBook
                                     where book.IdBook == idbook
                                     select new Room()
                                     {
                                         RoomName = room.RoomName,
                                         RoomIdroomtypeNavigation = new RoomType() {
                                         RotyName = roty.RotyName,
                                         RotyCurrentprice = bkdt.BoodetPrice
                                         }
                                     }).AsNoTracking().ToList();
         
            return joinResult;
        }
        public int getTotalRow(int idRoomType, string name, int isActive)
        {
            int totalrows = 0;
            var predicate = PredicateBuilder.True<Room>();
            if (idRoomType != 0) predicate = predicate.And(x => x.RoomIdroomtype == idRoomType);

            if (!string.IsNullOrEmpty(name)) predicate = predicate.And(x => x.RoomName.Contains(name));

            if (isActive == 1) predicate = predicate.And(x => x.RoomActiveflag == true);
            else if (isActive == 2) predicate = predicate.And(x => x.RoomActiveflag == false);
            totalrows = AppDbContext.Instance.Rooms.Where(predicate).Count();
            return totalrows;
        }


        public int getnextid()
        {
            int id;
            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT IDENT_CURRENT('room')+1";
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
