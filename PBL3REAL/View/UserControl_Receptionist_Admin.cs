using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using System.Windows.Forms;
using HotelManagement.View;
using HotelManagement.BLL.Implement;
using HotelManagement.BBL.Implement;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class UserControl_Receptionist_Admin : UserControl
    {
        public UserControl_Receptionist_Admin()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Booking f = new Form_Booking();
            f.ShowDialog();
        }
    }
}
