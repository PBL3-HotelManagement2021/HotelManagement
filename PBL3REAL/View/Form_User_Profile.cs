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
using System.IO;

namespace PBL3REAL.View
{
    
    public partial class Form_User_Profile : Form
    {
        /***** GLOBAL DECLARATION *****/
        //-> Delegation
        public delegate void MyDel();
        public MyDel myDel;

        //-> Global Parameter For User
        private QLUserBLL qLUserBLL;
        private UserVM userVM;
        private int ID = 0;
        private ImageVM TempAvatar;
        private bool Change;
        private bool editable;

        /***** CONSTRUCTOR *****/
        public Form_User_Profile(int id, string role, bool Editable,bool isForLogin)
        {
            InitializeComponent();
            qLUserBLL = new QLUserBLL();
            Change = false;
            editable = Editable;
            if (isForLogin)
            {
                loadForLogin(role);
            }
            else
            {
                ID = id;
                AddRoleToCbb();
                LoadDataForManage(Editable);
            }   
        }

        /***** PROCESSING FUNCTIONS ****/
        //-> Load Data Functions
        private void AddRoleToCbb()
        {
            foreach(var value in qLUserBLL.getRoleForUser())
            {
                cbb_Role.Items.Add(value);
            }
            cbb_Role.DisplayMember = "RoleName";
            cbb_Role.SelectedIndex = 0;
        }
        private void loadForLogin(string role)
        {
            lb_Header.Text = "   " + QLUserBLL.stoUser.UserCode + "   ";
            tb_Username.Text = QLUserBLL.stoUser.UserName;
            tb_Email.Text = QLUserBLL.stoUser.UserGmail;
            //tb_Password.Text = QLUserBLL.stoUser.UserPassword;
            tb_Phone.Text = QLUserBLL.stoUser.UserPhone;
            if (QLUserBLL.stoUser.UserGender)
            {
                rbtn_Male.Checked = true;
            }
            else
            {
                rbtn_Female.Checked = true;
            }
            cbb_Role.Items.Add(role);
            cbb_Role.SelectedIndex = 0;
            fllaypn_Header.Enabled = false;
            tbllaypn_UserInfo.Enabled = false;
            btn_OK.Enabled = false;
            btn_Reset.Enabled = false;
            lbx_User.Visible = false;
            fllaypn_User.Visible = false;
        }
        private void LoadDataForManage(bool Editable)
        {
            if (ID == 0)
            {
                userVM = new UserVM();
            }    
            else
            {
                userVM = qLUserBLL.findDetailUser(ID);
                //View or Edit
                lb_Header.Text = "   " + userVM.UserCode + "   ";
                tb_Username.Text = userVM.UserName;
                tb_Email.Text = userVM.UserGmail;
                //tb_Password.Text = userVM.UserPassword;
                tb_Phone.Text = userVM.UserPhone;
                if (userVM.UserGender)
                {
                    rbtn_Male.Checked = true;
                }
                else
                {
                    rbtn_Female.Checked = true;
                }
                foreach(var value in userVM.ListRole)
                {
                    lbx_User.Items.Add(value.RoleName);
                }
                if (userVM.ListImg.Count != 0)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(userVM.ListImg[0].ImgstoUrl, FileMode.Open))
                        {
                            picbx_Header.Image = Image.FromStream(fs);
                            picbx_Header.SizeMode = PictureBoxSizeMode.StretchImage;
                            fs.Close();
                        }
                        TempAvatar = new ImageVM { IdImgsto = userVM.ListImg[0].IdImgsto, ImgstoUrl = userVM.ListImg[0].ImgstoUrl };
                    }
                    catch (Exception e) 
                    { 
                        picbx_Header.BackgroundImage = Properties.Resources.nothing_found_fluent_color_96px;
                        picbx_Header.Image = null;
                    }
                }   
            }
            if (!Editable)
            {
                fllaypn_Header.Enabled = false;
                tbllaypn_UserInfo.Enabled = false;
                btn_OK.Enabled = false;
                btn_Reset.Enabled = false;
                fllaypn_User.Visible = false;
            }
        }
        //-> Check Data Functions
        private bool CheckVietNamChar(string s)
        {
            string[] VietNamChar = new string[]
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
                || (rbtn_Male.Checked == false && rbtn_Female.Checked == false) || lbx_User.Items.Count ==0)
            { return 0; }    
            if (int.TryParse(tb_Phone.Text,out phone) == false)
            { return 1; }
            if (tb_Email.Text.Contains(' ') == true || tb_Password.Text.Contains(' ') == true 
                || CheckVietNamChar(tb_Email.Text) == true || CheckVietNamChar(tb_Password.Text) == true)
            { return 2; }
            if (TempAvatar == null)
            { return 3; }
            return 4;
        }
        //-> CRUD User Functions
        private void AddUser()
        {
            userVM.UserName = tb_Username.Text.Replace(" ",String.Empty);
            userVM.UserPassword = tb_Password.Text.Replace(" ", String.Empty);
            userVM.UserGmail = tb_Email.Text.Replace(" ", String.Empty);
            userVM.UserPhone = tb_Phone.Text.Replace(" ", String.Empty);
            if (rbtn_Male.Checked)
            {
                userVM.UserGender = true;
            }
            else
            {
                userVM.UserGender = false;
            }
            userVM.ListImg.Clear();
            userVM.ListImg.Add(TempAvatar);
            qLUserBLL.addUser(userVM);
        }
        private void UpdateUserInfo()
        {
            userVM.UserName = tb_Username.Text.Replace(" ", String.Empty);
            userVM.UserPassword = tb_Password.Text.Replace(" ", String.Empty);
            userVM.UserGmail = tb_Email.Text.Replace(" ", String.Empty);
            userVM.UserPhone = tb_Phone.Text.Replace(" ", String.Empty);
            if (rbtn_Male.Checked)
            {
                userVM.UserGender = true;
            }
            else
            {
                userVM.UserGender = false;
            }
            userVM.ListImg.Clear();
            userVM.ListImg.Add(TempAvatar);
            qLUserBLL.updateUser(userVM, null);
        }
        //-> Create Storaging Folder
        private void CreateStoragingFolder()
        {
            string palettesPath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\User_Profile";
            try
            {
                // If the directory doesn't exist, create it.
                if (!System.IO.Directory.Exists(palettesPath))
                {
                    System.IO.Directory.CreateDirectory(palettesPath);
                }
            }
            catch (Exception)
            {
                // Fail silently
                MessageBox.Show("Error!");
            }
        }
        //-> Insert IMG
        private Image InsertIMG()
        {
            CreateStoragingFolder();
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(open.FileName);
            }
            return null;
        }
        //-> Delete IMG
        private void DeleteIMG(string fullpath)
        {
            try
            {
                File.Delete(fullpath);
            }
            catch (Exception e) { }
        }
        //-> Update IMG 
        private void UpdateIMG(string Fullpath)
        {
            if (File.Exists(Fullpath))
            {
                DeleteIMG(Fullpath);
            }
            picbx_Header.Image.Save(Fullpath, System.Drawing.Imaging.ImageFormat.Jpeg);
            TempAvatar = null;
            TempAvatar = new ImageVM { ImgstoUrl = Fullpath };
        }
        /***** EVENTS *****/
        //-> Form 
        //-> TableLayoutPanel User Info
        private void picbx_Header_Click(object sender, EventArgs e)
        {
            //Reset to default
            picbx_Header.BackgroundImage = null;
            picbx_Header.Image = Properties.Resources.male_user_fluent_color_96px;
            TempAvatar = null;
            if (userVM.ListImg.Count != 0) { Change = true; }
        }
        private void picbx_Header_DoubleClick(object sender, EventArgs e)
        {
            //Change avatar
            picbx_Header.BackgroundImage = null;
            picbx_Header.Image = InsertIMG();
            if (picbx_Header.Image != null)
            {
                picbx_Header.SizeMode = PictureBoxSizeMode.StretchImage;
                Change = true;
                TempAvatar = new ImageVM { ImgstoUrl = "" };
            }
            else
            {
                picbx_Header.BackgroundImage = null;
                picbx_Header.Image = Properties.Resources.male_user_fluent_color_96px;
            }    
        }
        private void picbx_Change_Click(object sender, EventArgs e)
        {
            if (editable && ID != 0) { tb_Password.Enabled = true; }
        }
        private void picbx_Add_Click(object sender, EventArgs e)
        {
            //Add role 
            RoleVM selected = (RoleVM)cbb_Role.SelectedItem;
            if (userVM.ListRole.FindIndex(x => x.RoleName.Equals(selected.RoleName)) != -1)
            {
                MessageBox.Show("This role has already added");
            }
            else
            {
                userVM.ListRole.Add(selected);
                lbx_User.Items.Add(selected.RoleName);
            }
        }
        private void picbx_Delete_Click(object sender, EventArgs e)
        {
            //Delete role
            userVM.ListRole.RemoveAt(userVM.ListRole.Count - 1);
            lbx_User.Items.RemoveAt(lbx_User.Items.Count - 1);
        }
        //-> TableLayoutPanel Control Buttons
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Username.Text = "";
            tb_Email.Text = "";
            tb_Phone.Text = "";
            tb_Password.Text = "";
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            cbb_Role.SelectedItem = null;
            lbx_User.Items.Clear();
            Change = true;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Bạn chưa thêm ảnh đại diện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    string Path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\User_Profile\\" + tb_Username.Text.Replace(" ", String.Empty) + ".Jpeg";
                    userVM.UserName = tb_Username.Text.Replace(" ", String.Empty);
                    userVM.UserPassword = tb_Password.Text.Replace(" ", String.Empty);
                    userVM.UserGmail = tb_Email.Text.Replace(" ", String.Empty);
                    userVM.UserPhone = tb_Phone.Text.Replace(" ", String.Empty);
                    if (rbtn_Male.Checked)
                    {
                        userVM.UserGender = true;
                    }
                    else
                    {
                        userVM.UserGender = false;
                    }
                    if(Change) UpdateIMG(Path);
                    userVM.ListImg.Clear();
                    userVM.ListImg.Add(TempAvatar);
                    ///properties to check existed
                    Dictionary<string, string> properties = new Dictionary<string, string>();
                    properties.Add("phone", userVM.UserPhone);
                    properties.Add("gmail", userVM.UserGmail);
                    if (ID == 0)
                    {
                        if(qLUserBLL.checkexisted(properties))
                        {
                            qLUserBLL.addUser(userVM);
                            MessageBox.Show("Thêm tài khoản nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Existed Email or Phone!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }        
                    }
                    else
                    {
                        properties.Add("code", userVM.UserCode);
                        if (qLUserBLL.checkexisted(properties))
                        {
                            qLUserBLL.updateUser(userVM, null);
                        MessageBox.Show("Cập nhật tài khoản nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Existed Email or Phone!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    myDel();
                    this.Dispose();
                    break;
                default:
                    break;
            }
        }
    }
}
