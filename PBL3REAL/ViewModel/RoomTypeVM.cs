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
        public string RotyName { get; set; }
        public string RotyDescription { get; set; }
        public decimal RotyCurrentprice { get; set; }
        public int RotyCapacity { get; set; }

       /* public IDictionary<int, string> MapImgUrl { get; set; }*/
        public List<ImageVM> ListImg { get; set; }
        public static bool compareName(RoomTypeVM r1, RoomTypeVM r2)
        {
            if (string.Compare(r1.RotyName, r2.RotyName) > 0)
                return true;
            else return false;
        }
        public static bool comparePrice(RoomTypeVM r1, RoomTypeVM r2)
        {
            if (r1.RotyCurrentprice > r2.RotyCurrentprice)
                return true;
            else return false;
        }
        public static bool compareCapacity(RoomTypeVM r1, RoomTypeVM r2)
        {
            if (r1.RotyCapacity > r2.RotyCapacity)
                return true;
            else return false;
        }
    }
}
