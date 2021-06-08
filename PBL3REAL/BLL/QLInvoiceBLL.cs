using AutoMapper;
using HotelManagement.DAL.Implement;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.BLL
{
    public class QLInvoiceBLL
    {
        private Mapper mapper;
        private RoomDAL roomDAL;
        private BookingDAL bookingDAL;
        public QLInvoiceBLL()
        {
            mapper = new Mapper(MapperVM.config);
            bookingDAL = new BookingDAL();
            roomDAL = new RoomDAL();
        }

        public InvoiceVM infoAddInvoice(string bookCode)
        {
            try
            {
                Booking booking = bookingDAL.findForInvoice(bookCode);
                if (booking == null) throw new ArgumentException("Wrong Code");
                InvoiceVM invoiceVM = new InvoiceVM
                {
                    InvIdbook = booking.IdBook,
                    BookStatus = booking.BookStatus,
                    BookBookDate = booking.BookBookdate,
                    BookCheckindate = booking.BookCheckindate,
                    BookChecoutdate = booking.BookCheckoutdate,
                    CliCode = booking.BookIdclientNavigation.CliCode,
                    CliName = booking.BookIdclientNavigation.CliName,
                    CliPhone = booking.BookIdclientNavigation.CliPhone,
                    CliGmail = booking.BookIdclientNavigation.CliGmail,
                };
                if (booking.BookStatus == "Checkout") invoiceVM.TotalPrice = booking.BookTotalprice;
                else invoiceVM.TotalPrice = booking.BookDeposit;
                foreach (Room room in roomDAL.findByIdBook(booking.IdBook))
                {
                    invoiceVM.ListRoom.Add(new RoomVM
                    {
                        RoomName = room.RoomName,
                        RotyCurrentprice = room.RoomIdroomtypeNavigation.RotyCurrentprice,
                        RoTyName = room.RoomIdroomtypeNavigation.RotyName
                    });
                }
                return invoiceVM;
            }
            catch (Exception)
            {
                throw; 
            }
        }

        public void addInvoice(InvoiceVM invoiceVM)
        {
            Invoice invoice = new Invoice();
            mapper.Map(invoiceVM, invoice);
            try
            {
                InvoiceDAL.Instance.add(invoice);
            }
            catch(Exception e)
            {

            }
        }
        public InvoiceVM getDetail(int idinvoice)
        {
            try
            {
                Invoice invoice = InvoiceDAL.Instance.findById(idinvoice);
                InvoiceVM invoiceVM = mapper.Map<InvoiceVM>(invoice);
                Booking booking = invoice.InvIdbookNavigation;
                invoiceVM.BookCheckindate = booking.BookCheckindate;
                invoiceVM.BookChecoutdate = booking.BookCheckoutdate;
                invoiceVM.CliName = booking.BookIdclientNavigation.CliName;
                invoiceVM.CliCode = booking.BookIdclientNavigation.CliCode;
                invoiceVM.CliPhone = booking.BookIdclientNavigation.CliPhone;
                invoiceVM.CliGmail = booking.BookIdclientNavigation.CliGmail;
                invoiceVM.UserCode = booking.BookIduserNavigation.UserCode;
                
                foreach(Room room in roomDAL.findByIdBook(invoice.InvIdbook))
                {
                    invoiceVM.ListRoom.Add(new RoomVM
                    {
                        RoomName = room.RoomName,
                        RotyCurrentprice = room.RoomIdroomtypeNavigation.RotyCurrentprice,
                        RoTyName = room.RoomIdroomtypeNavigation.RotyName
                    });
                }
                return invoiceVM;        
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Statistic1> findForStatistic(DateTime fromDate, DateTime toDate)
        {
            List<Statistic1> listVM = new List<Statistic1>();
            var GroupByInv = InvoiceDAL.Instance.findForStatistic(fromDate, toDate);
            foreach (var inv in GroupByInv)
            {
                Statistic1 statistic_InvoiceVM = new Statistic1
                {
                    Date = inv.InvCreatedate,
                    TotalByDate = inv.TotalPrice
                };
                listVM.Add(statistic_InvoiceVM);
            }
            return listVM;
        }

        public List<Statistic2>findForStatistic2 (DateTime fromDate, DateTime toDate)
        {
            return InvoiceDAL.Instance.findForStatistic2(fromDate, toDate);
        }
        
    }
}
