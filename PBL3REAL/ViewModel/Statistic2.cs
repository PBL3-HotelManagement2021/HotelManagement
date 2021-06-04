using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.ViewModel
{
    public class Statistic2
    {
        public Statistic2()
        {
            TotalGroupBy = new Dictionary<string, int>();
        }
        public DateTime Date { get; set; }
        public Dictionary<string, int> TotalGroupBy;
    }
}
