using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;

namespace PBL3REAL.View
{
    public partial class Form_Accountant : Form
    {
        //---------- GLOBAL DECLARATION ----------//
        //----- Form Instance Variables -----//
        private List<Button> listButton;

        //----- Invoice Instance Variables -----//
        private QLInvoiceBLL qLInvoiceBLL;
        private string search = "";
        private string orderBy = "";
        private readonly int ROWS = 5;
        private int currentPage = 1;
        private int totalPage = 0;
        private CalendarVM calendarVM;
        private TabPage tp;

        //---------- FORM CONSTRUCTOR ----------//
        public Form_Accountant()
        {
            //--- Initialize ----//
            InitializeComponent();
            qLInvoiceBLL = new QLInvoiceBLL();
            cbb_InvoiceSort.SelectedIndex = 0;
            calendarVM = new CalendarVM();
            tp = STATAB_USE;
            if (tabControl_Accountant.TabPages.Contains(tp)) tabControl_Accountant.TabPages.Remove(tp);
            listButton = new List<Button>()
            {
                INVO_VIEW,INVO_DELETE
            };

            //--- Set GUI ----//
            dtp_From.Enabled = false;
            dtp_To.Enabled = false;
            grbx_StatisticOptions.Enabled = false;
            grbx_AnalyzeOptions.Enabled = false;
            
            Authorization();
        }

        //---------- FORM ----------//
        private void Authorization()
        {
            List<string> listAction = QLUserBLL.stoUser.ListRole.Where(x => x.IsSelected == true).FirstOrDefault().ActionList;
            foreach (var button in listButton)
            {
                string idbutton = button.Name.ToString();
                if (listAction.Contains(idbutton)) button.Enabled = true;
            }
            if (tabControl_Accountant.TabPages.Contains(tp)) return;
            string idTabPage = tp.Name.ToString();
            if (listAction.Contains(idTabPage)) tabControl_Accountant.TabPages.Add(tp);
        }

        //---------- GENERAL ----------//
        //----- Events -----//
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //---------- INVOICE MANAGEMENT ----------//
        //----- Functions -----//
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

        //----- Events -----//
        //--- tbllaypn_Invoice ---//
        private void picbx_InvoiceSearch_Click(object sender, EventArgs e)
        {
            search = tb_InvoiceSearch.Text;
            orderBy = cbb_InvoiceSort.SelectedItem.ToString();
            currentPage = 1;
            calendarVM.fromDate = dtp_InvoiceFrom.Value;
            calendarVM.toDate = dtp_InvoiceTo.Value;
            LoadData();
        }

        //--- fllaypn_InvoiceButtons ---//
        private void btn_InvoiceView_Click(object sender, EventArgs e)
        {
            if (dgv_Invoice.SelectedRows.Count == 1)
            {
                //truyền ID_CLient 
                Form_Detail_Invoice f = new Form_Detail_Invoice("", int.Parse(dgv_Invoice.SelectedRows[0].Cells["IdInvoice"].Value.ToString()));
                f.myDel = LoadData;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please choose only 1 row to view!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please choose only 1 rows to view!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--- fllaypn_InvoiceSwitchPage ---//
        private void btn_InvoicePrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage -= 1;
                LoadData();
                tb_InvoicePageNumber.Text = currentPage + "/" + totalPage;
            }
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

        //---------- STATISTIC & ANALYZE ----------//
        //----- Events -----//
        //----- tbllaypn_DataOption -----//
        private void cbb_PeriodTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_PeriodTime.SelectedIndex == 2) { dtp_From.Enabled = true; dtp_To.Enabled = true; }
        }
        private void chkbx_Statistic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_Statistic.Checked) { grbx_StatisticOptions.Enabled = true; }
            else { grbx_StatisticOptions.Enabled = false; }
        }
        private void chkbx_Analyze_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_Analyze.Checked) { grbx_AnalyzeOptions.Enabled = true; }
            else { grbx_AnalyzeOptions.Enabled = false; }
        }

        //--- tbllaypn_ControlBar ---//
        private void btn_OK_Click(object sender, EventArgs e)
        {
            bool Statistic = false, Analyze = false, Predict = false;
            if (chkbx_Statistic.Checked)  { Statistic = true; }
            if (chkbx_Analyze.Checked && chkbx_AnalyzeOption.Checked)  { Analyze = true; }
            if (chkbx_Analyze.Checked && chkbx_PredictOption.Checked)  { Predict = true; }    
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
    }
}
