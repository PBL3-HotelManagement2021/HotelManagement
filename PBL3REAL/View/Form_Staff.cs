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
        //---------- GLOBAL DECLARATION ----------//
        private QLUserBLL qLUserBLL;
        private string LoggedRole;

        //---------- FORM CONSTRUCTOR ----------//
        public Form_Staff(int id, string role)
        {
            //--- Initialize ---//
            InitializeComponent();
            LoggedRole = role;
            qLUserBLL = new QLUserBLL();

            SetGUI();
            LoadData();
        }

        //---------- FUNCTIONS ----------//
        //----- Set GUI -----//
        private void SetGUI()
        {
            this.fllaypn_Business.Visible = false;
        }
        //----- Load Data -----//
        private void LoadData()
        {
            picbx_Header.SizeMode = PictureBoxSizeMode.StretchImage;
            lb_Header.Text = "   " + QLUserBLL.stoUser.UserCode + "   ";  
        }

        //---------- EVENTS ----------//
        //----- fllaypn_Business -----//
        private void btn_Receptionist_Click(object sender, EventArgs e)
        {
            Form_Receptionist f = new Form_Receptionist(QLUserBLL.stoUser.IdUser, LoggedRole);
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

        //----- tbllaypn_Staff -----//
        private void btn_Business_Click(object sender, EventArgs e)
        {
            this.fllaypn_Business.Visible = (!this.fllaypn_Business.Visible);
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
