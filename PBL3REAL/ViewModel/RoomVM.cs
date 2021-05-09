using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    public class RoomVM
    {
        public int IdRoom { get; set; }
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }
        public decimal RotyCurrentprice { get; set; }
        public string RoTyName { get; set; }

        public static bool compareName(RoomVM r1, RoomVM r2)
        {
            if (string.Compare(r1.RoomName, r2.RoomName) > 0)
                return true;
            else return false;
        }
        public static bool comparePrice(RoomVM r1, RoomVM r2)
        {
            if (r1.RotyCurrentprice > r2.RotyCurrentprice)
                return true;
            else return false;
        }
        public static bool compareRoTyName(RoomVM r1, RoomVM r2)
        {
            if (string.Compare(r1.RoTyName,r2.RoTyName) > 0)
                return true;
            else return false;
        }
    }
}
