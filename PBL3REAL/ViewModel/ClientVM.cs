using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
   public class ClientVM
    { 
        public int Index { get; set; }
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Gmail { get; set; }

        public bool CliActiveflag { get; set; }
    }
}
