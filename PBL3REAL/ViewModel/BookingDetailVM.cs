﻿using System;
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
        public string CliName { get; set; }
        public string CliPhone { get; set; }
        public string CliGmail { get; set; }
        public List<SubBookingDetailVM>List { get; set; }
    }
}
