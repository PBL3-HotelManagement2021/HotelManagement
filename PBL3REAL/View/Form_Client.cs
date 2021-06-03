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
        public Form_Client()
        {
            InitializeComponent();
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
    }
}
