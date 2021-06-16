using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
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
        public Form_Detail_Invoice(string bookCode, int idInvoice, bool Editable)
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
            LoadData(Editable);
        }

        /***** FUNCTIONS *****/
        //-> Load Data Function
        private void LoadData(bool Editable)
        {
            if (!Editable)
            {
                tbllaypn_InvoiceFromToInfo.Enabled = false;
                tbllaypn_BookingDateInfo.Enabled = false;
                btn_OK.Enabled = false;
            }
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
            graph.DrawLine(XPens.Azure, 20, 20, 20, 20);
            //Layout
            //P1: 
            //Left: Hotel Info
            //Right: Hotel Logo
            //P2: 
            //Left: Booking Info
            //Right: Payer Info
            //P3: Items Table
            //P4: Total money
            //P5: Signature
            pdf.Save(FileName + ".pdf");
        }

        /***** EVENTS *****/
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (invoiceDetailVM.IdInvoice != 0)
            {
                qLInvoiceBLL.addInvoice(invoiceDetailVM);
                myDel();
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
    }
}
