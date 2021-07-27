using AutoMapper;
using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.DAL.Facade;
using PBL3REAL.Extention;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.BBL.Implement
{
    public class QLRoomTypeBLL : IRoomTypeBLL
    {
     
        private Mapper mapper;
        private RoomTypeDALManageFacade _roomTypeDALManageFacade;

        public QLRoomTypeBLL()
        {
            mapper = new Mapper(MapperVM.config);
            _roomTypeDALManageFacade = new RoomTypeDALManageFacade();
        }

        public List<RoomTypeVM> FindByProperty(string search , string orderBy,string status)
        {
            List<RoomTypeVM> listVM = new List<RoomTypeVM>();
            foreach (RoomType roomType in _roomTypeDALManageFacade.FindRoomtype(search,orderBy,status))
            {
                RoomTypeVM roomTypeVM = mapper.Map<RoomTypeVM>(roomType);
                listVM.Add(roomTypeVM);
            }
            return listVM;
        }
        public void AddRoomType(RoomTypeVM roomTypeVM)
        {
            int idRoomType = _roomTypeDALManageFacade.GetnextidRoomType();
            RoomType roomType = new RoomType();
            List<ImgStorage> imgstolist = new List<ImgStorage>();
            mapper.Map(roomTypeVM, roomType);
            roomType.RoTyActiveflag = true;
            foreach(ImageVM imageVM in roomTypeVM.ListImg)
            {
                ImgStorage imgStorage = new ImgStorage();
                mapper.Map(imageVM, imgStorage);
                imgStorage.ImgstoIdrootyp = idRoomType;
                imgstolist.Add(imgStorage);
            }
            roomType.ImgStorages = imgstolist;
            try
            {
                _roomTypeDALManageFacade.AddRoomtype(roomType);
                _roomTypeDALManageFacade.AddImage(imgstolist);
            }
            catch(Exception e)
            {

            }
           
        }
        public void EditRoomType(RoomTypeVM roomTypeVM , List<int>listdel)
        {
            RoomType roomType = new RoomType();
            mapper.Map(roomTypeVM, roomType);
            List<ImgStorage> listadd = new List<ImgStorage>();
            foreach(ImageVM imageVM in roomTypeVM.ListImg)
            {
                ImgStorage imgStorage = new ImgStorage();
                mapper.Map(imageVM, imgStorage);
                imgStorage.ImgstoIdrootyp = roomType.IdRoomtype;
                if (imageVM.IdImgsto == 0) listadd.Add(imgStorage);
            }
           
            try
            {
                if (listdel != null) { _roomTypeDALManageFacade.DeleteImage(listdel); }
                _roomTypeDALManageFacade.UpdateRoomtype(roomType);
                _roomTypeDALManageFacade.AddImage(listadd);
            }
            catch(Exception e)
            {

            }
            
        }

        public void RestoreRoomType(int idRoomType)
        {
            _roomTypeDALManageFacade.RestoreRoomtype(idRoomType);         
        }
        public void DeleteRoomType(int idRoomType)
        {
            _roomTypeDALManageFacade.DeleteRoomtype(idRoomType);
        }

        public RoomTypeVM Findbyid(int id)
        {
            RoomType roomType = _roomTypeDALManageFacade.FindRoomtypeById(id);
            RoomTypeVM roomTypeVM = mapper.Map<RoomTypeVM>(roomType);
            foreach (ImgStorage img in roomType.ImgStorages)
            {
                ImageVM imageVM = mapper.Map<ImageVM>(img);
                 roomTypeVM.ListImg.Add(imageVM);
            }
            return roomTypeVM;
        }

        public List<CbbItem> AddCombobox()
        {

            List<CbbItem> listcbb = new List<CbbItem>();
            foreach(RoomType roomType in _roomTypeDALManageFacade.FindRoomtype("","","Active"))
            {
                CbbItem cbbItem = new CbbItem
                {
                    text = roomType.RotyName,
                    Value = roomType.IdRoomtype,
                };
                listcbb.Add(cbbItem);
            }
            return listcbb;
        }
    }
}


