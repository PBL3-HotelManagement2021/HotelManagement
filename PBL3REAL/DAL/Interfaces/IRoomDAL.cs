using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IRoomDAL : SharedInterface<Room>
    {
        public List<Room> FindAvailableRoom(int idRoomType, DateTime fromDate, DateTime toDate);
        public List<Room> FindByProperty(int start, int length, int idroomtype, string name, int isActive);
        public List<Room> FindByIdBook(int idbook);
        public int GetTotalRow(int idRoomType, string name, int isActive);

    }
}
