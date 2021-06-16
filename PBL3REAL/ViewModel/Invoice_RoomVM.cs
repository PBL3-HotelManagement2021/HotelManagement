using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
   public  class Invoice_RoomVM
    {
        public string Name { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }

        public int Duration { get; set; }
        public int Amount { get; set; }
    }
}
