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
        public RoomBLL()
        {
            mapper = new Mapper(MapperVM.config);
        }
        public void addRoom(RoomDetailVM roomDetailVM)
        {
            var test = RoomDAL.Instance.findByProperty(1, 1, 0, roomDetailVM.RoomName,0);
            if (test.Count!=0) throw new ArgumentException("Room Name already existed");
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

            }catch(Exception e)
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
                if (statusTime.IdStatim == 0)   listadd.Add(statusTime);

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
        public List<RoomVM> findByProperty(int pages, int rows, int idroomtype, string name,int isActive)
        {
            int start = (pages - 1) * rows;
            int length = rows;
            List<Room> listRoom = RoomDAL.Instance.findByProperty(start, length, idroomtype ,name,isActive);
            List<RoomVM> listRoomVM = new List<RoomVM>();
            foreach (Room room in listRoom)
            {
                RoomVM roomVM = mapper.Map<RoomVM>(room);
                roomVM.Index = ++start;
                roomVM.RoomType= room.RoomIdroomtypeNavigation.RotyName;
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

        public List<AvailableRoomVM> findAvailableRoom(int idRoomType , DateTime fromDate , DateTime toDate)
        {
            List<AvailableRoomVM> listVM = new List<AvailableRoomVM>();
            foreach(Room room in RoomDAL.Instance.findAvailableRoom(idRoomType, fromDate, toDate))
            {
                AvailableRoomVM availableRoomVM = mapper.Map<AvailableRoomVM>(room);
                listVM.Add(availableRoomVM);
            }
            return listVM;
        }
        public List<CbbItem> addComboboxStatus()
        {
            List<CbbItem> listcbb = new List<CbbItem>();
            foreach(Status status in StatusDAL.Instance.getAll())
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

        public int getPagination(int rows ,int idRoomType, string name,int isActive)
        {
            int totalRows = RoomDAL.Instance.getTotalRow(idRoomType,name,isActive);
            int totalpage;
            if (totalRows % rows == 0)
            {
                totalpage = totalRows / rows;
            }
            else
            {
                totalpage = totalRows / rows + 1;
            }
            return totalpage;
        }
    }
}
