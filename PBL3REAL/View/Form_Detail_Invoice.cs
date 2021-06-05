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
        private string bookCode;
        private QLInvoiceBLL qLInvoiceBLL;
        private InvoiceVM invoiceVM;
        public Form_Detail_Invoice(string bookCode)
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //ConfigureServices();
            this.bookCode = bookCode;
            qLInvoiceBLL = new QLInvoiceBLL();
            loadData();
        }

        private void loadData()
        {
            invoiceVM = qLInvoiceBLL.infoAddInvoice(bookCode);
            tb_FullName.Text = invoiceVM.CliName;
            tb_Gmail.Text = invoiceVM.CliGmail;
            tb_Phone.Text = invoiceVM.CliPhone;
            tb_BookingCode.Text = bookCode;
            tb_BookingDate.Text = invoiceVM.BookBookDate.ToString();
            tb_PaymentDate.Text = invoiceVM.BookChecoutdate.ToString();
            tb_CheckinDate.Text = invoiceVM.BookCheckindate.ToString();
            tb_CreateDate.Text = DateTime.Now.ToString();
            tb_LastUpdateDate.Text = DateTime.Now.ToString();
            tb_Total.Text = invoiceVM.TotalPrice.ToString();
            dgv.DataSource = invoiceVM.ListRoom;
            dgv.Columns["RoomDescription"].Visible = false;
            dgv.Columns["IdRoom"].Visible = false;
        }
        public void ExportToPDF(string FileName)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    SaveFileDialog sfd = new SaveFileDialog();
            //    sfd.Filter = "PDF (*.pdf)|*.pdf";
            //    sfd.FileName = "Output.pdf";
            //    bool fileError = false;
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(sfd.FileName))
            //        {
            //            try
            //            {
            //                File.Delete(sfd.FileName);
            //            }
            //            catch (IOException ex)
            //            {
            //                fileError = true;
            //                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
            //            }
            //        }
            //        if (!fileError)
            //        {
            //            try
            //            {
            //                PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
            //                pdfTable.DefaultCell.Padding = 3;
            //                pdfTable.WidthPercentage = 100;
            //                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            //                foreach (DataGridViewColumn column in dataGridView1.Columns)
            //                {
            //                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            //                    pdfTable.AddCell(cell);
            //                }

            //                foreach (DataGridViewRow row in dataGridView1.Rows)
            //                {
            //                    foreach (DataGridViewCell cell in row.Cells)
            //                    {
            //                        pdfTable.AddCell(cell.Value.ToString());
            //                    }
            //                }

            //                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
            //                {
            //                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
            //                    PdfWriter.GetInstance(pdfDoc, stream);
            //                    pdfDoc.Open();
            //                    pdfDoc.Add(pdfTable);
            //                    pdfDoc.Close();
            //                    stream.Close();
            //                }

            //                MessageBox.Show("Data Exported Successfully !!!", "Info");
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error :" + ex.Message);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No Record To Export !!!", "Info");
            //}
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font_Header = new XFont("Arial", 30, XFontStyle.Bold);
            XFont font_Footer = new XFont("Arial", 8, XFontStyle.Bold);
            graph.DrawString("INVOICE", font_Header, XBrushes.Black,new XRect(0, 30, pdfPage.Width.Point, 0), XStringFormats.BaseLineCenter);
            graph.DrawString("Invoice ID: " + FileName, font_Footer, XBrushes.Black, new XRect(3, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.BottomLeft);
            pdf.Save(FileName + ".pdf");
        }
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        //    // more code here
        //}
        private void btn_OK_Click(object sender, EventArgs e)
        {
           if(invoiceVM.BookStatus != "Paid")
            {
                qLInvoiceBLL.addInvoice(invoiceVM);
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

        private void btn_Export_Click(object sender, EventArgs e)
        {
            ExportToPDF("Test");
        }
    }
}
