using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
   public  class BookingVM
    {
        public int Index { get; set; }
        public int IdBook { get; set; }
        public string Code { get; set; }
        public DateTime BookDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
       
        public string Status { get; set; }
        public string BookNote { get; set; }
        public int Deposit { get; set; }
        public int TotalPrice { get; set; }
        public string UserCode { get; set; }
        public string CliCode { get; set; }

    }
}
