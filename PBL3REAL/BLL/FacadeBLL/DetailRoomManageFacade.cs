using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.Extention;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.FacadeBLL
{
    public class DetailRoomManageFacade
    {
        private IRoomBLL _roomBLLProvider;
        private IRoomTypeBLL _roomtypeBLLProvider;
        public DetailRoomManageFacade()
        {
            _roomBLLProvider = new QLRoomBLL();
            _roomtypeBLLProvider = new QLRoomTypeBLL();
        }

        public List<CbbItem> AddCombobox()
        {
            return _roomtypeBLLProvider.AddCombobox();
        }
        public List<CbbItem> AddComboboxStatus()
        {
           return  _roomBLLProvider.AddComboboxStatus();
        }
        public RoomDetailVM FindByID(int idRoom)
        {
            return _roomBLLProvider.FindByID(idRoom);
        }
        public void  EditRoom(RoomDetailVM roomDetailVM,List<int> listdel)
        {
            _roomBLLProvider.EditRoom(roomDetailVM, listdel);
        }
        public void AddRoom(RoomDetailVM roomDetailVM)
        {
            _roomBLLProvider.AddRoom(roomDetailVM);
        }
    }
}
