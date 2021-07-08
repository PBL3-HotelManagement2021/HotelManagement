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
        private Mapper mapper;

        public delegate bool Compare(RoomVM r1, RoomVM r2);
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

        public RoomBLL()
        {
            mapper = new Mapper(MapperVM.config);
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
            var test = RoomDAL.Instance.findByProperty(1, 1, 0, roomDetailVM.RoomName, 0);
            if (test.Count != 0) throw new ArgumentException("Room Name already existed");
            int idRoom = RoomDAL.Instance.getnextid();
            Room room = new Room();
            mapper.Map(roomDetailVM, room);
            room.RoomIdroomtype = roomDetailVM.IdRoomType;
            room.RoomActiveflag = true;
            List<StatusTime> listadd = new List<StatusTime>();
            foreach (StatusTimeVM statusTimeVM in roomDetailVM.ListStatusTime)
            {
                StatusTime statusTime = new StatusTime();
                mapper.Map(statusTimeVM, statusTime);
                statusTime.StatimIdstatus = statusTimeVM.IdStatus;
                statusTime.StatimIdroom = idRoom;
                listadd.Add(statusTime);
            }
            try
            {
                RoomDAL.Instance.add(room);
                StatusTimeDAL.Instance.add(listadd);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void deleteRoom(int id)
        {
            try
            {
                RoomDAL.Instance.delete(id);

            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void restoreRoom(int id)
        {
            try
            {
                RoomDAL.Instance.restore(id);

            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void editRoom(RoomDetailVM roomVM, List<int> listdel)
        {
            Room room = new Room();
            mapper.Map(roomVM, room);
            room.RoomIdroomtype = roomVM.IdRoomType;
            room.RoomActiveflag = true;
            List<StatusTime> listadd = new List<StatusTime>();
            foreach (StatusTimeVM statusTimeVM in roomVM.ListStatusTime)
            {
                StatusTime statusTime = new StatusTime();
                mapper.Map(statusTimeVM, statusTime);
                // Status status = new Status();
                // _iMapper.Map(statusTimeVM.statusVM,status);
                // statusTime.StatimIdstatusNavigation = status;
                statusTime.StatimIdstatus = statusTimeVM.IdStatus;
                statusTime.StatimIdroom = room.IdRoom;
                if (statusTime.IdStatim == 0) listadd.Add(statusTime);

            }
            try
            {
                RoomDAL.Instance.update(room);
                if (listdel != null) StatusTimeDAL.Instance.delete(listdel);
                if (listadd.Count != 0) StatusTimeDAL.Instance.add(listadd);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<RoomVM> findByProperty(int pages, int rows, int idroomtype, string name, int isActive)
        {
            int start = (pages - 1) * rows;
            int length = rows;
            List<Room> listRoom = RoomDAL.Instance.findByProperty(start, length, idroomtype, name, isActive);
            List<RoomVM> listRoomVM = new List<RoomVM>();
            foreach (Room room in listRoom)
            {
                RoomVM roomVM = mapper.Map<RoomVM>(room);
                roomVM.Index = ++start;
                roomVM.RoomType = room.RoomIdroomtypeNavigation.RotyName;
                roomVM.Price = room.RoomIdroomtypeNavigation.RotyCurrentprice;
                listRoomVM.Add(roomVM);
            }
            return listRoomVM;
        } 
        public RoomDetailVM findByID(int idroom)
        {
            Room room = RoomDAL.Instance.findbyid(idroom);
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
                /*                statusTimeVM.statusVM = mapper.Map<StatusVM>(statusTime.StatimIdstatusNavigation);*/
                roomDetailVM.ListStatusTime.Add(statusTimeVM);
            }
            return roomDetailVM;
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
        public void sort(List<RoomVM> arr, Compare d1)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (d1(arr[i], arr[j]))
                    {
                        RoomVM temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
    }
