using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
using PBL3REAL.Extention;

namespace PBL3REAL.View
{
    public partial class Form_Login : Form
    {
        //---------- GLOBAL DECLARATION ----------//
        //----- Account Instance Variables -----//
        private QLUserBLL qLUserBLL;

        //---------- FORM CONSTRUCTOR ----------//
        public Form_Login()
        {
            //--- Initialize ----//
            InitializeComponent();
            qLUserBLL = new QLUserBLL();
        }

        //---------- FUNCTIONS ----------//
        //----- Check Data  -----//
        private bool CheckData()
        {
            if (ValidateCode.TotalValidate(tb_Usercode.Text) == false || Password.ValidatePassword(tb_Password.Text) == false)
            { return false; }
            return true;
        }

        //----- Check User  -----//
        private bool CheckUser()
        {
            bool check = false;
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("code", tb_Usercode.Text);
            properties.Add("password", tb_Password.Text);
            try
            {
                UserVM userVM = qLUserBLL.checkUser(properties);
                if (userVM != null)
                {
                    check = true;
                }
            }
            catch (Exception) {}
            return check;
        }

        //---------- EVENTS ----------//
        //----- fllaypn_ControlBar -----//
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //----- tbllaypn_LoginInfo -----//
        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            toolTip_Warning.SetToolTip(tb_Usercode, "Username must not contain Vietnamese Chars or White Space");
            toolTip_Warning.ToolTipIcon = ToolTipIcon.Warning;
        }
        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            toolTip_Warning.SetToolTip(tb_Password, "Password must not contain Vietnamese Chars or White Space");
            toolTip_Warning.ToolTipIcon = ToolTipIcon.Warning;
        }

        //----- btn_Login -----//
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Check Data
            if (CheckData())
            {
                //Gọi hàm kiểm tra & cho phép đăng nhập
                if (CheckUser())
                {
                    Form_Switch_Role f = new Form_Switch_Role();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("The Usercode or Password you entered is incorrect. Please try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The Usercode or Password you entered is invalid. Please try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
