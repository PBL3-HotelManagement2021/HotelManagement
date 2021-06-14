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

        public InvoiceVM infoAddInvoice(string bookCode)
        {
            try
            {
                Booking booking = BookingDAL.Instance.findForInvoice(bookCode);
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
                foreach (Room room in RoomDAL.Instance.findByIdBook(booking.IdBook))
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
                
                foreach(Room room in RoomDAL.Instance.findByIdBook(invoice.InvIdbook))
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
