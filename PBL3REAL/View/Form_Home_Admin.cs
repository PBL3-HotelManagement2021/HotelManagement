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
        private string RoleLogged = "";
        public Form_Home_Admin(string role)
        {
            InitializeComponent();
            SetVisible(1);
            RoleLogged = role;
        }
        //Set GUI
        private void SetVisible(int tab)
        {
            fllaypn_Menu.Visible = false;
            userControl_Receptionist_Admin.Visible = false;
            userControl_Accountant_Admin.Visible = false;
            switch(tab)
            {
                case 1:
                    //Home
                    break;
                case 2:
                    //Receptionist
                    userControl_Receptionist_Admin.Visible = true;
                    break;
                case 3:
                    //Service
                    break;
                case 4:
                    //Accountant
                    userControl_Accountant_Admin.Visible = true;
                    break;
                case 5:
                    //Human Resources
                    break;
                default:
                    break;
            }
        }
        //Events
        private void Form_Home_Admin_VisibleChanged(object sender, EventArgs e)
        {
            fllaypn_Menu.Visible = false;
        }
        private void btn_Receptionist_Click(object sender, EventArgs e)
        {
            SetVisible(2);
        }
        private void btn_Accountant_Click(object sender, EventArgs e)
        {
            SetVisible(4);
        }
        private void btn_Menu_VisibleChanged(object sender, EventArgs e)
        {
            //fllaypn_Menu.Visible = true;
            fllaypn_Menu.Visible = (!fllaypn_Menu.Visible);
        }
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Form_User_Profile f = new Form_User_Profile(RoleLogged);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
//www.csharp-tutorial.hu/wp-content/uploads/2017/01/printform.png
//stackoverflow.com/questions/4370779/print-invoice-c-sharp-winforms


