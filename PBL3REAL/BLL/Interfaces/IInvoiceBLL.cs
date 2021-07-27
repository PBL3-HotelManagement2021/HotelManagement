using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL.Interfaces
{
    interface IInvoiceBLL
    {
        public InvoiceDetailVM InfoAddInvoice(string bookCode);
        public void AddInvoice(InvoiceDetailVM invoiceDetailVM);
        public void DeleteInvoice(int idInvoice);
        public InvoiceDetailVM GetDetail(int idinvoice);
        public List<InvoiceVM> FindByProperties(int pages, int rows, string bookCode, string invCode, string orderBy, CalendarVM searchByDate);
        public int GetPagination(int rows, string code, CalendarVM searchByDate);
        public List<Statistic1> FindForStatistic(DateTime fromDate, DateTime toDate);
        public List<Statistic2> FindForStatistic2(DateTime fromDate, DateTime toDate);
        public string AnalyzingIncome(List<Statistic1> statistic1s, DateTime from, DateTime to);
        }
}
