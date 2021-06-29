using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    public class InvoiceVM
    {
        public InvoiceVM()
        {
        }
        public int Index { get; set; }
        public int IdInvoice { get; set; }

        public int InvIdbook { get; set;  }
        public DateTime InvCreatedate { get; set; }
        public DateTime InvUpdatedate { get; set; }
        public string InvCode { get; set; }
        public int TotalPrice { get; set; }
        public string InvStatus { get; set; }
    }
}
