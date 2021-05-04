using AutoMapper;
using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.BBL.Implement
{
    public class RoomTypeBLL
    {
        private RoomtypeDAL _roomTypeDAL;
        private ImgStorageDAL _imgStorageDAL;
        private MapperConfiguration config = new MapperConfiguration(cfg =>
                       cfg.CreateMap<RoomType, RoomTypeVM>().ReverseMap()
                   );
        private Mapper mapper;

        private static RoomTypeBLL _Instance;
        public static RoomTypeBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RoomTypeBLL();
                }
                return _Instance;
            }
            private set { }
        }
        public RoomTypeBLL()
        {
            _roomTypeDAL = new RoomtypeDAL();
            _imgStorageDAL = new ImgStorageDAL();
            mapper = new Mapper(config);
        }

        public List<RoomTypeVM> getAll()
        {
            
            var result = _roomTypeDAL.getAll();
            List<string> imgUrlList = new List<string>();
            List<RoomTypeVM> listVM = new List<RoomTypeVM>();
            foreach (RoomType roomType in _roomTypeDAL.getAll())
            {
                RoomTypeVM roomTypeVM = mapper.Map<RoomTypeVM>(roomType);
                foreach (ImgStorage imgStorage in roomType.ImgStorages)
                {
                    roomTypeVM.MapImgUrl.Add(imgStorage.IdImgsto, imgStorage.ImgstoUrl);
                }
                listVM.Add(roomTypeVM);
            }
            return listVM;
        }

       

        public void addRoomType(RoomTypeVM roomTypeVM)
        {
            int idRoomType = _roomTypeDAL.getnextid();
            RoomType roomType = new RoomType();
            List<ImgStorage> imgstolist = new List<ImgStorage>();
            mapper.Map(roomTypeVM, roomType);
            foreach (KeyValuePair<int, string> kvp in roomTypeVM.MapImgUrl)
            {
                ImgStorage imgStorage = new ImgStorage();
                imgStorage.ImgstoUrl = kvp.Value;
                imgStorage.ImgstoIdrootyp = idRoomType;
                imgstolist.Add(imgStorage);
            }
            roomType.ImgStorages = imgstolist;
            _roomTypeDAL.addRoomtype(roomType);
        }

        public void editRoomType(RoomTypeVM roomTypeVM)
        {
            RoomType roomType = new RoomType();
            mapper.Map(roomTypeVM, roomType);
            // foreach(string imgurl in roomTypeVM.ListImgURL){
            //     ImgStorage imgStorage = new ImgStorage();
            // }
            List<int> img_del = new List<int>();
            foreach (KeyValuePair<int, string> kvp in roomTypeVM.MapImgUrl)
            {
                if (kvp.Value == "")
                {
                    img_del.Add(kvp.Key);
                }
                else
                {
                    ImgStorage imgStorage = new ImgStorage();
                    if (kvp.Key > 0) imgStorage.IdImgsto = kvp.Key;

                    imgStorage.ImgstoIdrootyp = roomTypeVM.IdRoomtype;
                    imgStorage.ImgstoUrl = kvp.Value;
                    roomType.ImgStorages.Add(imgStorage);
                }

            }
            foreach (int val in img_del)
            {
                _imgStorageDAL.delete(val);
            }
            _roomTypeDAL.updateRoomtype(roomType);
        }

        public void deleteRoomType(int idRoomType)
        {
            throw new System.NotImplementedException();
        }

        public RoomTypeVM findbyid(int id)
        {
            RoomType roomType = _roomTypeDAL.findbyid(id);
            RoomTypeVM roomTypeVM = mapper.Map<RoomTypeVM>(roomType);
            foreach (ImgStorage img in roomType.ImgStorages)
            {
                // roomTypeVM.ListImgURL.Add(img.ImgstoUrl);
                roomTypeVM.MapImgUrl.Add(img.IdImgsto, img.ImgstoUrl);
            }
            return roomTypeVM;
        }
    }
}


