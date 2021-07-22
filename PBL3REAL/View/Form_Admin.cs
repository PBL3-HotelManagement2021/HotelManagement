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
using PBL3REAL.BLL;
using PBL3REAL.Extention;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class Form_Admin : Form
    {
        //---------- GLOBAL DECLARATION ----------//
        //----- Admin Account Instance Variables -----//
        private int ID;
        private string LoggedRole;

        //---------- FORM CONSTRUCTOR ----------//
        public Form_Admin(int id, string role)
        {
            //--- Initialize ----//
            InitializeComponent();
            ID = id;
            LoggedRole = role;
        }

        //---------- EVENTS ----------//
        //----- Form -----//
        private void Form_Admin_Move(object sender, EventArgs e)
        {
            fllaypn_Menu.Visible = false;
        }
        private void Form_Home_Admin_VisibleChanged(object sender, EventArgs e)
        {
            fllaypn_Menu.Visible = false;
        }

        //----- fllaypn_Menu -----//
        private void btn_Menu_VisibleChanged(object sender, EventArgs e)
        {
            fllaypn_Menu.Visible = (!fllaypn_Menu.Visible);
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            fllaypn_Menu.Visible = !fllaypn_Menu.Visible;
        }
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Form_User_Profile f = new Form_User_Profile(ID, LoggedRole, false,true);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //----- fllaypn_Navbar -----//
        private void btn_Receptionist_Click(object sender, EventArgs e)
        {
            Form_Receptionist f = new Form_Receptionist(ID, LoggedRole);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Accountant_Click(object sender, EventArgs e)
        {
            Form_Accountant f = new Form_Accountant();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Client_Click(object sender, EventArgs e)
        {
            Form_Client f = new Form_Client();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_HRM_Click(object sender, EventArgs e)
        {
            Form_HRM f = new Form_HRM();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}


