
namespace PBL3REAL.View
{
    partial class Form_Detail_Client
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
            this.tbllaypn_Client = new System.Windows.Forms.TableLayoutPanel();
            this.lb_ClientCode = new System.Windows.Forms.Label();
            this.tb_ClientCode = new System.Windows.Forms.TextBox();
            this.lb_ClientName = new System.Windows.Forms.Label();
            this.tb_ClientName = new System.Windows.Forms.TextBox();
            this.lb_ClientPhone = new System.Windows.Forms.Label();
            this.lb_ClientEmail = new System.Windows.Forms.Label();
            this.tb_ClientPhone = new System.Windows.Forms.TextBox();
            this.tb_ClientEmail = new System.Windows.Forms.TextBox();
            this.lb_Header = new System.Windows.Forms.Label();
            this.tbllaypn_ControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tbllaypn_Client.SuspendLayout();
            this.tbllaypn_ControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbllaypn_Client
            // 
            this.tbllaypn_Client.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbllaypn_Client.ColumnCount = 2;
            this.tbllaypn_Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.50962F));
            this.tbllaypn_Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.49038F));
            this.tbllaypn_Client.Controls.Add(this.tb_ClientEmail, 1, 3);
            this.tbllaypn_Client.Controls.Add(this.tb_ClientPhone, 1, 2);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientPhone, 0, 2);
            this.tbllaypn_Client.Controls.Add(this.tb_ClientName, 1, 1);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientName, 0, 1);
            this.tbllaypn_Client.Controls.Add(this.tb_ClientCode, 1, 0);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientCode, 0, 0);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientEmail, 0, 3);
            this.tbllaypn_Client.Location = new System.Drawing.Point(27, 138);
            this.tbllaypn_Client.Name = "tbllaypn_Client";
            this.tbllaypn_Client.RowCount = 4;
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_Client.Size = new System.Drawing.Size(416, 225);
            this.tbllaypn_Client.TabIndex = 0;
            // 
            // lb_ClientCode
            // 
            this.lb_ClientCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientCode.AutoSize = true;
            this.lb_ClientCode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientCode.Location = new System.Drawing.Point(3, 12);
            this.lb_ClientCode.Name = "lb_ClientCode";
            this.lb_ClientCode.Size = new System.Drawing.Size(171, 31);
            this.lb_ClientCode.TabIndex = 0;
            this.lb_ClientCode.Text = "Mã khách hàng";
            // 
            // tb_ClientCode
            // 
            this.tb_ClientCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientCode.Enabled = false;
            this.tb_ClientCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_ClientCode.Location = new System.Drawing.Point(184, 11);
            this.tb_ClientCode.Name = "tb_ClientCode";
            this.tb_ClientCode.Size = new System.Drawing.Size(229, 34);
            this.tb_ClientCode.TabIndex = 0;
            this.tb_ClientCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_ClientName
            // 
            this.lb_ClientName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientName.AutoSize = true;
            this.lb_ClientName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientName.Location = new System.Drawing.Point(3, 68);
            this.lb_ClientName.Name = "lb_ClientName";
            this.lb_ClientName.Size = new System.Drawing.Size(173, 31);
            this.lb_ClientName.TabIndex = 0;
            this.lb_ClientName.Text = "Tên khách hàng";
            // 
            // tb_ClientName
            // 
            this.tb_ClientName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_ClientName.Location = new System.Drawing.Point(184, 67);
            this.tb_ClientName.Name = "tb_ClientName";
            this.tb_ClientName.Size = new System.Drawing.Size(229, 34);
            this.tb_ClientName.TabIndex = 1;
            this.tb_ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_ClientPhone
            // 
            this.lb_ClientPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientPhone.AutoSize = true;
            this.lb_ClientPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientPhone.Location = new System.Drawing.Point(3, 124);
            this.lb_ClientPhone.Name = "lb_ClientPhone";
            this.lb_ClientPhone.Size = new System.Drawing.Size(148, 31);
            this.lb_ClientPhone.TabIndex = 0;
            this.lb_ClientPhone.Text = "Số điện thoại";
            // 
            // lb_ClientEmail
            // 
            this.lb_ClientEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientEmail.AutoSize = true;
            this.lb_ClientEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientEmail.Location = new System.Drawing.Point(3, 181);
            this.lb_ClientEmail.Name = "lb_ClientEmail";
            this.lb_ClientEmail.Size = new System.Drawing.Size(70, 31);
            this.lb_ClientEmail.TabIndex = 0;
            this.lb_ClientEmail.Text = "Email";
            // 
            // tb_ClientPhone
            // 
            this.tb_ClientPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_ClientPhone.Location = new System.Drawing.Point(184, 123);
            this.tb_ClientPhone.Name = "tb_ClientPhone";
            this.tb_ClientPhone.Size = new System.Drawing.Size(229, 34);
            this.tb_ClientPhone.TabIndex = 2;
            this.tb_ClientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ClientEmail
            // 
            this.tb_ClientEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_ClientEmail.Location = new System.Drawing.Point(184, 179);
            this.tb_ClientEmail.Name = "tb_ClientEmail";
            this.tb_ClientEmail.Size = new System.Drawing.Size(229, 34);
            this.tb_ClientEmail.TabIndex = 3;
            this.tb_ClientEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Header
            // 
            this.lb_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(178, 27);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(131, 45);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "CLIENT";
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
            this.tbllaypn_ControlButtons.Location = new System.Drawing.Point(99, 498);
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
            this.btn_OK.Location = new System.Drawing.Point(4, 3);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(83, 40);
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
            this.btn_Reset.Location = new System.Drawing.Point(96, 3);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(83, 40);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form_Detail_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(472, 556);
            this.Controls.Add(this.tbllaypn_ControlButtons);
            this.Controls.Add(this.lb_Header);
            this.Controls.Add(this.tbllaypn_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Detail_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Detail_Client";
            this.tbllaypn_Client.ResumeLayout(false);
            this.tbllaypn_Client.PerformLayout();
            this.tbllaypn_ControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbllaypn_Client;
        private System.Windows.Forms.Label lb_ClientCode;
        private System.Windows.Forms.Label lb_ClientName;
        private System.Windows.Forms.TextBox tb_ClientCode;
        private System.Windows.Forms.Label lb_ClientPhone;
        private System.Windows.Forms.TextBox tb_ClientName;
        private System.Windows.Forms.Label lb_ClientEmail;
        private System.Windows.Forms.TextBox tb_ClientEmail;
        private System.Windows.Forms.TextBox tb_ClientPhone;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ControlButtons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Reset;
    }
}