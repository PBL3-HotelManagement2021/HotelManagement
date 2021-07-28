using HotelManagement.DAL.Impl;
using HotelManagement.DAL.Implement;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Facade
{
    public class RoomDALManageFacade
    {
        private IRoomDAL _roomDALProvider;
        private IStatusTimeDAL _statustimeProvider;
        private IStatusDAL _statusDALProvider;
        public RoomDALManageFacade()
        {
            _roomDALProvider = new RoomDAL();
            _statustimeProvider = new StatusTimeDAL();
            _statusDALProvider = new StatusDAL();
        }

        public void UpdateRoom(Room room)
        {
            _roomDALProvider.Update(room);
        }
        public void AddRoom(Room room)
        {
            _roomDALProvider.Add(room);
        }
        public void DeleteRoom(int id)
        {
            _roomDALProvider.Delete(id);
        }
        public void RestoreRoom(int id)
        {
            _roomDALProvider.Restore(id);
        }
        public Room FindRoomById(int id)
        {
            return _roomDALProvider.FindById(id);
        }
        public List<Room> FindAvailableRoom(int idRoomType, DateTime fromDate, DateTime toDate)
        {
            return _roomDALProvider.FindAvailableRoom(idRoomType, fromDate, toDate);
        }
        public List<Room> FindRoom(int start, int length, int idroomtype, string name, int isActive)
        {
            return _roomDALProvider.FindByProperty(start, length,idroomtype, name, isActive);
        }
  
        public int GetRoomTotalRow(int idRoomType, string name, int isActive)
        {
            return _roomDALProvider.GetTotalRow(idRoomType, name, isActive);
        }


        public int GetRoomNextid()
        {
            return _roomDALProvider.GetNextId();
        }

        public void AddStatus(List<StatusTime> listadd)
        {
            _statustimeProvider.Add(listadd);
        }
        public void DeleteStatus(List<int> listdel)
        {
            _statustimeProvider.Delete(listdel);
        }
   

        public List<Status> GetAllStatus()
        {
            return _statusDALProvider.GetAll();
        }
    }
}
