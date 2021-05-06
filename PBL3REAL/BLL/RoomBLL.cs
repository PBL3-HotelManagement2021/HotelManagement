using AutoMapper;
using HotelManagement.DAL.Impl;
using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.Extention;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagement.BLL.Implement
{
    public class RoomBLL
    {
        private RoomDAL _roomDAL;
        private StatusTimeDAL _statusTimeDAL;
        private StatusDAL _statusDAL;
        private MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Room, RoomVM>().ReverseMap();
            cfg.CreateMap<Status, StatusVM>().ReverseMap();
            cfg.CreateMap<StatusTime, StatusTimeVM>().ReverseMap();
            cfg.CreateMap<Room, RoomDetailVM>().ReverseMap();
        });
        private Mapper mapper;

       
        public RoomBLL()
        {
            _roomDAL = new RoomDAL();
            _statusTimeDAL = new StatusTimeDAL();
            _statusDAL = new StatusDAL();
            mapper = new Mapper(config);
        }

       /* public void editRoom1(RoomVM roomVM, List<int> listdel)
        {
            Room room = new Room();
            mapper.Map(roomVM, room);
            room.RoomIdroomtype = roomVM.MapRoomtype.First().Key;
            foreach (StatusTimeVM statusTimeVM in roomVM.ListStatusTime)
            {
                StatusTime statusTime = new StatusTime();
                mapper.Map(statusTimeVM, statusTime);
                // Status status = new Status();
                // _iMapper.Map(statusTimeVM.statusVM,status);
                // statusTime.StatimIdstatusNavigation = status;
                statusTime.StatimIdstatus = statusTimeVM.statusVM.IdStatus;
                statusTime.StatimIdroom = room.IdRoom;
                room.StatusTimes.Add(statusTime);
            }
            try
            {
                _roomDAL.update(room);
                if (listdel.Count != 0) _statusTimeDAL.delete(listdel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }*/

        public void addRoom(RoomDetailVM roomDetailVM)
        {
            int idRoom = _roomDAL.getnextid();
            Room room = new Room();
            mapper.Map(roomDetailVM, room);
            room.RoomIdroomtype = roomDetailVM.IdRoomType;
            List<StatusTime> listadd = new List<StatusTime>();
            foreach (StatusTimeVM statusTimeVM in roomDetailVM.ListStatusTime)
            {
                StatusTime statusTime = new StatusTime();
                mapper.Map(statusTimeVM, statusTime);
                statusTime.StatimIdstatus = statusTimeVM.statusVM.IdStatus;
                statusTime.StatimIdroom = idRoom;
                listadd.Add(statusTime);
            }
            try
            {
                    _roomDAL.add(room);
                _statusTimeDAL.add(listadd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void deleteRoom(List<int>listdel)
        {
          /*  List<int> listdel = new List<int>();
            foreach(StatusTime statusTime in _statusTimeDAL.findByIdRoom(id))
            {
                listdel.Add(statusTime.IdStatim);
            }
            ko can boi vi no xoa lien thong lun roi
           */
            try
            {
                _roomDAL.delete(listdel);

            }catch(Exception e)
            {
                throw;
            }

        }

        public void editRoom(RoomDetailVM roomVM, List<int> listdel)
        {
            Room room = new Room();
            mapper.Map(roomVM, room);
            room.RoomIdroomtype = roomVM.IdRoomType;
            List<StatusTime> listadd = new List<StatusTime>();
            foreach (StatusTimeVM statusTimeVM in roomVM.ListStatusTime)
            {
                StatusTime statusTime = new StatusTime();
                mapper.Map(statusTimeVM, statusTime);
                // Status status = new Status();
                // _iMapper.Map(statusTimeVM.statusVM,status);
                // statusTime.StatimIdstatusNavigation = status;
                statusTime.StatimIdstatus = statusTimeVM.statusVM.IdStatus;
                statusTime.StatimIdroom = room.IdRoom;
                if (statusTime.IdStatim == 0)   listadd.Add(statusTime);

            }
            try
            {
                _roomDAL.update(room);
                if (listdel != null) _statusTimeDAL.delete(listdel);
                if (listadd.Count != 0) _statusTimeDAL.add(listadd);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       

     

       /* public List<RoomVM> getAll1(int pages, int rows, string orderby)
        {
            int start = (pages - 1) * rows;
            int length = rows;
            List<Room> listRoom = _roomDAL.getall(start, length, orderby);
            List<RoomVM> listRoomVM = new List<RoomVM>();
            foreach (Room room in listRoom)
            {
                RoomVM roomVM = mapper.Map<RoomVM>(room);
                int id = room.RoomIdroomtypeNavigation.IdRoomtype;
                string roomname = room.RoomIdroomtypeNavigation.RotyName;
                roomVM.MapRoomtype.Add(id, roomname);
                foreach (StatusTime statusTime in room.StatusTimes)
                {
                    StatusTimeVM statusTimeVM = mapper.Map<StatusTimeVM>(statusTime);
                    statusTimeVM.statusVM = mapper.Map<StatusVM>(statusTime.StatimIdstatusNavigation);
                    roomVM.ListStatusTime.Add(statusTimeVM);
                }
                listRoomVM.Add(roomVM);
            }
            return listRoomVM;
        }*/
        public List<RoomVM> getAll(int pages, int rows, int idroomtype, string name)
        {
            int start = (pages - 1) * rows;
            int length = rows;
            List<Room> listRoom = _roomDAL.getall(start, length, idroomtype ,name);
            List<RoomVM> listRoomVM = new List<RoomVM>();
            foreach (Room room in listRoom)
            {
                RoomVM roomVM = mapper.Map<RoomVM>(room);
                roomVM.RoTyName= room.RoomIdroomtypeNavigation.RotyName;
                roomVM.RotyCurrentprice = room.RoomIdroomtypeNavigation.RotyCurrentprice;
                listRoomVM.Add(roomVM);
            }
            return listRoomVM;
        }
        public RoomDetailVM findByID(int idroom)
        {
            Room room = _roomDAL.findbyid(idroom);
            RoomDetailVM roomDetailVM = mapper.Map<RoomDetailVM>(room);
            int id = room.RoomIdroomtypeNavigation.IdRoomtype;
            string rotyname = room.RoomIdroomtypeNavigation.RotyName;
            roomDetailVM.RoTyName = rotyname;
            roomDetailVM.IdRoomType = id;
           /* roomDetailVM.MapRoomtype.Add(id, rotyname);*/
            roomDetailVM.RotyCurrentprice = room.RoomIdroomtypeNavigation.RotyCurrentprice;
            foreach (StatusTime statusTime in room.StatusTimes)
            {
                StatusTimeVM statusTimeVM = mapper.Map<StatusTimeVM>(statusTime);
                statusTimeVM.IdStatus = statusTime.StatimIdstatusNavigation.IdStatus;
                statusTimeVM.StaName = statusTime.StatimIdstatusNavigation.StaName;
                statusTimeVM.statusVM = mapper.Map<StatusVM>(statusTime.StatimIdstatusNavigation);
                roomDetailVM.ListStatusTime.Add(statusTimeVM);
            }  
            return roomDetailVM;
        }

        public List<RoomVM> findAvailableRoom(int idRoomType , string fromDate , string toDate)
        {
            List<RoomVM> listVM = new List<RoomVM>();
            foreach(Room room in _roomDAL.findAvailableRoom(idRoomType, fromDate, toDate))
            {
                RoomVM roomVM = mapper.Map<RoomVM>(room);
                listVM.Add(roomVM);
            }
            return listVM;
        }
        public List<CbbItem> addComboboxStatus()
        {
            List<CbbItem> listcbb = new List<CbbItem>();
            foreach(Status status in _statusDAL.getAll())
            {
                CbbItem cbbItem = new CbbItem
                {
                    text = status.StaName,
                    Value = status.IdStatus
                };
                listcbb.Add(cbbItem);
            }
            return listcbb;
        }
    }
    }
