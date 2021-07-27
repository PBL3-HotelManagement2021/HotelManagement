using HotelManagement.ViewModel;
using PBL3REAL.Extention;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.Interfaces
{
    interface IRoomBLL
    {
        public void AddRoom(RoomDetailVM roomDetailVM);
        public void DeleteRoom(int id);
        public void RestoreRoom(int id);
        public void EditRoom(RoomDetailVM roomVM, List<int> listdel);
        public List<RoomVM> FindByProperty(int pages, int rows, int idroomtype, string name, int isActive);
        public RoomDetailVM FindByID(int idroom);
        public List<AvailableRoomVM> FindAvailableRoom(int idRoomType, DateTime fromDate, DateTime toDate);
        public List<CbbItem> AddComboboxStatus();
        public int GetPagination(int rows, int idRoomType, string name, int isActive);





        }
}
