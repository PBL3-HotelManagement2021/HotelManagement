
namespace PBL3REAL.View
{
    partial class Form_Detail_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Detail_Invoice));
            this.lb_Header = new System.Windows.Forms.Label();
            this.grbx_BookingInfo = new System.Windows.Forms.GroupBox();
            this.tbllaypn_BookingInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lb_BookingDate = new System.Windows.Forms.Label();
            this.lb_BookingCode = new System.Windows.Forms.Label();
            this.lb_BookingDeposit = new System.Windows.Forms.Label();
            this.tb_BookingCode = new System.Windows.Forms.TextBox();
            this.tb_BookingDate = new System.Windows.Forms.TextBox();
            this.tb_BookingDeposit = new System.Windows.Forms.TextBox();
            this.grbx_PayerInfo = new System.Windows.Forms.GroupBox();
            this.tbllaypn_PayerInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_FullName = new System.Windows.Forms.Label();
            this.lb_Gmail = new System.Windows.Forms.Label();
            this.tb_FullName = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_Gmail = new System.Windows.Forms.TextBox();
            this.lb_PaymentDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_PaymentDate = new System.Windows.Forms.TextBox();
            this.lb_CheckinDate = new System.Windows.Forms.Label();
            this.lb_CreateDate = new System.Windows.Forms.Label();
            this.lb_LastUpdateDate = new System.Windows.Forms.Label();
            this.tb_CheckinDate = new System.Windows.Forms.TextBox();
            this.tb_CreateDate = new System.Windows.Forms.TextBox();
            this.tb_LastUpdateDate = new System.Windows.Forms.TextBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.fllaypn_Total = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lb_InvoiceID = new System.Windows.Forms.Label();
            this.tbllaypn_ControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbx_BookingInfo.SuspendLayout();
            this.tbllaypn_BookingInfo.SuspendLayout();
            this.grbx_PayerInfo.SuspendLayout();
            this.tbllaypn_PayerInfo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.fllaypn_Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tbllaypn_ControlButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Header
            // 
            this.lb_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(375, 5);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(111, 32);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "INVOICE";
            this.lb_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbx_BookingInfo
            // 
            this.grbx_BookingInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbx_BookingInfo.Controls.Add(this.tbllaypn_BookingInfo);
            this.grbx_BookingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbx_BookingInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_BookingInfo.Location = new System.Drawing.Point(3, 2);
            this.grbx_BookingInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_BookingInfo.Name = "grbx_BookingInfo";
            this.grbx_BookingInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_BookingInfo.Size = new System.Drawing.Size(407, 184);
            this.grbx_BookingInfo.TabIndex = 0;
            this.grbx_BookingInfo.TabStop = false;
            this.grbx_BookingInfo.Text = "Booking Info";
            // 
            // tbllaypn_BookingInfo
            // 
            this.tbllaypn_BookingInfo.ColumnCount = 2;
            this.tbllaypn_BookingInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.7205F));
            this.tbllaypn_BookingInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.2795F));
            this.tbllaypn_BookingInfo.Controls.Add(this.lb_BookingDate, 0, 1);
            this.tbllaypn_BookingInfo.Controls.Add(this.lb_BookingCode, 0, 0);
            this.tbllaypn_BookingInfo.Controls.Add(this.lb_BookingDeposit, 0, 2);
            this.tbllaypn_BookingInfo.Controls.Add(this.tb_BookingCode, 1, 0);
            this.tbllaypn_BookingInfo.Controls.Add(this.tb_BookingDate, 1, 1);
            this.tbllaypn_BookingInfo.Controls.Add(this.tb_BookingDeposit, 1, 2);
            this.tbllaypn_BookingInfo.Location = new System.Drawing.Point(5, 20);
            this.tbllaypn_BookingInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbllaypn_BookingInfo.Name = "tbllaypn_BookingInfo";
            this.tbllaypn_BookingInfo.RowCount = 3;
            this.tbllaypn_BookingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_BookingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_BookingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_BookingInfo.Size = new System.Drawing.Size(387, 149);
            this.tbllaypn_BookingInfo.TabIndex = 0;
            // 
            // lb_BookingDate
            // 
            this.lb_BookingDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_BookingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_BookingDate.Location = new System.Drawing.Point(3, 59);
            this.lb_BookingDate.Name = "lb_BookingDate";
            this.lb_BookingDate.Size = new System.Drawing.Size(119, 28);
            this.lb_BookingDate.TabIndex = 0;
            this.lb_BookingDate.Text = "Booking Date";
            this.lb_BookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BookingCode
            // 
            this.lb_BookingCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_BookingCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_BookingCode.Location = new System.Drawing.Point(3, 10);
            this.lb_BookingCode.Name = "lb_BookingCode";
            this.lb_BookingCode.Size = new System.Drawing.Size(119, 28);
            this.lb_BookingCode.TabIndex = 0;
            this.lb_BookingCode.Text = "Booking Code";
            this.lb_BookingCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BookingDeposit
            // 
            this.lb_BookingDeposit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_BookingDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_BookingDeposit.Location = new System.Drawing.Point(3, 99);
            this.lb_BookingDeposit.Name = "lb_BookingDeposit";
            this.lb_BookingDeposit.Size = new System.Drawing.Size(143, 48);
            this.lb_BookingDeposit.TabIndex = 0;
            this.lb_BookingDeposit.Text = "Booking Deposit";
            this.lb_BookingDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_BookingCode
            // 
            this.tb_BookingCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_BookingCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_BookingCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BookingCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_BookingCode.Location = new System.Drawing.Point(176, 13);
            this.tb_BookingCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_BookingCode.Name = "tb_BookingCode";
            this.tb_BookingCode.Size = new System.Drawing.Size(208, 22);
            this.tb_BookingCode.TabIndex = 1;
            this.tb_BookingCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_BookingDate
            // 
            this.tb_BookingDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_BookingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_BookingDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BookingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_BookingDate.Location = new System.Drawing.Point(176, 63);
            this.tb_BookingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_BookingDate.Multiline = true;
            this.tb_BookingDate.Name = "tb_BookingDate";
            this.tb_BookingDate.Size = new System.Drawing.Size(208, 20);
            this.tb_BookingDate.TabIndex = 2;
            this.tb_BookingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_BookingDeposit
            // 
            this.tb_BookingDeposit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_BookingDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_BookingDeposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BookingDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_BookingDeposit.Location = new System.Drawing.Point(176, 112);
            this.tb_BookingDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_BookingDeposit.Name = "tb_BookingDeposit";
            this.tb_BookingDeposit.Size = new System.Drawing.Size(208, 22);
            this.tb_BookingDeposit.TabIndex = 3;
            this.tb_BookingDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbx_PayerInfo
            // 
            this.grbx_PayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbx_PayerInfo.Controls.Add(this.tbllaypn_PayerInfo);
            this.grbx_PayerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbx_PayerInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_PayerInfo.Location = new System.Drawing.Point(430, 2);
            this.grbx_PayerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_PayerInfo.Name = "grbx_PayerInfo";
            this.grbx_PayerInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_PayerInfo.Size = new System.Drawing.Size(408, 184);
            this.grbx_PayerInfo.TabIndex = 0;
            this.grbx_PayerInfo.TabStop = false;
            this.grbx_PayerInfo.Text = "Payer Info";
            // 
            // tbllaypn_PayerInfo
            // 
            this.tbllaypn_PayerInfo.ColumnCount = 2;
            this.tbllaypn_PayerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.61491F));
            this.tbllaypn_PayerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.38509F));
            this.tbllaypn_PayerInfo.Controls.Add(this.lb_Phone, 0, 1);
            this.tbllaypn_PayerInfo.Controls.Add(this.lb_FullName, 0, 0);
            this.tbllaypn_PayerInfo.Controls.Add(this.lb_Gmail, 0, 2);
            this.tbllaypn_PayerInfo.Controls.Add(this.tb_FullName, 1, 0);
            this.tbllaypn_PayerInfo.Controls.Add(this.tb_Phone, 1, 1);
            this.tbllaypn_PayerInfo.Controls.Add(this.tb_Gmail, 1, 2);
            this.tbllaypn_PayerInfo.Location = new System.Drawing.Point(5, 20);
            this.tbllaypn_PayerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbllaypn_PayerInfo.Name = "tbllaypn_PayerInfo";
            this.tbllaypn_PayerInfo.RowCount = 3;
            this.tbllaypn_PayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_PayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_PayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_PayerInfo.Size = new System.Drawing.Size(387, 149);
            this.tbllaypn_PayerInfo.TabIndex = 0;
            // 
            // lb_Phone
            // 
            this.lb_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Phone.Location = new System.Drawing.Point(3, 59);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(108, 28);
            this.lb_Phone.TabIndex = 0;
            this.lb_Phone.Text = "Phone";
            // 
            // lb_FullName
            // 
            this.lb_FullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_FullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_FullName.Location = new System.Drawing.Point(3, 10);
            this.lb_FullName.Name = "lb_FullName";
            this.lb_FullName.Size = new System.Drawing.Size(108, 28);
            this.lb_FullName.TabIndex = 0;
            this.lb_FullName.Text = "Full Name";
            // 
            // lb_Gmail
            // 
            this.lb_Gmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Gmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Gmail.Location = new System.Drawing.Point(3, 109);
            this.lb_Gmail.Name = "lb_Gmail";
            this.lb_Gmail.Size = new System.Drawing.Size(108, 28);
            this.lb_Gmail.TabIndex = 0;
            this.lb_Gmail.Text = "Gmail";
            // 
            // tb_FullName
            // 
            this.tb_FullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_FullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_FullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_FullName.Location = new System.Drawing.Point(164, 13);
            this.tb_FullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_FullName.Name = "tb_FullName";
            this.tb_FullName.Size = new System.Drawing.Size(220, 22);
            this.tb_FullName.TabIndex = 4;
            this.tb_FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Phone.Location = new System.Drawing.Point(164, 63);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Phone.Multiline = true;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(220, 20);
            this.tb_Phone.TabIndex = 5;
            this.tb_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Gmail
            // 
            this.tb_Gmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Gmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Gmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Gmail.Location = new System.Drawing.Point(164, 112);
            this.tb_Gmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Gmail.Name = "tb_Gmail";
            this.tb_Gmail.Size = new System.Drawing.Size(220, 22);
            this.tb_Gmail.TabIndex = 6;
            this.tb_Gmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_PaymentDate
            // 
            this.lb_PaymentDate.AutoSize = true;
            this.lb_PaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.lb_PaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_PaymentDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_PaymentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_PaymentDate.Location = new System.Drawing.Point(287, 0);
            this.lb_PaymentDate.Name = "lb_PaymentDate";
            this.lb_PaymentDate.Size = new System.Drawing.Size(136, 45);
            this.lb_PaymentDate.TabIndex = 0;
            this.lb_PaymentDate.Text = "Payment Date";
            this.lb_PaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lb_PaymentDate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_PaymentDate, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lb_CheckinDate, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lb_CreateDate, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lb_LastUpdateDate, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_CheckinDate, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_CreateDate, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_LastUpdateDate, 5, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 231);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(855, 70);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(145, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(145, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(3, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_PaymentDate
            // 
            this.tb_PaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_PaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_PaymentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_PaymentDate.Location = new System.Drawing.Point(287, 47);
            this.tb_PaymentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PaymentDate.Name = "tb_PaymentDate";
            this.tb_PaymentDate.Size = new System.Drawing.Size(136, 22);
            this.tb_PaymentDate.TabIndex = 0;
            this.tb_PaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_CheckinDate
            // 
            this.lb_CheckinDate.AutoSize = true;
            this.lb_CheckinDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.lb_CheckinDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CheckinDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_CheckinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CheckinDate.Location = new System.Drawing.Point(429, 0);
            this.lb_CheckinDate.Name = "lb_CheckinDate";
            this.lb_CheckinDate.Size = new System.Drawing.Size(136, 45);
            this.lb_CheckinDate.TabIndex = 0;
            this.lb_CheckinDate.Text = "Checkin Date";
            this.lb_CheckinDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CreateDate
            // 
            this.lb_CreateDate.AutoSize = true;
            this.lb_CreateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.lb_CreateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CreateDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_CreateDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CreateDate.Location = new System.Drawing.Point(571, 0);
            this.lb_CreateDate.Name = "lb_CreateDate";
            this.lb_CreateDate.Size = new System.Drawing.Size(136, 45);
            this.lb_CreateDate.TabIndex = 0;
            this.lb_CreateDate.Text = "Create Date";
            this.lb_CreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_LastUpdateDate
            // 
            this.lb_LastUpdateDate.AutoSize = true;
            this.lb_LastUpdateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.lb_LastUpdateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_LastUpdateDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_LastUpdateDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_LastUpdateDate.Location = new System.Drawing.Point(713, 0);
            this.lb_LastUpdateDate.Name = "lb_LastUpdateDate";
            this.lb_LastUpdateDate.Size = new System.Drawing.Size(139, 45);
            this.lb_LastUpdateDate.TabIndex = 0;
            this.lb_LastUpdateDate.Text = "Last Update Date";
            this.lb_LastUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_CheckinDate
            // 
            this.tb_CheckinDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_CheckinDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CheckinDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CheckinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CheckinDate.Location = new System.Drawing.Point(429, 47);
            this.tb_CheckinDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CheckinDate.Name = "tb_CheckinDate";
            this.tb_CheckinDate.Size = new System.Drawing.Size(136, 22);
            this.tb_CheckinDate.TabIndex = 0;
            this.tb_CheckinDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_CreateDate
            // 
            this.tb_CreateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_CreateDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CreateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CreateDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CreateDate.Location = new System.Drawing.Point(571, 47);
            this.tb_CreateDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CreateDate.Name = "tb_CreateDate";
            this.tb_CreateDate.Size = new System.Drawing.Size(136, 22);
            this.tb_CreateDate.TabIndex = 0;
            this.tb_CreateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_LastUpdateDate
            // 
            this.tb_LastUpdateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_LastUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_LastUpdateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_LastUpdateDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_LastUpdateDate.Location = new System.Drawing.Point(713, 47);
            this.tb_LastUpdateDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_LastUpdateDate.Name = "tb_LastUpdateDate";
            this.tb_LastUpdateDate.Size = new System.Drawing.Size(139, 22);
            this.tb_LastUpdateDate.TabIndex = 0;
            this.tb_LastUpdateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Total
            // 
            this.lb_Total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Total.Location = new System.Drawing.Point(3, 2);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(48, 21);
            this.lb_Total.TabIndex = 0;
            this.lb_Total.Text = "Total";
            // 
            // fllaypn_Total
            // 
            this.fllaypn_Total.Controls.Add(this.lb_Total);
            this.fllaypn_Total.Controls.Add(this.tb_Total);
            this.fllaypn_Total.Location = new System.Drawing.Point(658, 549);
            this.fllaypn_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fllaypn_Total.Name = "fllaypn_Total";
            this.fllaypn_Total.Size = new System.Drawing.Size(200, 28);
            this.fllaypn_Total.TabIndex = 0;
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Total.Location = new System.Drawing.Point(57, 2);
            this.tb_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(137, 22);
            this.tb_Total.TabIndex = 0;
            this.tb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(6, 305);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(850, 243);
            this.dgv.TabIndex = 0;
            // 
            // lb_InvoiceID
            // 
            this.lb_InvoiceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_InvoiceID.AutoSize = true;
            this.lb_InvoiceID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceID.Location = new System.Drawing.Point(712, 2);
            this.lb_InvoiceID.Name = "lb_InvoiceID";
            this.lb_InvoiceID.Size = new System.Drawing.Size(133, 15);
            this.lb_InvoiceID.TabIndex = 0;
            this.lb_InvoiceID.Text = "ID Invoice: ABCDXYZH";
            // 
            // tbllaypn_ControlButtons
            // 
            this.tbllaypn_ControlButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbllaypn_ControlButtons.ColumnCount = 4;
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_Export, 0, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_Cancel, 2, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_OK, 0, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_Reset, 1, 0);
            this.tbllaypn_ControlButtons.Location = new System.Drawing.Point(173, 614);
            this.tbllaypn_ControlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbllaypn_ControlButtons.Name = "tbllaypn_ControlButtons";
            this.tbllaypn_ControlButtons.RowCount = 1;
            this.tbllaypn_ControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllaypn_ControlButtons.Size = new System.Drawing.Size(518, 34);
            this.tbllaypn_ControlButtons.TabIndex = 0;
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Export.Location = new System.Drawing.Point(132, 2);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(123, 29);
            this.btn_Export.TabIndex = 0;
            this.btn_Export.Text = "Export to PDF";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.Location = new System.Drawing.Point(390, 2);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(124, 29);
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
            this.btn_OK.Location = new System.Drawing.Point(3, 1);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(122, 32);
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
            this.btn_Reset.Location = new System.Drawing.Point(260, 2);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(124, 29);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grbx_BookingInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbx_PayerInfo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 188);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Form_Detail_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(860, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbllaypn_ControlButtons);
            this.Controls.Add(this.lb_InvoiceID);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.fllaypn_Total);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.lb_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Detail_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Details_Invoice";
            this.grbx_BookingInfo.ResumeLayout(false);
            this.tbllaypn_BookingInfo.ResumeLayout(false);
            this.tbllaypn_BookingInfo.PerformLayout();
            this.grbx_PayerInfo.ResumeLayout(false);
            this.tbllaypn_PayerInfo.ResumeLayout(false);
            this.tbllaypn_PayerInfo.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.fllaypn_Total.ResumeLayout(false);
            this.fllaypn_Total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tbllaypn_ControlButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.GroupBox grbx_PayerInfo;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_PayerInfo;
        private System.Windows.Forms.TextBox tb_FullName;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_Gmail;
        private System.Windows.Forms.GroupBox grbx_BookingInfo;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_BookingInfo;
        private System.Windows.Forms.Label lb_BookingDate;
        private System.Windows.Forms.Label lb_BookingCode;
        private System.Windows.Forms.Label lb_BookingDeposit;
        private System.Windows.Forms.TextBox tb_BookingCode;
        private System.Windows.Forms.TextBox tb_BookingDate;
        private System.Windows.Forms.TextBox tb_BookingDeposit;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_FullName;
        private System.Windows.Forms.Label lb_Gmail;
        private System.Windows.Forms.Label lb_PaymentDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lb_CreateDate;
        private System.Windows.Forms.Label lb_CheckinDate;
        private System.Windows.Forms.TextBox tb_CreateDate;
        private System.Windows.Forms.TextBox tb_CheckinDate;
        private System.Windows.Forms.TextBox tb_PaymentDate;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Total;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lb_InvoiceID;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ControlButtons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_LastUpdateDate;
        private System.Windows.Forms.Label lb_LastUpdateDate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}