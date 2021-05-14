using System;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.View;
namespace PBL3REAL.View
{
    public partial class Form_Home_Admin : Form
    {
        public Form_Home_Admin()
        {
            InitializeComponent();
            SetVisible();
        }
        public void SetVisible()
        {
            userControl_Receptionist_Admin1.Visible = false;
            userControl_Accountant_Admin1.Visible = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl_Receptionist_Admin1.Visible = true;
            userControl_Accountant_Admin1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Home_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl_Accountant_Admin1.Visible = true;
            userControl_Receptionist_Admin1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_User_Profile f = new Form_User_Profile();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
//www.csharp-tutorial.hu/wp-content/uploads/2017/01/printform.png
//stackoverflow.com/questions/4370779/print-invoice-c-sharp-winforms


