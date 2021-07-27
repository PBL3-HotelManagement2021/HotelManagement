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
        //---------- GLOBAL DECLARATION ----------//
        //----- Delegate -----//
        public delegate void MyDel();
        public MyDel myDel;

        //----- Invoice Instance Variables -----//
        private QLInvoiceBLL qLInvoiceBLL;
        private InvoiceDetailVM invoiceDetailVM;
        private string bookCode="";
        private int idInvoice=0;

        //---------- FORM CONSTRUCTOR ----------//
        public Form_Detail_Invoice(string bookCode, int idInvoice)
        {
            //--- Initialize ---//
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //ConfigureServices();
            this.bookCode = bookCode;
            this.idInvoice = idInvoice;
            qLInvoiceBLL = new QLInvoiceBLL();

            //--- Load Data ---//
            if (bookCode != "")
            {
                invoiceDetailVM = qLInvoiceBLL.InfoAddInvoice(bookCode);
                tb_CreateDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                tb_LastUpdateDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lb_InvoiceID.Text = "Invoice ID: ...";
                tb_BookingCode.Text = bookCode;
                lb_Usercode.Text += QLUserBLL.stoUser.UserCode;
      
            }
            else if (idInvoice != 0)
            {
                invoiceDetailVM = qLInvoiceBLL.GetDetail(idInvoice);
                tb_CreateDate.Text = invoiceDetailVM.InvCreatedate.ToString("dd/MM/yyyy");
                tb_LastUpdateDate.Text = invoiceDetailVM.InvUpdatedate.ToString("dd/MM/yyyy");
                lb_InvoiceID.Text = "Invoice ID: " + invoiceDetailVM.InvCode.ToString();
                tb_BookingCode.Text = invoiceDetailVM.BookCode;
                lb_Usercode.Text += invoiceDetailVM.UserCode;
              
            }
            LoadData();
        }

        //---------- FUNCTIONS ----------//
        //----- Load Data -----//
        private void LoadData()
        {
            tbllaypn_InvoiceFromToInfo.Enabled = false;
            tbllaypn_BookingDateInfo.Enabled = false;
            tb_FullName.Text = invoiceDetailVM.CliName;
            tb_Gmail.Text = invoiceDetailVM.CliGmail;
            tb_Phone.Text = invoiceDetailVM.CliPhone;
            tb_ClientCode.Text = invoiceDetailVM.CliCode;
            tb_BookingDate.Text = invoiceDetailVM.BookBookDate.ToString("dd/MM/yyyy");
            tb_PaymentDate.Text = invoiceDetailVM.BookChecoutdate.ToString("dd/MM/yyyy");
            tb_CheckinDate.Text = invoiceDetailVM.BookCheckindate.ToString("dd/MM/yyyy");
            tb_Total.Text = invoiceDetailVM.TotalPrice.ToString();
            tb_InvStatus.Text = invoiceDetailVM.InvStatus;
            dgv.DataSource = invoiceDetailVM.ListRoom;
            if(invoiceDetailVM.IdInvoice==0) btn_OK.Enabled = true;
            else btn_OK.Enabled = false;
        }

        //----- Set Service -----//
        public void ConfigureServices(IServiceCollection services)
        {
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // more code here
        }

        //----- Export to PDF -----//
        private void ExportToPDF(string FileName)
        {
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font_Header = new XFont("Arial", 30, XFontStyle.Bold);
            XFont font_Footer = new XFont("Arial", 8, XFontStyle.Bold);
            graph.DrawString("INVOICE", font_Header, XBrushes.Black,new XRect(0, 30, pdfPage.Width.Point, 0), XStringFormats.BaseLineCenter);
            graph.DrawString(lb_InvoiceID.Text, font_Footer, XBrushes.Black, new XRect(3, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.BottomLeft);
            graph.DrawLine(XPens.Azure, 5, 160, 100, 160);
            //Layout
            //P1: 
            //Left: Hotel Info
            XFont font_P1_Left = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawString("Hotel Name: ......................", font_P1_Left, XBrushes.Black, new XRect(20, 120, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Address      : ......................", font_P1_Left, XBrushes.Black, new XRect(20, 150, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawLine(XPens.Black, 10, 160, 300, 160);
            //Right: Hotel Logo -> Chèn ảnh
            //P2: 
            //Left: Booking Info
            XFont font_P2_Left_Header = new XFont("Arial", 15, XFontStyle.Regular);
            graph.DrawString("Booking Info", font_P2_Left_Header, XBrushes.Black, new XRect(15, 190, pdfPage.Width.Point, 0), XStringFormats.Default);
            XFont font_P2_Left = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawString("Booking Code :   " + tb_BookingCode.Text, font_P2_Left, XBrushes.Black, new XRect(15, 230, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Booking Date  :   " + tb_BookingDate.Text, font_P2_Left, XBrushes.Black, new XRect(15, 260, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Status:   " + tb_InvStatus.Text, font_P2_Left, XBrushes.Black, new XRect(15, 290, pdfPage.Width.Point, 0), XStringFormats.Default);
            //Right: Payer Info
            XFont font_P2_Right_Header = new XFont("Arial", 15, XFontStyle.Regular);
            graph.DrawString("Client Info", font_P2_Right_Header, XBrushes.Black, new XRect(320, 190, pdfPage.Width.Point, 0), XStringFormats.Default);
            XFont font_P2_Right = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawString("Fullname    :   " + tb_FullName.Text, font_P2_Right, XBrushes.Black, new XRect(320, 220, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Phone        :   " + tb_Phone.Text, font_P2_Right, XBrushes.Black, new XRect(320, 245, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Email          :   " + tb_Gmail.Text, font_P2_Right, XBrushes.Black, new XRect(320, 270, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Client Code:   " + tb_ClientCode.Text, font_P2_Right, XBrushes.Black, new XRect(320, 295, pdfPage.Width.Point, 0), XStringFormats.Default);
            //P3: Booking Time Table
            graph.DrawLine(XPens.Black, 10, 315, 600, 315);
            XFont font_P3_1 = new XFont("Arial", 13, XFontStyle.Bold);
            XFont font_P3_2 = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawString("Payment Date", font_P3_1, XBrushes.Black, new XRect(30, 345, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Checkin Date", font_P3_1, XBrushes.Black, new XRect(180, 345, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Create Date", font_P3_1, XBrushes.Black, new XRect(330, 345, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Last Updated Date", font_P3_1, XBrushes.Black, new XRect(480, 345, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString(tb_PaymentDate.Text, font_P3_2, XBrushes.Black, new XRect(45, 365, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString(tb_CheckinDate.Text, font_P3_2, XBrushes.Black, new XRect(192, 365, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString(tb_CreateDate.Text, font_P3_2, XBrushes.Black, new XRect(337, 365, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString(tb_LastUpdateDate.Text, font_P3_2, XBrushes.Black, new XRect(510, 365, pdfPage.Width.Point, 0), XStringFormats.Default);
            //P4: Items Table
            XFont font_P4_1 = new XFont("Arial", 13, XFontStyle.Bold);
            XFont font_P4_2 = new XFont("Arial", 12, XFontStyle.Regular);
            graph.DrawLine(XPens.Black, 10, 380, 600, 380);
            graph.DrawString("Room Name", font_P4_1, XBrushes.Black, new XRect(40, 400, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Room Type", font_P4_1, XBrushes.Black, new XRect(190, 400, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Price", font_P4_1, XBrushes.Black, new XRect(340, 400, pdfPage.Width.Point, 0), XStringFormats.Default);
            graph.DrawString("Amount", font_P4_1, XBrushes.Black, new XRect(490, 400, pdfPage.Width.Point, 0), XStringFormats.Default);
            int a = 0;
            for (int i = 0; i < invoiceDetailVM.ListRoom.Count; i++)
            {
                graph.DrawLine(XPens.Aquamarine, 25, 30 * i + 410, 550, 30 * i + 410);
                graph.DrawString(invoiceDetailVM.ListRoom[i].Name, font_P4_2, XBrushes.Black, new XRect(40, 30 * i + 430, pdfPage.Width.Point, 0), XStringFormats.Default);
                a = 30 * i + 430;
                graph.DrawString(invoiceDetailVM.ListRoom[i].RoomType, font_P4_2, XBrushes.Black, new XRect(190, a, pdfPage.Width.Point, 0), XStringFormats.Default);
                graph.DrawString(invoiceDetailVM.ListRoom[i].Price.ToString(), font_P4_2, XBrushes.Black, new XRect(340, a, pdfPage.Width.Point, 0), XStringFormats.Default);
                graph.DrawString(invoiceDetailVM.ListRoom[i].Amount.ToString(), font_P4_2, XBrushes.Black, new XRect(490, a, pdfPage.Width.Point, 0), XStringFormats.Default);
            }
            graph.DrawLine(XPens.Aquamarine, 25, a + 10, 550, a + 10);
            //P5: Total money
            XFont font_Total_Money = new XFont("Arial", 12, XFontStyle.Bold);
            graph.DrawString("Total: " + tb_Total.Text, font_Total_Money, XBrushes.Black, new XRect(450, a + 30, pdfPage.Width.Point, 0), XStringFormats.Default);
            //P6: Signature
            XFont font_Signature = new XFont("Arial", 13, XFontStyle.Regular);
            graph.DrawString("Client Signature", font_Signature, XBrushes.Black, new XRect(500, 700, pdfPage.Width.Point, 0), XStringFormats.Default);
            pdf.Save(FileName);
        }

        //---------- EVENTS ----------//
        //----- tbllaypn_ControlButtons -----//
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (invoiceDetailVM.IdInvoice == 0)
            {
                qLInvoiceBLL.AddInvoice(invoiceDetailVM);
                MessageBox.Show("Your invoice has been successfully created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myDel();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("This Invoice has already been created", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ExportToPDF_Click(object sender, EventArgs e)
        {
            if(invoiceDetailVM.InvCode !=null && invoiceDetailVM.InvCode != "")
            {
                string path = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\Invoices\\" + invoiceDetailVM.InvCode + ".pdf";
                ExportToPDF(path);
                myDel();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please create invoice first", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
