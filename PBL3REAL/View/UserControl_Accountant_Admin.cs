using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3REAL.View
{
    public partial class UserControl_Accountant_Admin : UserControl
    {
        public UserControl_Accountant_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Details_Invoice f = new Form_Details_Invoice();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
