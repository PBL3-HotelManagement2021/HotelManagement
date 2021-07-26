using HotelManagement.DAL.Implement;
using PBL3REAL.DAL.Interfaces;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.DAL.FacadeDAL
{
    public class InvoiceDALManageFacade
    {
        private IInvoiceDAL _invoiceDALProvider;
        private IBookingDAL _bookingDALProvider;
        private IRoomDAL _roomDALProvider;
        public InvoiceDALManageFacade()
        {
            _invoiceDALProvider = new InvoiceDAL();
            _bookingDALProvider = new BookingDAL();
            _roomDALProvider = new RoomDAL();
        }

        public List<Invoice> FindInvoice(int start, int length, string bookCode, string invCode, CalendarVM searchByDate, string orderBy)
        {
            return _invoiceDALProvider.FindByProperties(start, length, bookCode, invCode, searchByDate, orderBy);
        }
        public Invoice FindInvoiceById(int idinvoice)
        {
            return _invoiceDALProvider.FindById(idinvoice);
        }
        public void AddInvoice(Invoice invoice)
        {
            _invoiceDALProvider.Add(invoice);
        }

        public void DeleteInvoice(int idInvoice)
        {
            _invoiceDALProvider.Delete(idInvoice);
        }
        public int GetInvoiceTotalRow(string code, CalendarVM searchByDate)
        {
            return _invoiceDALProvider.GetTotalRow(code, searchByDate);
        }
        public List<Statistic1> FindForStatistic(DateTime fromDate, DateTime toDate)
        {
            return _invoiceDALProvider.FindForStatistic(fromDate, toDate);
        }


        public Booking FindBookingForInvoice(string code)
        {
            return _bookingDALProvider.FindForInvoice(code);
        }

        public List<Statistic2> FindForStatistic2(DateTime fromDate, DateTime toDate)
        {
            return _invoiceDALProvider.FindForStatistic2(fromDate, toDate);
        }

        public List<Room> FindRoomByIdBook(int idbook)
        {
            return _roomDALProvider.FindByIdBook(idbook);
        }

    }
}
