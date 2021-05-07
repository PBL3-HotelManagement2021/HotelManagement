using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    class BookingDetailVM : BookingVM
    {
        public BookingDetailVM()
        {
            List = new List<SubBookingDetailVM>();
        }
    
        public ClientVM clientVM { get; set; }
        public List<SubBookingDetailVM>List { get; set; }
    }
}
