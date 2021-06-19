using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3REAL.View
{
    public partial class Form_Accountant : Form
    {
        private QLInvoiceBLL qLInvoiceBLL;
        private string search = "";
        private string orderBy = "";
        private readonly int ROWS = 5;
        private int currentPage = 1;
        private int totalPage = 0;
        private CalendarVM calendarVM;
        public Form_Accountant()
        {
            InitializeComponent();
            dtp_From.Enabled = false;
            dtp_To.Enabled = false;
            qLInvoiceBLL = new QLInvoiceBLL();
            cbb_InvoiceSort.SelectedIndex = 0;
            grbx_StatisticOption.Enabled = false;
            grbx_AnalyzeOption.Enabled = false;
            calendarVM = new CalendarVM();
        }

        /***** Invoice MANAGEMENT *****/
        /*** Functions ***/
        private void LoadData()
        {
            dgv_Invoice.DataSource = null;
            totalPage = qLInvoiceBLL.getPagination(ROWS, search , calendarVM);
            if (totalPage != 0)
            {
                dgv_Invoice.DataSource = qLInvoiceBLL.findByProperties(currentPage, ROWS,"", search, orderBy, calendarVM);
                dgv_Invoice.Columns["InvIdbook"].Visible = false;
                tb_InvoicePageNumber.Text = currentPage + "/" + totalPage;
            }
            else
            {
                tb_InvoicePageNumber.Text = "0/0";
            }

        }
        /*** Events ***/


        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            bool Statistic = false, Analyze = false, Predict = false;
            if (chkbx_Statistic.Checked) { Statistic = true; }
            if (chkbx_Analyze.Checked && chkbx_AnalyzeOption.Checked)
            {
                Analyze = true;
            }
            if (chkbx_Analyze.Checked && chkbx_PredictOption.Checked )
            {
                Predict = true;
            }    
            switch (cbb_PeriodTime.SelectedIndex) 
            {
                case 0:
                    Form_View_Statistic_Analyze f1 = new Form_View_Statistic_Analyze(cbb_DataType.SelectedIndex, DateTime.Now.AddDays(-7).Date, DateTime.Now.Date, Statistic, Analyze, Predict);
                    this.Hide();
                    f1.ShowDialog();
                    this.Show();
                    break;
                case 1:
                    Form_View_Statistic_Analyze f2 = new Form_View_Statistic_Analyze(cbb_DataType.SelectedIndex, DateTime.Now.AddDays(-30).Date, DateTime.Now.Date, Statistic, Analyze, Predict);
                    this.Hide();
                    f2.ShowDialog();
                    this.Show();
                    break;
                case 2:
                    Form_View_Statistic_Analyze f3 = new Form_View_Statistic_Analyze(cbb_DataType.SelectedIndex, dtp_From.Value.Date,dtp_To.Value.Date, Statistic, Analyze, Predict);
                    this.Hide();
                    f3.ShowDialog();
                    this.Show();
                    break;
                default:
                    break;
            }
        }
        private void cbb_PeriodTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_PeriodTime.SelectedIndex == 2) { dtp_From.Enabled = true; dtp_To.Enabled = true; }
        }

        private void picbx_InvoiceSearch_Click(object sender, EventArgs e)
        {
            search = tb_InvoiceSearch.Text;
            orderBy = cbb_InvoiceSort.SelectedItem.ToString();
            currentPage = 1;
            calendarVM.fromDate = dtp_InvoiceFrom.Value;
            calendarVM.toDate = dtp_InvoiceTo.Value;
            LoadData();
        }

        private void btn_InvoiceNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage) //Thay 10 thanh ham get total booking record 
            {
                currentPage += 1;
                LoadData();
                tb_InvoicePageNumber.Text = currentPage + "/" + totalPage;
            }
        }

        private void btn_InvoicePrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage -= 1;
                LoadData();
                tb_InvoicePageNumber.Text = currentPage + "/" + totalPage;
            }
        }

        private void btn_InvoiceView_Click(object sender, EventArgs e)
        {
            if (dgv_Invoice.SelectedRows.Count == 1)
            {
                //truyền ID_CLient 
                Form_Detail_Invoice f = new Form_Detail_Invoice("",int.Parse(dgv_Invoice.SelectedRows[0].Cells["IdInvoice"].Value.ToString()));
                f.myDel = LoadData;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please choose only 1 rows to view !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkbx_Statistic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_Statistic.Checked)
            {
                grbx_StatisticOption.Enabled = true;
            }
            else
            {
                grbx_StatisticOption.Enabled = false;
            }    
        }

        private void chkbx_Analyze_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_Analyze.Checked)
            {
                grbx_AnalyzeOption.Enabled = true;
            }    
            else
            {
                grbx_AnalyzeOption.Enabled = false;
            }    
        }

        private void btn_InvoiceDelete_Click(object sender, EventArgs e)
        {
            if (dgv_Invoice.SelectedRows.Count == 1)
            {
                qLInvoiceBLL.deleteInvoice(int.Parse(dgv_Invoice.SelectedRows[0].Cells["IdInvoice"].Value.ToString()));
                LoadData();
            }
            else
            {
                MessageBox.Show("Please choose only 1 rows to view !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
