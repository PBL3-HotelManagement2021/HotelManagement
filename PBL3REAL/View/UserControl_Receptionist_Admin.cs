using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace PBL3REAL.View
{
    public partial class UserControl_Receptionist_Admin : UserControl
    {
        public UserControl_Receptionist_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_Detail_Room f = new Form_Detail_Room();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_Detail_Room_Category f = new Form_Detail_Room_Category();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form_Booking f = new Form_Booking();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
