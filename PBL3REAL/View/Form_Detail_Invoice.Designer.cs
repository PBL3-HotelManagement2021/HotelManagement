
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Detail_Invoice));
            this.tbllaypn_InvoiceFromToInfo = new System.Windows.Forms.TableLayoutPanel();
            this.grbx_BookingInfo = new System.Windows.Forms.GroupBox();
            this.tbllaypn_BookingInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lb_BookingDate = new System.Windows.Forms.Label();
            this.lb_BookingCode = new System.Windows.Forms.Label();
            this.lb_BookingStatus = new System.Windows.Forms.Label();
            this.tb_BookingCode = new System.Windows.Forms.TextBox();
            this.tb_BookingDate = new System.Windows.Forms.TextBox();
            this.tb_BookingStatus = new System.Windows.Forms.TextBox();
            this.grbx_PayerInfo = new System.Windows.Forms.GroupBox();
            this.tbllaypn_PayerInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tb_ClientCode = new System.Windows.Forms.TextBox();
            this.lb_ClientCode = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_FullName = new System.Windows.Forms.Label();
            this.lb_Gmail = new System.Windows.Forms.Label();
            this.tb_FullName = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_Gmail = new System.Windows.Forms.TextBox();
            this.lb_InvoiceID = new System.Windows.Forms.Label();
            this.fllaypn_Total = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Total = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tbllaypn_BookingDateInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lb_PaymentDate = new System.Windows.Forms.Label();
            this.lb_CheckinDate = new System.Windows.Forms.Label();
            this.lb_CreateDate = new System.Windows.Forms.Label();
            this.lb_LastUpdateDate = new System.Windows.Forms.Label();
            this.tb_PaymentDate = new System.Windows.Forms.TextBox();
            this.tb_CheckinDate = new System.Windows.Forms.TextBox();
            this.tb_CreateDate = new System.Windows.Forms.TextBox();
            this.tb_LastUpdateDate = new System.Windows.Forms.TextBox();
            this.lb_Header = new System.Windows.Forms.Label();
            this.tbllaypn_ControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ExportToPDF = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_Usercode = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbllaypn_InvoiceFromToInfo.SuspendLayout();
            this.grbx_BookingInfo.SuspendLayout();
            this.tbllaypn_BookingInfo.SuspendLayout();
            this.grbx_PayerInfo.SuspendLayout();
            this.tbllaypn_PayerInfo.SuspendLayout();
            this.fllaypn_Total.SuspendLayout();
            this.tbllaypn_BookingDateInfo.SuspendLayout();
            this.tbllaypn_ControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tbllaypn_InvoiceFromToInfo
            // 
            this.tbllaypn_InvoiceFromToInfo.ColumnCount = 2;
            this.tbllaypn_InvoiceFromToInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_InvoiceFromToInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_InvoiceFromToInfo.Controls.Add(this.grbx_BookingInfo, 0, 0);
            this.tbllaypn_InvoiceFromToInfo.Controls.Add(this.grbx_PayerInfo, 1, 0);
            this.tbllaypn_InvoiceFromToInfo.Location = new System.Drawing.Point(5, 59);
            this.tbllaypn_InvoiceFromToInfo.Name = "tbllaypn_InvoiceFromToInfo";
            this.tbllaypn_InvoiceFromToInfo.RowCount = 1;
            this.tbllaypn_InvoiceFromToInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_InvoiceFromToInfo.Size = new System.Drawing.Size(977, 251);
            this.tbllaypn_InvoiceFromToInfo.TabIndex = 0;
            // 
            // grbx_BookingInfo
            // 
            this.grbx_BookingInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbx_BookingInfo.Controls.Add(this.tbllaypn_BookingInfo);
            this.grbx_BookingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbx_BookingInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_BookingInfo.Location = new System.Drawing.Point(3, 3);
            this.grbx_BookingInfo.Name = "grbx_BookingInfo";
            this.grbx_BookingInfo.Size = new System.Drawing.Size(465, 245);
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
            this.tbllaypn_BookingInfo.Controls.Add(this.lb_BookingStatus, 0, 2);
            this.tbllaypn_BookingInfo.Controls.Add(this.tb_BookingCode, 1, 0);
            this.tbllaypn_BookingInfo.Controls.Add(this.tb_BookingDate, 1, 1);
            this.tbllaypn_BookingInfo.Controls.Add(this.tb_BookingStatus, 1, 2);
            this.tbllaypn_BookingInfo.Location = new System.Drawing.Point(6, 27);
            this.tbllaypn_BookingInfo.Name = "tbllaypn_BookingInfo";
            this.tbllaypn_BookingInfo.RowCount = 3;
            this.tbllaypn_BookingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_BookingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_BookingInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_BookingInfo.Size = new System.Drawing.Size(442, 199);
            this.tbllaypn_BookingInfo.TabIndex = 0;
            // 
            // lb_BookingDate
            // 
            this.lb_BookingDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_BookingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_BookingDate.Location = new System.Drawing.Point(3, 80);
            this.lb_BookingDate.Name = "lb_BookingDate";
            this.lb_BookingDate.Size = new System.Drawing.Size(136, 37);
            this.lb_BookingDate.TabIndex = 0;
            this.lb_BookingDate.Text = "Booking Date";
            this.lb_BookingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BookingCode
            // 
            this.lb_BookingCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_BookingCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_BookingCode.Location = new System.Drawing.Point(3, 14);
            this.lb_BookingCode.Name = "lb_BookingCode";
            this.lb_BookingCode.Size = new System.Drawing.Size(136, 37);
            this.lb_BookingCode.TabIndex = 0;
            this.lb_BookingCode.Text = "Booking Code";
            this.lb_BookingCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BookingStatus
            // 
            this.lb_BookingStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_BookingStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_BookingStatus.Location = new System.Drawing.Point(3, 133);
            this.lb_BookingStatus.Name = "lb_BookingStatus";
            this.lb_BookingStatus.Size = new System.Drawing.Size(163, 64);
            this.lb_BookingStatus.TabIndex = 0;
            this.lb_BookingStatus.Text = "Booking Status";
            this.lb_BookingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_BookingCode
            // 
            this.tb_BookingCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_BookingCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_BookingCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BookingCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_BookingCode.Location = new System.Drawing.Point(200, 19);
            this.tb_BookingCode.Name = "tb_BookingCode";
            this.tb_BookingCode.Size = new System.Drawing.Size(238, 27);
            this.tb_BookingCode.TabIndex = 1;
            this.tb_BookingCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_BookingDate
            // 
            this.tb_BookingDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_BookingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_BookingDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BookingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_BookingDate.Location = new System.Drawing.Point(200, 85);
            this.tb_BookingDate.Multiline = true;
            this.tb_BookingDate.Name = "tb_BookingDate";
            this.tb_BookingDate.Size = new System.Drawing.Size(238, 27);
            this.tb_BookingDate.TabIndex = 2;
            this.tb_BookingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_BookingStatus
            // 
            this.tb_BookingStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_BookingStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_BookingStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BookingStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_BookingStatus.Location = new System.Drawing.Point(200, 152);
            this.tb_BookingStatus.Name = "tb_BookingStatus";
            this.tb_BookingStatus.Size = new System.Drawing.Size(238, 27);
            this.tb_BookingStatus.TabIndex = 3;
            this.tb_BookingStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbx_PayerInfo
            // 
            this.grbx_PayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbx_PayerInfo.Controls.Add(this.tbllaypn_PayerInfo);
            this.grbx_PayerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbx_PayerInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_PayerInfo.Location = new System.Drawing.Point(491, 3);
            this.grbx_PayerInfo.Name = "grbx_PayerInfo";
            this.grbx_PayerInfo.Size = new System.Drawing.Size(466, 245);
            this.grbx_PayerInfo.TabIndex = 0;
            this.grbx_PayerInfo.TabStop = false;
            this.grbx_PayerInfo.Text = "Payer Info";
            // 
            // tbllaypn_PayerInfo
            // 
            this.tbllaypn_PayerInfo.ColumnCount = 2;
            this.tbllaypn_PayerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.61491F));
            this.tbllaypn_PayerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.38509F));
            this.tbllaypn_PayerInfo.Controls.Add(this.tb_ClientCode, 1, 3);
            this.tbllaypn_PayerInfo.Controls.Add(this.lb_ClientCode, 0, 3);
            this.tbllaypn_PayerInfo.Controls.Add(this.lb_Phone, 0, 1);
            this.tbllaypn_PayerInfo.Controls.Add(this.lb_FullName, 0, 0);
            this.tbllaypn_PayerInfo.Controls.Add(this.lb_Gmail, 0, 2);
            this.tbllaypn_PayerInfo.Controls.Add(this.tb_FullName, 1, 0);
            this.tbllaypn_PayerInfo.Controls.Add(this.tb_Phone, 1, 1);
            this.tbllaypn_PayerInfo.Controls.Add(this.tb_Gmail, 1, 2);
            this.tbllaypn_PayerInfo.Location = new System.Drawing.Point(6, 27);
            this.tbllaypn_PayerInfo.Name = "tbllaypn_PayerInfo";
            this.tbllaypn_PayerInfo.RowCount = 4;
            this.tbllaypn_PayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_PayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_PayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_PayerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_PayerInfo.Size = new System.Drawing.Size(442, 199);
            this.tbllaypn_PayerInfo.TabIndex = 0;
            // 
            // tb_ClientCode
            // 
            this.tb_ClientCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ClientCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientCode.Location = new System.Drawing.Point(186, 159);
            this.tb_ClientCode.Name = "tb_ClientCode";
            this.tb_ClientCode.Size = new System.Drawing.Size(251, 27);
            this.tb_ClientCode.TabIndex = 7;
            this.tb_ClientCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_ClientCode
            // 
            this.lb_ClientCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientCode.Location = new System.Drawing.Point(3, 154);
            this.lb_ClientCode.Name = "lb_ClientCode";
            this.lb_ClientCode.Size = new System.Drawing.Size(123, 37);
            this.lb_ClientCode.TabIndex = 0;
            this.lb_ClientCode.Text = "Client Code";
            // 
            // lb_Phone
            // 
            this.lb_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Phone.Location = new System.Drawing.Point(3, 55);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(123, 37);
            this.lb_Phone.TabIndex = 0;
            this.lb_Phone.Text = "Phone";
            // 
            // lb_FullName
            // 
            this.lb_FullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_FullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_FullName.Location = new System.Drawing.Point(3, 6);
            this.lb_FullName.Name = "lb_FullName";
            this.lb_FullName.Size = new System.Drawing.Size(123, 37);
            this.lb_FullName.TabIndex = 0;
            this.lb_FullName.Text = "Full Name";
            // 
            // lb_Gmail
            // 
            this.lb_Gmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Gmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Gmail.Location = new System.Drawing.Point(3, 104);
            this.lb_Gmail.Name = "lb_Gmail";
            this.lb_Gmail.Size = new System.Drawing.Size(123, 37);
            this.lb_Gmail.TabIndex = 0;
            this.lb_Gmail.Text = "Gmail";
            // 
            // tb_FullName
            // 
            this.tb_FullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_FullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_FullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_FullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_FullName.Location = new System.Drawing.Point(186, 11);
            this.tb_FullName.Name = "tb_FullName";
            this.tb_FullName.Size = new System.Drawing.Size(251, 27);
            this.tb_FullName.TabIndex = 4;
            this.tb_FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Phone.Location = new System.Drawing.Point(186, 60);
            this.tb_Phone.Multiline = true;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(251, 27);
            this.tb_Phone.TabIndex = 5;
            this.tb_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Gmail
            // 
            this.tb_Gmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Gmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Gmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Gmail.Location = new System.Drawing.Point(186, 109);
            this.tb_Gmail.Name = "tb_Gmail";
            this.tb_Gmail.Size = new System.Drawing.Size(251, 27);
            this.tb_Gmail.TabIndex = 6;
            this.tb_Gmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_InvoiceID
            // 
            this.lb_InvoiceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_InvoiceID.AutoSize = true;
            this.lb_InvoiceID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceID.Location = new System.Drawing.Point(813, 1);
            this.lb_InvoiceID.Name = "lb_InvoiceID";
            this.lb_InvoiceID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_InvoiceID.Size = new System.Drawing.Size(167, 20);
            this.lb_InvoiceID.TabIndex = 0;
            this.lb_InvoiceID.Text = "Invoice ID: ABCDXYZH";
            this.lb_InvoiceID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fllaypn_Total
            // 
            this.fllaypn_Total.Controls.Add(this.lb_Total);
            this.fllaypn_Total.Controls.Add(this.tb_Total);
            this.fllaypn_Total.Enabled = false;
            this.fllaypn_Total.Location = new System.Drawing.Point(752, 741);
            this.fllaypn_Total.Name = "fllaypn_Total";
            this.fllaypn_Total.Size = new System.Drawing.Size(229, 37);
            this.fllaypn_Total.TabIndex = 0;
            // 
            // lb_Total
            // 
            this.lb_Total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Total.Location = new System.Drawing.Point(3, 2);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(59, 28);
            this.lb_Total.TabIndex = 0;
            this.lb_Total.Text = "Total";
            // 
            // tb_Total
            // 
            this.tb_Total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Total.Location = new System.Drawing.Point(68, 3);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(157, 27);
            this.tb_Total.TabIndex = 0;
            this.tb_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbllaypn_BookingDateInfo
            // 
            this.tbllaypn_BookingDateInfo.ColumnCount = 4;
            this.tbllaypn_BookingDateInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbllaypn_BookingDateInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbllaypn_BookingDateInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbllaypn_BookingDateInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbllaypn_BookingDateInfo.Controls.Add(this.lb_PaymentDate, 0, 0);
            this.tbllaypn_BookingDateInfo.Controls.Add(this.lb_CheckinDate, 1, 0);
            this.tbllaypn_BookingDateInfo.Controls.Add(this.lb_CreateDate, 2, 0);
            this.tbllaypn_BookingDateInfo.Controls.Add(this.lb_LastUpdateDate, 3, 0);
            this.tbllaypn_BookingDateInfo.Controls.Add(this.tb_PaymentDate, 0, 1);
            this.tbllaypn_BookingDateInfo.Controls.Add(this.tb_CheckinDate, 1, 1);
            this.tbllaypn_BookingDateInfo.Controls.Add(this.tb_CreateDate, 2, 1);
            this.tbllaypn_BookingDateInfo.Controls.Add(this.tb_LastUpdateDate, 3, 1);
            this.tbllaypn_BookingDateInfo.Location = new System.Drawing.Point(5, 317);
            this.tbllaypn_BookingDateInfo.Name = "tbllaypn_BookingDateInfo";
            this.tbllaypn_BookingDateInfo.RowCount = 3;
            this.tbllaypn_BookingDateInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbllaypn_BookingDateInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbllaypn_BookingDateInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbllaypn_BookingDateInfo.Size = new System.Drawing.Size(977, 93);
            this.tbllaypn_BookingDateInfo.TabIndex = 0;
            // 
            // lb_PaymentDate
            // 
            this.lb_PaymentDate.AutoSize = true;
            this.lb_PaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.lb_PaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_PaymentDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_PaymentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_PaymentDate.Location = new System.Drawing.Point(3, 0);
            this.lb_PaymentDate.Name = "lb_PaymentDate";
            this.lb_PaymentDate.Size = new System.Drawing.Size(238, 60);
            this.lb_PaymentDate.TabIndex = 0;
            this.lb_PaymentDate.Text = "Payment Date";
            this.lb_PaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CheckinDate
            // 
            this.lb_CheckinDate.AutoSize = true;
            this.lb_CheckinDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.lb_CheckinDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_CheckinDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_CheckinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_CheckinDate.Location = new System.Drawing.Point(247, 0);
            this.lb_CheckinDate.Name = "lb_CheckinDate";
            this.lb_CheckinDate.Size = new System.Drawing.Size(238, 60);
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
            this.lb_CreateDate.Location = new System.Drawing.Point(491, 0);
            this.lb_CreateDate.Name = "lb_CreateDate";
            this.lb_CreateDate.Size = new System.Drawing.Size(238, 60);
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
            this.lb_LastUpdateDate.Location = new System.Drawing.Point(735, 0);
            this.lb_LastUpdateDate.Name = "lb_LastUpdateDate";
            this.lb_LastUpdateDate.Size = new System.Drawing.Size(239, 60);
            this.lb_LastUpdateDate.TabIndex = 0;
            this.lb_LastUpdateDate.Text = "Last Update Date";
            this.lb_LastUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_PaymentDate
            // 
            this.tb_PaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_PaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PaymentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_PaymentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_PaymentDate.Location = new System.Drawing.Point(3, 63);
            this.tb_PaymentDate.Name = "tb_PaymentDate";
            this.tb_PaymentDate.Size = new System.Drawing.Size(238, 27);
            this.tb_PaymentDate.TabIndex = 0;
            this.tb_PaymentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_CheckinDate
            // 
            this.tb_CheckinDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_CheckinDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CheckinDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CheckinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CheckinDate.Location = new System.Drawing.Point(247, 63);
            this.tb_CheckinDate.Name = "tb_CheckinDate";
            this.tb_CheckinDate.Size = new System.Drawing.Size(238, 27);
            this.tb_CheckinDate.TabIndex = 0;
            this.tb_CheckinDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_CreateDate
            // 
            this.tb_CreateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_CreateDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CreateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_CreateDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_CreateDate.Location = new System.Drawing.Point(491, 63);
            this.tb_CreateDate.Name = "tb_CreateDate";
            this.tb_CreateDate.Size = new System.Drawing.Size(238, 27);
            this.tb_CreateDate.TabIndex = 0;
            this.tb_CreateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_LastUpdateDate
            // 
            this.tb_LastUpdateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.tb_LastUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_LastUpdateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_LastUpdateDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_LastUpdateDate.Location = new System.Drawing.Point(735, 63);
            this.tb_LastUpdateDate.Name = "tb_LastUpdateDate";
            this.tb_LastUpdateDate.Size = new System.Drawing.Size(239, 27);
            this.tb_LastUpdateDate.TabIndex = 0;
            this.tb_LastUpdateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Header
            // 
            this.lb_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(427, 15);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(140, 41);
            this.lb_Header.TabIndex = 6;
            this.lb_Header.Text = "INVOICE";
            this.lb_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbllaypn_ControlButtons
            // 
            this.tbllaypn_ControlButtons.ColumnCount = 3;
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.20623F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.47548F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.17484F));
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_ExportToPDF, 1, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_OK, 0, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_Cancel, 2, 0);
            this.tbllaypn_ControlButtons.Location = new System.Drawing.Point(316, 828);
            this.tbllaypn_ControlButtons.Name = "tbllaypn_ControlButtons";
            this.tbllaypn_ControlButtons.RowCount = 1;
            this.tbllaypn_ControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllaypn_ControlButtons.Size = new System.Drawing.Size(360, 49);
            this.tbllaypn_ControlButtons.TabIndex = 0;
            // 
            // btn_ExportToPDF
            // 
            this.btn_ExportToPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ExportToPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_ExportToPDF.FlatAppearance.BorderSize = 0;
            this.btn_ExportToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportToPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportToPDF.Location = new System.Drawing.Point(106, 4);
            this.btn_ExportToPDF.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ExportToPDF.Name = "btn_ExportToPDF";
            this.btn_ExportToPDF.Size = new System.Drawing.Size(142, 40);
            this.btn_ExportToPDF.TabIndex = 0;
            this.btn_ExportToPDF.Text = "Export to PDF";
            this.btn_ExportToPDF.UseVisualStyleBackColor = false;
            this.btn_ExportToPDF.Click += new System.EventHandler(this.btn_ExportToPDF_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OK.Location = new System.Drawing.Point(4, 4);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(91, 40);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.Location = new System.Drawing.Point(262, 4);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 40);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lb_Usercode
            // 
            this.lb_Usercode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Usercode.AutoSize = true;
            this.lb_Usercode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Usercode.Location = new System.Drawing.Point(-3, 1);
            this.lb_Usercode.Name = "lb_Usercode";
            this.lb_Usercode.Size = new System.Drawing.Size(84, 20);
            this.lb_Usercode.TabIndex = 0;
            this.lb_Usercode.Text = "User Code:";
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(8, 416);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(972, 324);
            this.dgv.TabIndex = 0;
            // 
            // Form_Detail_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(983, 879);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lb_Usercode);
            this.Controls.Add(this.tbllaypn_ControlButtons);
            this.Controls.Add(this.tbllaypn_InvoiceFromToInfo);
            this.Controls.Add(this.lb_InvoiceID);
            this.Controls.Add(this.fllaypn_Total);
            this.Controls.Add(this.tbllaypn_BookingDateInfo);
            this.Controls.Add(this.lb_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Detail_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Details_Invoice";
            this.tbllaypn_InvoiceFromToInfo.ResumeLayout(false);
            this.grbx_BookingInfo.ResumeLayout(false);
            this.tbllaypn_BookingInfo.ResumeLayout(false);
            this.tbllaypn_BookingInfo.PerformLayout();
            this.grbx_PayerInfo.ResumeLayout(false);
            this.tbllaypn_PayerInfo.ResumeLayout(false);
            this.tbllaypn_PayerInfo.PerformLayout();
            this.fllaypn_Total.ResumeLayout(false);
            this.fllaypn_Total.PerformLayout();
            this.tbllaypn_BookingDateInfo.ResumeLayout(false);
            this.tbllaypn_BookingDateInfo.PerformLayout();
            this.tbllaypn_ControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbllaypn_InvoiceFromToInfo;
        private System.Windows.Forms.GroupBox grbx_BookingInfo;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_BookingInfo;
        private System.Windows.Forms.Label lb_BookingDate;
        private System.Windows.Forms.Label lb_BookingCode;
        private System.Windows.Forms.Label lb_BookingStatus;
        private System.Windows.Forms.TextBox tb_BookingCode;
        private System.Windows.Forms.TextBox tb_BookingDate;
        private System.Windows.Forms.TextBox tb_BookingStatus;
        private System.Windows.Forms.GroupBox grbx_PayerInfo;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_PayerInfo;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_FullName;
        private System.Windows.Forms.Label lb_Gmail;
        private System.Windows.Forms.TextBox tb_FullName;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_Gmail;
        private System.Windows.Forms.Label lb_InvoiceID;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Total;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_BookingDateInfo;
        private System.Windows.Forms.Label lb_PaymentDate;
        private System.Windows.Forms.TextBox tb_PaymentDate;
        private System.Windows.Forms.Label lb_CheckinDate;
        private System.Windows.Forms.Label lb_CreateDate;
        private System.Windows.Forms.Label lb_LastUpdateDate;
        private System.Windows.Forms.TextBox tb_CheckinDate;
        private System.Windows.Forms.TextBox tb_CreateDate;
        private System.Windows.Forms.TextBox tb_LastUpdateDate;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ControlButtons;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_ExportToPDF;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_Usercode;
        private System.Windows.Forms.TextBox tb_ClientCode;
        private System.Windows.Forms.Label lb_ClientCode;
        private System.Windows.Forms.DataGridView dgv;
    }
}