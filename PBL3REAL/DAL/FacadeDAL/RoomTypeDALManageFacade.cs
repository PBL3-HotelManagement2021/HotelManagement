using HotelManagement.DAL.Implement;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Facade
{
    public class RoomTypeDALManageFacade
    {
        private IRoomTypeDAL _roomtypeDALProvider;
        private IImgStorageDAL _imgStorageDALProvider;

        public RoomTypeDALManageFacade()
        {
            _roomtypeDALProvider = new RoomtypeDAL();
            _imgStorageDALProvider = new ImgStorageDAL();
        }

        public List<RoomType> FindRoomtype(string search, string orderby, string status)
        {
            return _roomtypeDALProvider.FindByProperty(search, orderby, status);
        }
        public void AddRoomtype(RoomType roomType)
        {
            _roomtypeDALProvider.Add(roomType);
        }

        public void DeleteRoomtype(int idRoomtype)
        {
            _roomtypeDALProvider.Delete(idRoomtype);
        }
        public void RestoreRoomtype(int idRoomtype)
        {
            _roomtypeDALProvider.Restore(idRoomtype);
        }
        public void UpdateRoomtype(RoomType roomType)
        {
            _roomtypeDALProvider.Update(roomType);
        }
        public int GetnextidRoomType()
        {
            return _roomtypeDALProvider.GetNextId();
        }
        public RoomType FindRoomtypeById(int id)
        {
            return _roomtypeDALProvider.FindById(id);
        }

        public void DeleteImage(List<int> listdel)
        {
            _imgStorageDALProvider.Delete(listdel);
        }
        public void AddImage(List<ImgStorage> listadd)
        {
            _imgStorageDALProvider.Add(listadd);
        }

    }
}
