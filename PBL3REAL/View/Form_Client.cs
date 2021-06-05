using PBL3REAL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3REAL.View
{
    public partial class Form_Client : Form
    {
        /***** GLOBAL DECLARATION *****/
        /*** Global Parameter For Client ***/
        private ClientBLL clientBLL;
        private string search = "";
        private string orderBy = "";

        /***** CONSTRUCTOR *****/
        public Form_Client()
        {
            InitializeComponent();
            clientBLL = new ClientBLL();
            cbb_ClientSort.SelectedIndex = 0;
        }

        /***** GENERAL *****/
        /*** Events ***/
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /***** CLIENT MANAGEMENT *****/
        /*** Functions ***/
        //-> Load Data Functions
        private void LoadData()
        {
            dgv.DataSource = null;
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("name", search);
            dgv.DataSource = clientBLL.findByProperty(properties, orderBy);
            dgv.Columns["IdClient"].Visible = false;
        }
        /*** Events ***/
        private void picbx_ClientSearch_Click(object sender, EventArgs e)
        {
            search = tb_ClientSearch.Text;
            orderBy = cbb_ClientSort.SelectedItem.ToString();
            LoadData();
        }
        private void btn_ClientView_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                //truyền ID_CLient 
                Form_Detail_Client f = new Form_Detail_Client(int.Parse(dgv.SelectedRows[0].Cells["IdClient"].Value.ToString()), false);
                f.myDel = LoadData;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }   
            else
            {
                MessageBox.Show("Bạn chưa chọn hoặc chọn nhiều hơn 1 client để xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        private void btn_ClientAdd_Click(object sender, EventArgs e)
        {
            Form_Detail_Client f = new Form_Detail_Client(0, true);
            f.myDel = LoadData;
            this.Hide();
            f.ShowDialog();
            this.Show();
            //Reload Data
        }
        private void btn_ClientEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                //truyền ID_CLient 
                Form_Detail_Client f = new Form_Detail_Client(int.Parse(dgv.SelectedRows[0].Cells["IdClient"].Value.ToString()), true);
                 f.myDel = LoadData;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }   
            else
            {
                MessageBox.Show("Bạn chưa chọn hoặc chọn nhiều hơn 1 client để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }
        private void btn_ClientDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                //Delete client
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hoặc chọn nhiều hơn 1 client để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
