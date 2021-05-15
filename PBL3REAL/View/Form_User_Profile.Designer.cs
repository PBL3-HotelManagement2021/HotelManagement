
namespace PBL3REAL.View
{
    partial class Form_User_Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User_Profile));
            this.fllaypn_Header = new System.Windows.Forms.FlowLayoutPanel();
            this.picbx_Header = new System.Windows.Forms.PictureBox();
            this.lb_Header = new System.Windows.Forms.Label();
            this.tbllaypn_UserInfo = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_Role = new System.Windows.Forms.ComboBox();
            this.lb_Role = new System.Windows.Forms.Label();
            this.tbllaypn_Gender = new System.Windows.Forms.TableLayoutPanel();
            this.rbtn_Male = new System.Windows.Forms.RadioButton();
            this.rbtn_Female = new System.Windows.Forms.RadioButton();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lb_Username = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tbllaypn_ControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.fllaypn_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Header)).BeginInit();
            this.tbllaypn_UserInfo.SuspendLayout();
            this.tbllaypn_Gender.SuspendLayout();
            this.tbllaypn_ControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // fllaypn_Header
            // 
            this.fllaypn_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fllaypn_Header.Controls.Add(this.picbx_Header);
            this.fllaypn_Header.Controls.Add(this.lb_Header);
            this.fllaypn_Header.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fllaypn_Header.Location = new System.Drawing.Point(196, 12);
            this.fllaypn_Header.Name = "fllaypn_Header";
            this.fllaypn_Header.Size = new System.Drawing.Size(170, 134);
            this.fllaypn_Header.TabIndex = 0;
            // 
            // picbx_Header
            // 
            this.picbx_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picbx_Header.Image = global::PBL3REAL.Properties.Resources.male_user_fluent_color_96px;
            this.picbx_Header.Location = new System.Drawing.Point(39, 3);
            this.picbx_Header.Name = "picbx_Header";
            this.picbx_Header.Size = new System.Drawing.Size(91, 90);
            this.picbx_Header.TabIndex = 0;
            this.picbx_Header.TabStop = false;
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(3, 96);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(164, 31);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "User ID: ..........";
            this.lb_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbllaypn_UserInfo
            // 
            this.tbllaypn_UserInfo.ColumnCount = 2;
            this.tbllaypn_UserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.94975F));
            this.tbllaypn_UserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.05025F));
            this.tbllaypn_UserInfo.Controls.Add(this.cbb_Role, 1, 5);
            this.tbllaypn_UserInfo.Controls.Add(this.lb_Role, 0, 5);
            this.tbllaypn_UserInfo.Controls.Add(this.tbllaypn_Gender, 1, 4);
            this.tbllaypn_UserInfo.Controls.Add(this.lb_Gender, 0, 4);
            this.tbllaypn_UserInfo.Controls.Add(this.lb_Phone, 0, 3);
            this.tbllaypn_UserInfo.Controls.Add(this.tb_Password, 1, 1);
            this.tbllaypn_UserInfo.Controls.Add(this.tb_Username, 1, 0);
            this.tbllaypn_UserInfo.Controls.Add(this.lb_Username, 0, 0);
            this.tbllaypn_UserInfo.Controls.Add(this.tb_Phone, 1, 3);
            this.tbllaypn_UserInfo.Controls.Add(this.tb_Email, 1, 2);
            this.tbllaypn_UserInfo.Controls.Add(this.lb_Email, 0, 2);
            this.tbllaypn_UserInfo.Controls.Add(this.lb_Password, 0, 1);
            this.tbllaypn_UserInfo.Location = new System.Drawing.Point(83, 172);
            this.tbllaypn_UserInfo.Name = "tbllaypn_UserInfo";
            this.tbllaypn_UserInfo.RowCount = 6;
            this.tbllaypn_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbllaypn_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbllaypn_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbllaypn_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbllaypn_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbllaypn_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbllaypn_UserInfo.Size = new System.Drawing.Size(398, 309);
            this.tbllaypn_UserInfo.TabIndex = 0;
            // 
            // cbb_Role
            // 
            this.cbb_Role.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_Role.FormattingEnabled = true;
            this.cbb_Role.Location = new System.Drawing.Point(162, 264);
            this.cbb_Role.Name = "cbb_Role";
            this.cbb_Role.Size = new System.Drawing.Size(233, 36);
            this.cbb_Role.TabIndex = 7;
            // 
            // lb_Role
            // 
            this.lb_Role.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Role.AutoSize = true;
            this.lb_Role.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Role.Location = new System.Drawing.Point(3, 266);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(62, 31);
            this.lb_Role.TabIndex = 0;
            this.lb_Role.Text = "Vị trí";
            this.lb_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbllaypn_Gender
            // 
            this.tbllaypn_Gender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbllaypn_Gender.ColumnCount = 2;
            this.tbllaypn_Gender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tbllaypn_Gender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tbllaypn_Gender.Controls.Add(this.rbtn_Male, 0, 0);
            this.tbllaypn_Gender.Controls.Add(this.rbtn_Female, 1, 0);
            this.tbllaypn_Gender.Location = new System.Drawing.Point(162, 210);
            this.tbllaypn_Gender.Name = "tbllaypn_Gender";
            this.tbllaypn_Gender.RowCount = 1;
            this.tbllaypn_Gender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllaypn_Gender.Size = new System.Drawing.Size(233, 39);
            this.tbllaypn_Gender.TabIndex = 0;
            // 
            // rbtn_Male
            // 
            this.rbtn_Male.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtn_Male.AutoSize = true;
            this.rbtn_Male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Male.Location = new System.Drawing.Point(3, 3);
            this.rbtn_Male.Name = "rbtn_Male";
            this.rbtn_Male.Size = new System.Drawing.Size(75, 32);
            this.rbtn_Male.TabIndex = 5;
            this.rbtn_Male.TabStop = true;
            this.rbtn_Male.Text = "Nam";
            this.rbtn_Male.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Male.UseVisualStyleBackColor = true;
            // 
            // rbtn_Female
            // 
            this.rbtn_Female.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbtn_Female.AutoSize = true;
            this.rbtn_Female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Female.Location = new System.Drawing.Point(117, 3);
            this.rbtn_Female.Name = "rbtn_Female";
            this.rbtn_Female.Size = new System.Drawing.Size(60, 32);
            this.rbtn_Female.TabIndex = 6;
            this.rbtn_Female.TabStop = true;
            this.rbtn_Female.Text = "Nữ";
            this.rbtn_Female.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtn_Female.UseVisualStyleBackColor = true;
            // 
            // lb_Gender
            // 
            this.lb_Gender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Gender.Location = new System.Drawing.Point(3, 214);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(102, 31);
            this.lb_Gender.TabIndex = 0;
            this.lb_Gender.Text = "Giới tính";
            this.lb_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Phone
            // 
            this.lb_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Phone.Location = new System.Drawing.Point(3, 163);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(148, 31);
            this.lb_Phone.TabIndex = 0;
            this.lb_Phone.Text = "Số điện thoại";
            this.lb_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Password.Location = new System.Drawing.Point(162, 59);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(233, 34);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Username.Location = new System.Drawing.Point(162, 8);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(233, 34);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Username
            // 
            this.lb_Username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Username.Location = new System.Drawing.Point(3, 10);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(149, 31);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "Tên tài khoản";
            this.lb_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Phone.Location = new System.Drawing.Point(162, 161);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(233, 34);
            this.tb_Phone.TabIndex = 4;
            this.tb_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Email
            // 
            this.tb_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Email.Location = new System.Drawing.Point(162, 110);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(233, 34);
            this.tb_Email.TabIndex = 3;
            this.tb_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Email
            // 
            this.lb_Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Email.Location = new System.Drawing.Point(3, 112);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(70, 31);
            this.lb_Email.TabIndex = 0;
            this.lb_Email.Text = "Email";
            this.lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Password
            // 
            this.lb_Password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Password.Location = new System.Drawing.Point(3, 61);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(110, 31);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "Mật khẩu";
            this.lb_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbllaypn_ControlButtons
            // 
            this.tbllaypn_ControlButtons.ColumnCount = 3;
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.68421F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.63158F));
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_Cancel, 2, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_OK, 0, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_Reset, 1, 0);
            this.tbllaypn_ControlButtons.Location = new System.Drawing.Point(149, 544);
            this.tbllaypn_ControlButtons.Name = "tbllaypn_ControlButtons";
            this.tbllaypn_ControlButtons.RowCount = 1;
            this.tbllaypn_ControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllaypn_ControlButtons.Size = new System.Drawing.Size(273, 46);
            this.tbllaypn_ControlButtons.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.Location = new System.Drawing.Point(186, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(83, 40);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OK.Location = new System.Drawing.Point(4, 4);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(83, 38);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(96, 4);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(83, 38);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form_User_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(554, 614);
            this.Controls.Add(this.tbllaypn_ControlButtons);
            this.Controls.Add(this.tbllaypn_UserInfo);
            this.Controls.Add(this.fllaypn_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_User_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_User_Profile";
            this.fllaypn_Header.ResumeLayout(false);
            this.fllaypn_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Header)).EndInit();
            this.tbllaypn_UserInfo.ResumeLayout(false);
            this.tbllaypn_UserInfo.PerformLayout();
            this.tbllaypn_Gender.ResumeLayout(false);
            this.tbllaypn_Gender.PerformLayout();
            this.tbllaypn_ControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fllaypn_Header;
        private System.Windows.Forms.PictureBox picbx_Header;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_UserInfo;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_Gender;
        private System.Windows.Forms.RadioButton rbtn_Male;
        private System.Windows.Forms.RadioButton rbtn_Female;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.ComboBox cbb_Role;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ControlButtons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Reset;
    }
}