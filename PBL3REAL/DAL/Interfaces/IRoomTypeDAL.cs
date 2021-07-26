using PBL3REAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IRoomTypeDAL
    {
        public List<RoomType> FindByProperty(string search, string orderby, string status);
        public void AddRoomtype(RoomType roomType);

        public void DeleteRoomtype(int idRoomtype);
        public void restoreRoomtype(int idRoomtype);
        public void UpdateRoomtype(RoomType roomType);
        public int Getnextid();
        public RoomType Findbyid(int id);

    }
}
