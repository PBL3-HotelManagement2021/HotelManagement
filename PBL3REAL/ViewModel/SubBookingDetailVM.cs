using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    public class SubBookingDetailVM
    {
        public int IdBoodet { get; set; }
 
        public int BoodetIdroom { get; set; }
        public string BoodetRoTyCode { get; set; }
        public int BoodetIdbook { get; set; }

        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public int BoodetPrice { get; set; }
        public int Duration { get; set; }
        public int Amount { get; set; }

    }
}
