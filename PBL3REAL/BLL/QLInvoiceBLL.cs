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
        public QLInvoiceBLL()
        {
            mapper = new Mapper(MapperVM.config);
        }

        public InvoiceDetailVM infoAddInvoice(string bookCode)
        {
            try
            {
                Booking booking = BookingDAL.Instance.findForInvoice(bookCode);
                if (booking == null) throw new ArgumentException("Wrong Code");
                InvoiceDetailVM invoiceDetailVM = new InvoiceDetailVM
                {
                    InvIdbook = booking.IdBook,
                    BookBookDate = booking.BookBookdate,
                    BookCheckindate = booking.BookCheckindate,
                    BookChecoutdate = booking.BookCheckoutdate,
                    CliCode = booking.BookIdclientNavigation.CliCode,
                    CliName = booking.BookIdclientNavigation.CliName,
                    CliPhone = booking.BookIdclientNavigation.CliPhone,
                    CliGmail = booking.BookIdclientNavigation.CliGmail,
                };
                if (booking.BookStatus == "Checkin")
                {
                    invoiceDetailVM.TotalPrice = booking.BookTotalprice;
                    invoiceDetailVM.InvStatus = "Total";
                }
                else
                {
                    invoiceDetailVM.TotalPrice = booking.BookDeposit;
                    invoiceDetailVM.InvStatus = "Deposit";
                }
                int durationDate = invoiceDetailVM.BookChecoutdate.Subtract(invoiceDetailVM.BookCheckindate).Days;
                foreach (Room room in RoomDAL.Instance.findByIdBook(booking.IdBook))
                {
                    invoiceDetailVM.ListRoom.Add(new Invoice_RoomVM
                    {
                        Name = room.RoomName,
                        Price = room.RoomIdroomtypeNavigation.RotyCurrentprice,
                        RoomType = room.RoomIdroomtypeNavigation.RotyName,
                        Duration = durationDate,
                        Amount = room.RoomIdroomtypeNavigation.RotyCurrentprice * durationDate

                    });
                }
                return invoiceDetailVM;
            }
            catch (Exception)
            {
                throw; 
            }
        }

        public void addInvoice(InvoiceDetailVM invoiceDetailVM)
        {
            Invoice invoice = new Invoice();
            mapper.Map(invoiceDetailVM, invoice);
            try
            {
                InvoiceDAL.Instance.add(invoice);
            }
            catch(Exception e)
            {

            }
        }

        public void deleteInvoice(int  idInvoice)
        {
            InvoiceDAL.Instance.delete(idInvoice);
        }

        public InvoiceDetailVM getDetail(int idinvoice)
        {
            try
            {                
                Invoice invoice = InvoiceDAL.Instance.findById(idinvoice);
                InvoiceDetailVM invoiceDetailVM = mapper.Map<InvoiceDetailVM>(invoice);
                Booking booking = invoice.InvIdbookNavigation;
                invoiceDetailVM.BookCheckindate = booking.BookCheckindate;
                invoiceDetailVM.BookChecoutdate = booking.BookCheckoutdate;
                invoiceDetailVM.BookBookDate = booking.BookBookdate;
                invoiceDetailVM.BookCode = booking.BookCode;
                invoiceDetailVM.CliName = booking.BookIdclientNavigation.CliName;
                invoiceDetailVM.CliCode = booking.BookIdclientNavigation.CliCode;
                invoiceDetailVM.CliPhone = booking.BookIdclientNavigation.CliPhone;
                invoiceDetailVM.CliGmail = booking.BookIdclientNavigation.CliGmail;
                invoiceDetailVM.UserCode = booking.BookIduserNavigation.UserCode;

                int durationDate = invoiceDetailVM.BookChecoutdate.Subtract(invoiceDetailVM.BookCheckindate).Days;
                foreach (Room room in RoomDAL.Instance.findByIdBook(invoice.InvIdbookNavigation.IdBook))
                {
                    invoiceDetailVM.ListRoom.Add(new Invoice_RoomVM
                    {
                        Name = room.RoomName,
                        Price = room.RoomIdroomtypeNavigation.RotyCurrentprice,
                        RoomType = room.RoomIdroomtypeNavigation.RotyName,
                        Duration = durationDate,
                        Amount = room.RoomIdroomtypeNavigation.RotyCurrentprice * durationDate

                    });
                }
                return invoiceDetailVM;        
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InvoiceVM>findByProperties(int pages , int rows ,string bookCode, string invCode , string orderBy , CalendarVM searchByDate)
        {
            int start = (pages - 1) * rows;
            int length = rows;
            List<InvoiceVM> listVm = new List<InvoiceVM>();
            foreach (var value in InvoiceDAL.Instance.findByProperties(start, length, bookCode, invCode, searchByDate, orderBy))
            {
                InvoiceVM invoiceVM = mapper.Map<InvoiceVM>(value);
                invoiceVM.Index = ++start;
                listVm.Add(invoiceVM);
            }
            return listVm;
        }

        public int getPagination(int rows, string code , CalendarVM searchByDate)
        {
            int totalRows = InvoiceDAL.Instance.getTotalRow(code, searchByDate);
            int totalpage;
            if (totalRows % rows == 0)
            {
                totalpage = totalRows / rows;
            }
            else
            {
                totalpage = totalRows / rows + 1;
            }
            return totalpage;
        }

        public List<Statistic1> findForStatistic(DateTime fromDate, DateTime toDate)
        {
            List<Statistic1> listVM = null;
            try
            {
                listVM = InvoiceDAL.Instance.findForStatistic(fromDate, toDate);
            }
            catch (Exception)
            {

            }
            return listVM;
        }

        public List<Statistic2>findForStatistic2 (DateTime fromDate, DateTime toDate)
        {
            return InvoiceDAL.Instance.findForStatistic2(fromDate, toDate);
        }
        public class MaxHeap
        {
            public MaxHeap(double[] input, int length)
            {
                this.Length = length;
                this.Array = input;
                BuildMaxHeap();
            }
            public double[] Array { get; private set; }
            public int Length { get; private set; }
            private void BuildMaxHeap()
            {
                for (int i = this.Length / 2; i > 0; i--)
                {
                    MaxHeapify(i);
                }
                return;
            }
            public void MaxHeapify(int index)
            {
                var left = 2 * index;
                var right = 2 * index + 1;
                int max = index;
                if (left <= this.Length && this.Array[left - 1] > this.Array[index - 1])
                {
                    max = left;
                }
                if (right <= this.Length && this.Array[right - 1] > this.Array[max - 1])
                {
                    max = right;
                }
                if (max != index)
                {
                    double temp = this.Array[max - 1];
                    this.Array[max - 1] = this.Array[index - 1];
                    this.Array[index - 1] = temp;
                    MaxHeapify(max);
                }
                return;
            }
            public double Maximum()
            {
                return this.Array[0];
            }
            public string rs;
            public string pointtime;
            public int len;
        }
        public string AnalyzingIncome(List<Statistic1> statistic1s, DateTime from, DateTime to)
        {
            if (statistic1s == null) { return ""; }
            if (statistic1s == null) { return ""; }
            string res1 = "- Ngày có doanh thu cao nhất: ";
            string res2 = "- Ngày có doanh thu thấp nhất: ";
            string res3 = "- Doanh thu trung bình: ";
            string res4 = "- Số ngày không có doanh thu: ";
            string res5 = "- Số ngày không có doanh thu liên tiếp: ";
            int Max_Income = 0, Min_Income = statistic1s[0].TotalPriceByDate, Total_Day = Convert.ToInt32((to.Date - from.Date).TotalDays),
                Day_Non_Income = Total_Day - statistic1s.Count,Day_Consecutive_Non_Income = 0, Day_Consecutive_Non_Income_Temp = 0;
            double Total_Income = 0, Avg_Income = 0;
            DateTime PrevDay = DateTime.Now;
            foreach (Statistic1 statistic1 in statistic1s)
            {
                if (statistic1.TotalPriceByDate > Max_Income) { Max_Income = statistic1.TotalPriceByDate; }
                if (statistic1.TotalPriceByDate < Min_Income) { Min_Income = statistic1.TotalPriceByDate; }
                Total_Income += statistic1.TotalPriceByDate;
                if (statistic1s.IndexOf(statistic1) != 0)
                {   
                    Day_Consecutive_Non_Income_Temp = Convert.ToInt32((statistic1.Date - PrevDay.Date).TotalDays);
                    if (Day_Consecutive_Non_Income_Temp > 1)
                    {
                        Day_Consecutive_Non_Income_Temp -= 1;
                    }
                    if (Day_Consecutive_Non_Income < Day_Consecutive_Non_Income_Temp)
                    {
                        Day_Consecutive_Non_Income = Day_Consecutive_Non_Income_Temp;
                        Day_Consecutive_Non_Income_Temp = 0;
                    }
                }
                if (statistic1s.IndexOf(statistic1) == statistic1s.Count - 1 && statistic1.Date < to)
                {
                    Day_Consecutive_Non_Income_Temp = Convert.ToInt32((to.Date - statistic1.Date).TotalDays) - 1;
                    if (Day_Consecutive_Non_Income_Temp > Day_Consecutive_Non_Income)
                    {
                        Day_Consecutive_Non_Income = Day_Consecutive_Non_Income_Temp;
                    }
                    break;
                }
                PrevDay = statistic1.Date;
            }
            Avg_Income = Total_Income / Total_Day;
            res1 += (Max_Income.ToString() + " VND");
            res2 += (Min_Income.ToString() + " VND");
            res3 += (Avg_Income.ToString() + " VND");
            res4 += (Day_Non_Income.ToString() + " Ngày");
            res5 += (Day_Consecutive_Non_Income.ToString() + " Ngày");
            return res1 + "\n" + res2 + "\n" + res3 + "\n" + res4 + "\n" + res5;
        }
    }
}
