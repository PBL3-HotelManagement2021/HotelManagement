
namespace PBL3REAL.View
{
    partial class Form_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Staff));
            this.tbllaypn_Staff = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_Business = new System.Windows.Forms.Button();
            this.fllaypn_Header = new System.Windows.Forms.FlowLayoutPanel();
            this.picbx_Header = new System.Windows.Forms.PictureBox();
            this.lb_Header = new System.Windows.Forms.Label();
            this.fllaypn_Clerk = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Accountant_Clerk = new System.Windows.Forms.Button();
            this.btn_Client_Clerk = new System.Windows.Forms.Button();
            this.fllaypn_Receptionist = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Receptionist_Receptionist = new System.Windows.Forms.Button();
            this.btn_Accountant_Receptionist = new System.Windows.Forms.Button();
            this.btn_Client_Receptionist = new System.Windows.Forms.Button();
            this.tbllaypn_Staff.SuspendLayout();
            this.fllaypn_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Header)).BeginInit();
            this.fllaypn_Clerk.SuspendLayout();
            this.fllaypn_Receptionist.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbllaypn_Staff
            // 
            this.tbllaypn_Staff.ColumnCount = 3;
            this.tbllaypn_Staff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Staff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Staff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Staff.Controls.Add(this.btn_Logout, 2, 0);
            this.tbllaypn_Staff.Controls.Add(this.btn_Profile, 1, 0);
            this.tbllaypn_Staff.Controls.Add(this.btn_Business, 0, 0);
            this.tbllaypn_Staff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbllaypn_Staff.Location = new System.Drawing.Point(0, 313);
            this.tbllaypn_Staff.Name = "tbllaypn_Staff";
            this.tbllaypn_Staff.RowCount = 1;
            this.tbllaypn_Staff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllaypn_Staff.Size = new System.Drawing.Size(463, 140);
            this.tbllaypn_Staff.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Image = global::PBL3REAL.Properties.Resources.sign_out_fluent_color_96px;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Logout.Location = new System.Drawing.Point(311, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(149, 134);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Image = global::PBL3REAL.Properties.Resources.male_user_fluent_color_96px;
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Profile.Location = new System.Drawing.Point(157, 3);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(148, 134);
            this.btn_Profile.TabIndex = 0;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Business
            // 
            this.btn_Business.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Business.FlatAppearance.BorderSize = 0;
            this.btn_Business.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Business.Image = global::PBL3REAL.Properties.Resources.task_fluent_color_96px;
            this.btn_Business.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Business.Location = new System.Drawing.Point(3, 3);
            this.btn_Business.Name = "btn_Business";
            this.btn_Business.Size = new System.Drawing.Size(148, 134);
            this.btn_Business.TabIndex = 0;
            this.btn_Business.Text = "Business";
            this.btn_Business.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Business.UseVisualStyleBackColor = true;
            this.btn_Business.Click += new System.EventHandler(this.btn_Business_Click);
            // 
            // fllaypn_Header
            // 
            this.fllaypn_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fllaypn_Header.Controls.Add(this.picbx_Header);
            this.fllaypn_Header.Controls.Add(this.lb_Header);
            this.fllaypn_Header.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fllaypn_Header.Location = new System.Drawing.Point(150, 12);
            this.fllaypn_Header.Name = "fllaypn_Header";
            this.fllaypn_Header.Size = new System.Drawing.Size(165, 132);
            this.fllaypn_Header.TabIndex = 0;
            // 
            // picbx_Header
            // 
            this.picbx_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picbx_Header.Image = global::PBL3REAL.Properties.Resources.male_user_fluent_color_96px;
            this.picbx_Header.Location = new System.Drawing.Point(36, 3);
            this.picbx_Header.Name = "picbx_Header";
            this.picbx_Header.Size = new System.Drawing.Size(91, 90);
            this.picbx_Header.TabIndex = 0;
            this.picbx_Header.TabStop = false;
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(3, 96);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(157, 30);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "........................";
            this.lb_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fllaypn_Clerk
            // 
            this.fllaypn_Clerk.Controls.Add(this.btn_Accountant_Clerk);
            this.fllaypn_Clerk.Controls.Add(this.btn_Client_Clerk);
            this.fllaypn_Clerk.Location = new System.Drawing.Point(0, 200);
            this.fllaypn_Clerk.Name = "fllaypn_Clerk";
            this.fllaypn_Clerk.Size = new System.Drawing.Size(250, 113);
            this.fllaypn_Clerk.TabIndex = 0;
            // 
            // btn_Accountant_Clerk
            // 
            this.btn_Accountant_Clerk.FlatAppearance.BorderSize = 0;
            this.btn_Accountant_Clerk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accountant_Clerk.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Accountant_Clerk.Image = global::PBL3REAL.Properties.Resources.accounting_fluent_color_72px;
            this.btn_Accountant_Clerk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Accountant_Clerk.Location = new System.Drawing.Point(3, 3);
            this.btn_Accountant_Clerk.Name = "btn_Accountant_Clerk";
            this.btn_Accountant_Clerk.Size = new System.Drawing.Size(117, 107);
            this.btn_Accountant_Clerk.TabIndex = 0;
            this.btn_Accountant_Clerk.Text = "Accountant";
            this.btn_Accountant_Clerk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Accountant_Clerk.UseVisualStyleBackColor = true;
            this.btn_Accountant_Clerk.Click += new System.EventHandler(this.btn_Accountant_Clerk_Click);
            // 
            // btn_Client_Clerk
            // 
            this.btn_Client_Clerk.FlatAppearance.BorderSize = 0;
            this.btn_Client_Clerk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Client_Clerk.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Client_Clerk.Image = global::PBL3REAL.Properties.Resources.client_management_fluent_color_72px;
            this.btn_Client_Clerk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Client_Clerk.Location = new System.Drawing.Point(126, 3);
            this.btn_Client_Clerk.Name = "btn_Client_Clerk";
            this.btn_Client_Clerk.Size = new System.Drawing.Size(117, 107);
            this.btn_Client_Clerk.TabIndex = 0;
            this.btn_Client_Clerk.Text = "Client";
            this.btn_Client_Clerk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Client_Clerk.UseVisualStyleBackColor = true;
            this.btn_Client_Clerk.Click += new System.EventHandler(this.btn_Client_Clerk_Click);
            // 
            // fllaypn_Receptionist
            // 
            this.fllaypn_Receptionist.Controls.Add(this.btn_Receptionist_Receptionist);
            this.fllaypn_Receptionist.Controls.Add(this.btn_Accountant_Receptionist);
            this.fllaypn_Receptionist.Controls.Add(this.btn_Client_Receptionist);
            this.fllaypn_Receptionist.Location = new System.Drawing.Point(32, 72);
            this.fllaypn_Receptionist.Name = "fllaypn_Receptionist";
            this.fllaypn_Receptionist.Size = new System.Drawing.Size(374, 113);
            this.fllaypn_Receptionist.TabIndex = 0;
            // 
            // btn_Receptionist_Receptionist
            // 
            this.btn_Receptionist_Receptionist.FlatAppearance.BorderSize = 0;
            this.btn_Receptionist_Receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Receptionist_Receptionist.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Receptionist_Receptionist.Image = global::PBL3REAL.Properties.Resources.front_desk_fluent_color_72px;
            this.btn_Receptionist_Receptionist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Receptionist_Receptionist.Location = new System.Drawing.Point(3, 3);
            this.btn_Receptionist_Receptionist.Name = "btn_Receptionist_Receptionist";
            this.btn_Receptionist_Receptionist.Size = new System.Drawing.Size(117, 107);
            this.btn_Receptionist_Receptionist.TabIndex = 0;
            this.btn_Receptionist_Receptionist.Text = "Receptionist";
            this.btn_Receptionist_Receptionist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Receptionist_Receptionist.UseVisualStyleBackColor = true;
            this.btn_Receptionist_Receptionist.Click += new System.EventHandler(this.btn_Receptionist_Receptionist_Click);
            // 
            // btn_Accountant_Receptionist
            // 
            this.btn_Accountant_Receptionist.FlatAppearance.BorderSize = 0;
            this.btn_Accountant_Receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accountant_Receptionist.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Accountant_Receptionist.Image = global::PBL3REAL.Properties.Resources.accounting_fluent_color_72px;
            this.btn_Accountant_Receptionist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Accountant_Receptionist.Location = new System.Drawing.Point(126, 3);
            this.btn_Accountant_Receptionist.Name = "btn_Accountant_Receptionist";
            this.btn_Accountant_Receptionist.Size = new System.Drawing.Size(117, 107);
            this.btn_Accountant_Receptionist.TabIndex = 0;
            this.btn_Accountant_Receptionist.Text = "Accountant";
            this.btn_Accountant_Receptionist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Accountant_Receptionist.UseVisualStyleBackColor = true;
            this.btn_Accountant_Receptionist.Click += new System.EventHandler(this.btn_Accountant_Receptionist_Click);
            // 
            // btn_Client_Receptionist
            // 
            this.btn_Client_Receptionist.FlatAppearance.BorderSize = 0;
            this.btn_Client_Receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Client_Receptionist.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Client_Receptionist.Image = global::PBL3REAL.Properties.Resources.client_management_fluent_color_72px;
            this.btn_Client_Receptionist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Client_Receptionist.Location = new System.Drawing.Point(249, 3);
            this.btn_Client_Receptionist.Name = "btn_Client_Receptionist";
            this.btn_Client_Receptionist.Size = new System.Drawing.Size(117, 107);
            this.btn_Client_Receptionist.TabIndex = 0;
            this.btn_Client_Receptionist.Text = "Client";
            this.btn_Client_Receptionist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Client_Receptionist.UseVisualStyleBackColor = true;
            this.btn_Client_Receptionist.Click += new System.EventHandler(this.btn_Client_Receptionist_Click);
            // 
            // Form_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(463, 453);
            this.Controls.Add(this.fllaypn_Receptionist);
            this.Controls.Add(this.fllaypn_Clerk);
            this.Controls.Add(this.fllaypn_Header);
            this.Controls.Add(this.tbllaypn_Staff);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Staff";
            this.tbllaypn_Staff.ResumeLayout(false);
            this.fllaypn_Header.ResumeLayout(false);
            this.fllaypn_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Header)).EndInit();
            this.fllaypn_Clerk.ResumeLayout(false);
            this.fllaypn_Receptionist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbllaypn_Staff;
        private System.Windows.Forms.Button btn_Business;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Header;
        private System.Windows.Forms.PictureBox picbx_Header;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Clerk;
        private System.Windows.Forms.Button btn_Accountant_Clerk;
        private System.Windows.Forms.Button btn_Client_Clerk;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Receptionist;
        private System.Windows.Forms.Button btn_Receptionist_Receptionist;
        private System.Windows.Forms.Button btn_Accountant_Receptionist;
        private System.Windows.Forms.Button btn_Client_Receptionist;
    }
}