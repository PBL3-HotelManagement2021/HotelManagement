using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    class BookingVM
    {
        public int IdBook { get; set; }
        public DateTime BookBookdate { get; set; }
        public DateTime BookCheckindate { get; set; }
        public string BookNote { get; set; }
        public string BookStatus { get; set; }

        public string BookCode { get; set; }
        public int BookDeposit { get; set; }
        public int BookTotalprice { get; set; }
        public DateTime BookPaymentdate { get; set; }

        public string UserCode { get; set; }
        public string CliCode { get; set; }

    }
}
