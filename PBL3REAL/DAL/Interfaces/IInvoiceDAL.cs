using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.Interfaces
{
    interface IInvoiceDAL : SharedInterface<Invoice>
    {
        public List<Invoice> FindByProperties(int start, int length, string bookCode, string invCode, CalendarVM searchByDate, string orderBy);

        public int GetTotalRow(string code, CalendarVM searchByDate);
        public List<Statistic1> FindForStatistic(DateTime fromDate, DateTime toDate);
        public List<Statistic2> FindForStatistic2(DateTime fromDate, DateTime toDate);

    }
}
