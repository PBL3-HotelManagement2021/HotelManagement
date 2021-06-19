using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using Microsoft.Extensions.DependencyInjection;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class Form_Detail_Invoice : Form
    {
        /***** GLOBAL PARAMETERS *****/
        private string bookCode="";
        private int idInvoice=0;
        private QLInvoiceBLL qLInvoiceBLL;
        private InvoiceDetailVM invoiceDetailVM;
        public delegate void MyDel();
        public MyDel myDel;

        /***** CONSTRUCTOR *****/
        public Form_Detail_Invoice(string bookCode, int idInvoice)
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //ConfigureServices();
            this.bookCode = bookCode;
            this.idInvoice = idInvoice;
            qLInvoiceBLL = new QLInvoiceBLL();
            if (bookCode != "")
            {
                invoiceDetailVM = qLInvoiceBLL.infoAddInvoice(bookCode);
                tb_CreateDate.Text = DateTime.Now.ToString();
                tb_LastUpdateDate.Text = DateTime.Now.ToString();
                lb_InvoiceID.Text = "Invoice ID: ...";
                tb_BookingCode.Text = bookCode;
                lb_Usercode.Text += QLUserBLL.stoUser.UserCode;
            }
            else if (idInvoice != 0)
            {
                invoiceDetailVM = qLInvoiceBLL.getDetail(idInvoice);
                tb_CreateDate.Text = invoiceDetailVM.InvCreatedate.ToString();
                tb_LastUpdateDate.Text = invoiceDetailVM.InvUpdatedate.ToString();
                lb_InvoiceID.Text = "Invoice ID: " + invoiceDetailVM.InvCode.ToString();
                tb_BookingCode.Text = invoiceDetailVM.BookCode;
                lb_Usercode.Text += invoiceDetailVM.UserCode;
              
            }
            LoadData();
        }

        /***** FUNCTIONS *****/
        //-> Load Data Function
        private void LoadData()
        {
            tbllaypn_InvoiceFromToInfo.Enabled = false;
            tbllaypn_BookingDateInfo.Enabled = false;
            tb_FullName.Text = invoiceDetailVM.CliName;
            tb_Gmail.Text = invoiceDetailVM.CliGmail;
            tb_Phone.Text = invoiceDetailVM.CliPhone;
            tb_ClientCode.Text = invoiceDetailVM.CliCode;
            tb_BookingDate.Text = invoiceDetailVM.BookBookDate.ToString();
            tb_PaymentDate.Text = invoiceDetailVM.BookChecoutdate.ToString();
            tb_CheckinDate.Text = invoiceDetailVM.BookCheckindate.ToString();
            tb_Total.Text = invoiceDetailVM.TotalPrice.ToString();
            tb_InvStatus.Text = invoiceDetailVM.InvStatus;
            dgv.DataSource = invoiceDetailVM.ListRoom;
            if(invoiceDetailVM.IdInvoice==0) btn_OK.Enabled = true;
            else btn_OK.Enabled = false;
        }

        //-> Set Service
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        //    // more code here
        //}

        //-> Export to PDF Function
        private void ExportToPDF(string FileName)
        {
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font_Header = new XFont("Arial", 30, XFontStyle.Bold);
            XFont font_Footer = new XFont("Arial", 8, XFontStyle.Bold);
            graph.DrawString("INVOICE", font_Header, XBrushes.Black,new XRect(0, 30, pdfPage.Width.Point, 0), XStringFormats.BaseLineCenter);
            graph.DrawString("Invoice ID: " + FileName, font_Footer, XBrushes.Black, new XRect(3, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.BottomLeft);
            graph.DrawLine(XPens.Azure, 5, 160, 100, 160);
            //Layout
            //P1: 
            //Left: Hotel Info
            XFont font_P1_Left = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawString("Hotel Name", font_P1_Left, XBrushes.Black, new XRect(5, 120, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Address", font_P1_Left, XBrushes.Black, new XRect(5, 140, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawLine(XPens.Black, 5, 160, 300, 160);
            //Right: Hotel Logo -> Chèn ảnh
            //P2: 
            //Left: Booking Info
            XFont font_P2_Left_Header = new XFont("Arial", 15, XFontStyle.Regular);
            graph.DrawString("Booking Info", font_P2_Left_Header, XBrushes.Black, new XRect(5, 190, pdfPage.Width.Point, 0), XStringFormats.Default);
            XFont font_P2_Left = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawString("Booking Code", font_P2_Left, XBrushes.Black, new XRect(5, 220, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Booking Date", font_P2_Left, XBrushes.Black, new XRect(5, 250, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Booking Status", font_P2_Left, XBrushes.Black, new XRect(5, 280, pdfPage.Width.Point, 0), XStringFormats.Default);
            //Right: Payer Info
            XFont font_P2_Right_Header = new XFont("Arial", 15, XFontStyle.Regular);
            graph.DrawString("Client Info", font_P2_Right_Header, XBrushes.Black, new XRect(320, 190, pdfPage.Width.Point, 0), XStringFormats.Default);
            XFont font_P2_Right = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawString("Fullname", font_P2_Right, XBrushes.Black, new XRect(320, 210, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Phone", font_P2_Right, XBrushes.Black, new XRect(320, 235, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Email", font_P2_Right, XBrushes.Black, new XRect(320, 260, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Client Code", font_P2_Right, XBrushes.Black, new XRect(320, 285, pdfPage.Width.Point, 0), XStringFormats.Default);
            //P3: Booking Time Table
            graph.DrawLine(XPens.Black, 20, 295, 1000, 295);
            XFont font_P3 = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawString("Payment Date", font_P3, XBrushes.Black, new XRect(30, 300, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Checkin Date", font_P3, XBrushes.Black, new XRect(80, 300, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Create Date", font_P3, XBrushes.Black, new XRect(130, 300, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Last Updated Date", font_P3, XBrushes.Black, new XRect(180, 300, pdfPage.Width.Point, 0), XStringFormats.Default);
            //P4: Items Table
            XFont font_P4 = new XFont("Arial", 13, XFontStyle.Regular);
            graph.DrawLine(XPens.Aquamarine, 40, 320, 800, 320);
            graph.DrawString("Item[1] Column[1]", font_P3, XBrushes.Black, new XRect(40, 330, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Item[1] Column[2]", font_P3, XBrushes.Black, new XRect(100, 330, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Item[1] Column[3]", font_P3, XBrushes.Black, new XRect(160, 330, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawLine(XPens.Aquamarine, 40, 340, 800, 340);
            graph.DrawString("Item[2] Column[2]", font_P3, XBrushes.Black, new XRect(40, 350, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Item[2] Column[2]", font_P3, XBrushes.Black, new XRect(100, 350, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Item[2] Column[2]", font_P3, XBrushes.Black, new XRect(160, 350, pdfPage.Width.Point, 0), XStringFormats.Default);
            //P5: Total money
            XFont font_Total_Money = new XFont("Arial", 14, XFontStyle.Regular);
            graph.DrawString("Total", font_Total_Money, XBrushes.Black, new XRect(1000, 700, pdfPage.Width.Point, 0), XStringFormats.Default);
            //P6: Signature
            XFont font_Signature = new XFont("Arial", 14, XFontStyle.Regular);
            graph.DrawString("Client Signature", font_Signature, XBrushes.Black, new XRect(1000, 800, pdfPage.Width.Point, 0), XStringFormats.Default);
            pdf.Save(FileName);
        }

        /***** EVENTS *****/
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (invoiceDetailVM.IdInvoice == 0)
            {
                qLInvoiceBLL.addInvoice(invoiceDetailVM);
                MessageBox.Show("Đã tạo thành công đơn invoice mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myDel();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("This Invoice has already been created", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_ExportToPDF_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\Invoices\\" + invoiceDetailVM.InvCode + ".pdf";
            ExportToPDF(path);
            myDel();
            this.Dispose();
        }
    }
}
