﻿using HotelManagement.Extention;
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
            foreach (var entityEntry in _appDbContext.ChangeTracker.Entries())
            {
                Console.WriteLine(entityEntry);
            }
            try
            {
                bool tracking = _appDbContext.ChangeTracker.Entries<Room>().Any(x => x.Entity.IdRoom == room.IdRoom);
                if (tracking) throw new InvalidOperationException("Error while updating room");
                else
                {
                    _appDbContext.Rooms.Update(room);
                    _appDbContext.SaveChanges();
                    _appDbContext.Entry(room).State = EntityState.Detached;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void add(Room room)
        {
            try
            {
                _appDbContext.Rooms.Add(room);
                /*_appDbContext.Entry(room.StatusTimes).State = EntityState.Detached;*/
                _appDbContext.SaveChanges();
                _appDbContext.Entry(room).State = EntityState.Detached;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void delete(int id)
        {
            Room room = _appDbContext.Rooms.Find(id);
            if (room != null) room.RoomActiveflag = false;
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

            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@fromDate";
            parameter1.SqlDbType = SqlDbType.DateTime2;
            parameter1.Value = DateTime.Parse(fromDate.ToString());

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@toDate";
            parameter2.SqlDbType = SqlDbType.DateTime2;
            parameter2.Value = DateTime.Parse(toDate.ToString());

            List<Room> result = _appDbContext.Rooms.FromSqlRaw($"GetAvailableRoom {idRoomType} , @fromDate,@toDate", parameter1, parameter2).ToList();
            return result;
        }
        public List<Room> getall(int start, int length, int idroomtype, string name)
        {
            var predicate = PredicateBuilder.True<Room>();

            if (idroomtype != 0) predicate = predicate.And(x => x.RoomIdroomtype == idroomtype);

            if (!string.IsNullOrEmpty(name)) predicate = predicate.And(x => x.RoomName.Contains(name));



            var result = _appDbContext.Rooms.Where(predicate).Include(x => x.RoomIdroomtypeNavigation)
                                            .Skip(start).Take(length)
                                            .AsNoTracking()
                                            .ToList();
            return result;
        }
        public List<Room> findByIdBook(int idbook)
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
                                         RoomIdroomtypeNavigation = new RoomType()
                                         {
                                             RotyCurrentprice = roty.RotyCurrentprice
                                         }
                                     }).ToList();

            return joinResult;
        }
        public int getTotalRow()
        {
            int rows = 0;
            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Exec TotalRows room";
                _appDbContext.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    result.Read();
                    rows = (int)result[0];
                }
            }
            return rows;
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