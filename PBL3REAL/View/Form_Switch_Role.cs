using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.BLL.Interfaces;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class Form_Switch_Role : Form
    {
        //---------- GLOBAL DECLARATION ----------//
        //----- User Instance Variables -----//
        private IUserBLL qLUserBLL;

        //---------- FORM CONSTRUCTOR ----------//
        public Form_Switch_Role()
        {
            //--- Initialize ----//
            InitializeComponent();
            qLUserBLL = new QLUserBLL();

            //--- Load Data ----//
            LoadData();
            addToCbb();
        }

        //---------- FUNCTIONS ----------//
        //----- Load Data -----//
        private void LoadData()
        {
            picbx_Header.SizeMode = PictureBoxSizeMode.StretchImage;
            lb_Header.Text = "   " + QLUserBLL.stoUser.UserCode + "   ";
        }
        private void addToCbb()
        {
            cbb_LoginRole.DataSource = qLUserBLL.GetRoleForUser();
            cbb_LoginRole.DisplayMember = "RoleName";
        }

        //---------- EVENTS ----------//
        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool find = false;
            string role = ((RoleVM)cbb_LoginRole.SelectedItem).RoleName;
            if (role != null)
            {
                foreach (RoleVM roleVM in QLUserBLL.stoUser.ListRole)
                {
                    if (roleVM.RoleName.Equals(role))
                    {
                        roleVM.IsSelected = true;
                        find = true;
                        if (role == "Admin")
                        {                          
                            Form_Admin f = new Form_Admin(QLUserBLL.stoUser.IdUser, role);
                            this.Hide();
                            f.ShowDialog();
                        }
                        else if (role == "Clerk")
                        {
                            Form_Staff f = new Form_Staff(QLUserBLL.stoUser.IdUser, role);
                            this.Hide();
                            f.ShowDialog();
                        }
                        else if (role == "Receptionist")
                        {
                            Form_Staff f = new Form_Staff(QLUserBLL.stoUser.IdUser, role);
                            this.Hide();
                            f.ShowDialog();
                        }
                        roleVM.IsSelected = false;
                        this.Show();
                        break;
                    }
                }
                if (!find)  { MessageBox.Show("You can't log in with this role!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("You must choose a role to log in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
