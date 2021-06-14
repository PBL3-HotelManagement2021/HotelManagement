using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.ViewModel
{
    public class RoomTypeVM
    {
        public RoomTypeVM()
        {
            ListImg = new List<ImageVM>();
           /* MapImgUrl = new Dictionary<int, string>();*/
        }
        public int IdRoomtype { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool RoTyActiveflag { get; set; }
        public int Capacity { get; set; }
        public string Code { get; set; }

        /* public IDictionary<int, string> MapImgUrl { get; set; }*/
        public List<ImageVM> ListImg { get; set; }
    }
}
