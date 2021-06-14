using AutoMapper;
using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.Extention;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.BBL.Implement
{
    public class RoomTypeBLL
    {
     
        private Mapper mapper;

       
        public RoomTypeBLL()
        {
            mapper = new Mapper(MapperVM.config);
        }

        public List<RoomTypeVM> findByProperty(string search , string orderBy)
        {
            List<RoomTypeVM> listVM = new List<RoomTypeVM>();
            foreach (RoomType roomType in RoomtypeDAL.Instance.findByProperty(search,orderBy))
            {
                RoomTypeVM roomTypeVM = mapper.Map<RoomTypeVM>(roomType);
                listVM.Add(roomTypeVM);
            }
            return listVM;
        }

       

      

        public void addRoomType(RoomTypeVM roomTypeVM)
        {
            int idRoomType = RoomtypeDAL.Instance.getnextid();
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
                RoomtypeDAL.Instance.addRoomtype(roomType);
                ImgStorageDAL.Instance.add(imgstolist);
            }
            catch(Exception e)
            {

            }
           
        }
        public void editRoomType(RoomTypeVM roomTypeVM , List<int>listdel)
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
                if (listdel != null) { ImgStorageDAL.Instance.delete(listdel); }
                RoomtypeDAL.Instance.updateRoomtype(roomType);
                ImgStorageDAL.Instance.add(listadd);
            }
            catch(Exception e)
            {

            }
            
        }

        public void restoreRoomType(int idRoomType)
        {
            try
            {
                RoomtypeDAL.Instance.restoreRoomtype(idRoomType);
            }
            catch (Exception)
            {
                throw; 
            }
          
        }
        public void deleteRoomType(int idRoomType)
        {
            RoomtypeDAL.Instance.deleteRoomtype(idRoomType);
        }

        public RoomTypeVM findbyid(int id)
        {
            RoomType roomType = RoomtypeDAL.Instance.findbyid(id);
            RoomTypeVM roomTypeVM = mapper.Map<RoomTypeVM>(roomType);
            foreach (ImgStorage img in roomType.ImgStorages)
            {
                ImageVM imageVM = mapper.Map<ImageVM>(img);
                 roomTypeVM.ListImg.Add(imageVM);
            }
            return roomTypeVM;
        }

        public List<CbbItem> addCombobox()
        {

            List<CbbItem> listcbb = new List<CbbItem>();
            foreach(RoomType roomType in RoomtypeDAL.Instance.findByProperty("",""))
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


