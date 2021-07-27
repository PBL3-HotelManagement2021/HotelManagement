using HotelManagement.ViewModel;
using PBL3REAL.Extention;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.Interfaces
{
    interface IRoomTypeBLL
    {
        public List<RoomTypeVM> FindByProperty(string search, string orderBy, string status);
        public void AddRoomType(RoomTypeVM roomTypeVM);
        public void EditRoomType(RoomTypeVM roomTypeVM, List<int> listdel);
        public void RestoreRoomType(int idRoomType);
        public void DeleteRoomType(int idRoomType);
        public RoomTypeVM Findbyid(int id);

        public List<CbbItem> AddCombobox();
    }
}
