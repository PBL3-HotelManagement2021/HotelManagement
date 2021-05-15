using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.ViewModel;
using PBL3REAL.Extention;
namespace PBL3REAL.View
{
    public partial class Form_User_Profile : Form
    {
        private QLUserBLL qLUserBLL;
        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public Form_User_Profile(string role)
        {
            InitializeComponent();
            qLUserBLL = new QLUserBLL();
            addToCbb();
            LoadData(role);
        }
        //Load Data
        private void addToCbb()
        {
            cbb_Role.DataSource = qLUserBLL.getRoleForUser();
            cbb_Role.DisplayMember = "RoleName";
        }
        private void LoadData(string role)
        {
            tb_Username.Text = QLUserBLL.stoUser.UserName;
            tb_Email.Text = QLUserBLL.stoUser.UserGmail;
            tb_Password.Text = QLUserBLL.stoUser.UserPassword;
            tb_Phone.Text = QLUserBLL.stoUser.UserPhone;
            if (QLUserBLL.stoUser.UserGender)
            {
                rbtn_Male.Checked = true;
            }    
            else
            {
                rbtn_Female.Checked = true;
            }    
            foreach (CbbItem item in cbb_Role.Items)
            {
                if (item.text.Equals(role))
                {
                    cbb_Role.SelectedItem = item;
                    break;
                }    
            }
            cbb_Role.Enabled = false;
        }
        //Check Data
        private bool CheckVietNamChar(string s)
        {
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                {
                    if (s.Contains(VietNamChar[i][j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private int CheckData()
        {
            int phone = 0;
            if (tb_Username.Text == "" || tb_Email.Text == "" || tb_Password.Text == "" || tb_Phone.Text == "" 
                || (rbtn_Male.Checked == false && rbtn_Female.Checked == false))
            { return 0; }    
            if (int.TryParse(tb_Phone.Text,out phone) == false)
            { return 1; }
            if (tb_Email.Text.Contains(' ') == true || tb_Password.Text.Contains(' ') == true 
                || CheckVietNamChar(tb_Email.Text) == true || CheckVietNamChar(tb_Password.Text) == true)
            { return 2; }
            return 3;
        }
        //Update Data
        private void UpdateUserInfo()
        {
            UserVM temp = new UserVM();
            temp.UserName = tb_Username.Text;
            temp.UserPassword = tb_Password.Text;
            temp.UserPhone = tb_Phone.Text;
            temp.UserGmail = tb_Email.Text;
            temp.UserCode = lb_Header.Text;
            //Chưa xong
            //qLUserBLL.updateUser(temp,);
        }
        //Events
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset Data
            tb_Username.Text = "";
            tb_Email.Text = "";
            tb_Phone.Text = "";
            tb_Password.Text = "";
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            //Check Data
            switch (CheckData())
            {
                case 0:
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("Số điện thoại bạn nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Email hoặc mật khẩu bạn nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    //Gọi hàm xử lí update data
                    break;
                default:
                    break;
            }
        }
    }
}
