using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class Form_Staff : Form
    {
        //----- INSTANCE VARIABLES -----//
        private QLUserBLL qLUserBLL;
        private string LoggedRole;

        //----- FORM CONSTRUCTOR -----//
        public Form_Staff(int id, string role)
        {
            //--- Initialize ---//
            InitializeComponent();
            LoggedRole = role;
            qLUserBLL = new QLUserBLL();

            SetGUI();
            LoadData();
        }

        //----- FUNCTIONS -----//
        //-> Set GUI
        private void SetGUI()
        {
            this.fllaypn_Clerk.Visible = false;
            this.fllaypn_Receptionist.Visible = false;
            this.fllaypn_Receptionist.Location = this.fllaypn_Clerk.Location;
        }
        //-> Load Data
        private void LoadData()
        {
            picbx_Header.SizeMode = PictureBoxSizeMode.StretchImage;
            lb_Header.Text = "   " + QLUserBLL.stoUser.UserCode + "   ";  
        }

        //----- EVENTS -----//
        private void btn_Receptionist_Receptionist_Click(object sender, EventArgs e)
        {
            Form_Receptionist f = new Form_Receptionist(QLUserBLL.stoUser.IdUser, LoggedRole);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Accountant_Receptionist_Click(object sender, EventArgs e)
        {
            Form_Accountant f = new Form_Accountant();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Client_Receptionist_Click(object sender, EventArgs e)
        {
            Form_Client f = new Form_Client();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Accountant_Clerk_Click(object sender, EventArgs e)
        {
            Form_Accountant f = new Form_Accountant();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Client_Clerk_Click(object sender, EventArgs e)
        {
            Form_Client f = new Form_Client();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Business_Click(object sender, EventArgs e)
        {
            switch (LoggedRole)
            {
                case "Receptionist":
                    this.fllaypn_Receptionist.Visible = (!this.fllaypn_Receptionist.Visible);
                    break;
                case "Clerk":
                    this.fllaypn_Clerk.Visible = (!this.fllaypn_Clerk.Visible);
                    break;
                default:
                    break;
            }
        }
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Form_User_Profile f = new Form_User_Profile(QLUserBLL.stoUser.IdUser, LoggedRole, false, true);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
