using System;
using System.Collections.Generic;

namespace PBL3REAL.ViewModel
{
    public class InvoiceDetailVM 
    {
        public InvoiceDetailVM()
        {
            ListRoom = new List<Invoice_RoomVM>();
        }
        public int IdInvoice { get; set; }

        public int InvIdbook { get; set; }
        public DateTime InvCreatedate { get; set; }
        public DateTime InvUpdatedate { get; set; }
        public string InvCode { get; set; }
        public string InvStatus { get; set; }
        public int TotalPrice { get; set; }

        //     public int InvIdbook { get; set; }
        public DateTime BookBookDate { get; set; }
        public DateTime BookCheckindate { get; set; }

        public DateTime BookChecoutdate { get; set; }


        public string BookCode { get; set; }

        /*   public int InvIdUser { get; set; }*/
        public string UserCode { get; set; }
        /*   public int InvIdClient { get; set; }*/
        public string CliCode { get; set; }
        public string CliName { get; set; }
        public string CliPhone { get; set; }
        public string CliGmail { get; set; }

        public List<Invoice_RoomVM> ListRoom { get; set; }
    }
}
