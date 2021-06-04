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
        private ClientBLL clientBLL;
        private string search = "";
        private string orderBy = "";
        public Form_Client()
        {
            InitializeComponent();
            clientBLL = new ClientBLL();
            cbb_ClientSort.SelectedIndex = 0;
        }

        private void loadDtbClient()
        {
            dgv_Client.DataSource = null;
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("name", search);
            dgv_Client.DataSource = clientBLL.findByProperty(properties, orderBy);
            dgv_Client.Columns["IdClient"].Visible = false;
        }


        //Events
        private void btn_ClientView_Click(object sender, EventArgs e)
        {
            //truyền ID_CLient 
            Form_Detail_Client f = new Form_Detail_Client(0, false);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_ClientAdd_Click(object sender, EventArgs e)
        {
            Form_Detail_Client f = new Form_Detail_Client(0, true);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_ClientEdit_Click(object sender, EventArgs e)
        {
            //truyền ID_CLient 
            Form_Detail_Client f = new Form_Detail_Client(0, true);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_ClientDelete_Click(object sender, EventArgs e)
        {
            //Delete client
        }

        private void picbx_ClientSearch_Click(object sender, EventArgs e)
        {
            search = tb_ClientSearch.Text;
            orderBy = cbb_ClientSort.SelectedItem.ToString();
            loadDtbClient();
        }
    }
}
