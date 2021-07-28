using PBL3REAL.Model;
using System.Collections.Generic;

namespace PBL3REAL.DAL.Interfaces
{
    interface IRoomTypeDAL : SharedInterface<RoomType>
    {
        public List<RoomType> FindByProperty(string search, string orderby, string status);

    }
}
