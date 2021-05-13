
namespace PBL3REAL.View
{
    partial class Form_Booking
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
            this.lb_Header = new System.Windows.Forms.Label();
            this.grbx_ClientInfo = new System.Windows.Forms.GroupBox();
            this.tbllaypn_ClientInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tb_ClientContact = new System.Windows.Forms.TextBox();
            this.tb_ClientAddress = new System.Windows.Forms.TextBox();
            this.tb_ClientName = new System.Windows.Forms.TextBox();
            this.lb_ClientName = new System.Windows.Forms.Label();
            this.lb_ClientAddress = new System.Windows.Forms.Label();
            this.lb_ClientContact = new System.Windows.Forms.Label();
            this.grbx_PeriodTime = new System.Windows.Forms.GroupBox();
            this.picbx_Enter1 = new System.Windows.Forms.PictureBox();
            this.tbllaypn_RoomList = new System.Windows.Forms.TableLayoutPanel();
            this.picbx_Add = new System.Windows.Forms.PictureBox();
            this.picbx_Enter2 = new System.Windows.Forms.PictureBox();
            this.lb_Room = new System.Windows.Forms.Label();
            this.lb_RoomType = new System.Windows.Forms.Label();
            this.cbb_RoomType = new System.Windows.Forms.ComboBox();
            this.cbb_Room = new System.Windows.Forms.ComboBox();
            this.tbllaypn_FromTo = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.lb_To = new System.Windows.Forms.Label();
            this.lb_From = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbllaypn_ControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.picbx_Delete = new System.Windows.Forms.PictureBox();
            this.grbx_ClientInfo.SuspendLayout();
            this.tbllaypn_ClientInfo.SuspendLayout();
            this.grbx_PeriodTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Enter1)).BeginInit();
            this.tbllaypn_RoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Enter2)).BeginInit();
            this.tbllaypn_FromTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tbllaypn_ControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Header
            // 
            this.lb_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(382, 9);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(171, 45);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "BOOKING";
            // 
            // grbx_ClientInfo
            // 
            this.grbx_ClientInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbx_ClientInfo.Controls.Add(this.tbllaypn_ClientInfo);
            this.grbx_ClientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbx_ClientInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_ClientInfo.Location = new System.Drawing.Point(12, 60);
            this.grbx_ClientInfo.Name = "grbx_ClientInfo";
            this.grbx_ClientInfo.Size = new System.Drawing.Size(399, 262);
            this.grbx_ClientInfo.TabIndex = 0;
            this.grbx_ClientInfo.TabStop = false;
            this.grbx_ClientInfo.Text = "Thông tin khách hàng";
            // 
            // tbllaypn_ClientInfo
            // 
            this.tbllaypn_ClientInfo.ColumnCount = 2;
            this.tbllaypn_ClientInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.77003F));
            this.tbllaypn_ClientInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.22997F));
            this.tbllaypn_ClientInfo.Controls.Add(this.tb_ClientContact, 1, 2);
            this.tbllaypn_ClientInfo.Controls.Add(this.tb_ClientAddress, 1, 1);
            this.tbllaypn_ClientInfo.Controls.Add(this.tb_ClientName, 1, 0);
            this.tbllaypn_ClientInfo.Controls.Add(this.lb_ClientName, 0, 0);
            this.tbllaypn_ClientInfo.Controls.Add(this.lb_ClientAddress, 0, 1);
            this.tbllaypn_ClientInfo.Controls.Add(this.lb_ClientContact, 0, 2);
            this.tbllaypn_ClientInfo.Location = new System.Drawing.Point(6, 33);
            this.tbllaypn_ClientInfo.Name = "tbllaypn_ClientInfo";
            this.tbllaypn_ClientInfo.RowCount = 3;
            this.tbllaypn_ClientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.41072F));
            this.tbllaypn_ClientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.51786F));
            this.tbllaypn_ClientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.07143F));
            this.tbllaypn_ClientInfo.Size = new System.Drawing.Size(387, 224);
            this.tbllaypn_ClientInfo.TabIndex = 0;
            // 
            // tb_ClientContact
            // 
            this.tb_ClientContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ClientContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientContact.Location = new System.Drawing.Point(184, 192);
            this.tb_ClientContact.Name = "tb_ClientContact";
            this.tb_ClientContact.Size = new System.Drawing.Size(200, 27);
            this.tb_ClientContact.TabIndex = 3;
            this.tb_ClientContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ClientAddress
            // 
            this.tb_ClientAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ClientAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientAddress.Location = new System.Drawing.Point(184, 43);
            this.tb_ClientAddress.Multiline = true;
            this.tb_ClientAddress.Name = "tb_ClientAddress";
            this.tb_ClientAddress.Size = new System.Drawing.Size(200, 140);
            this.tb_ClientAddress.TabIndex = 2;
            // 
            // tb_ClientName
            // 
            this.tb_ClientName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ClientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientName.Location = new System.Drawing.Point(184, 6);
            this.tb_ClientName.Name = "tb_ClientName";
            this.tb_ClientName.Size = new System.Drawing.Size(200, 27);
            this.tb_ClientName.TabIndex = 1;
            this.tb_ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_ClientName
            // 
            this.lb_ClientName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientName.AutoSize = true;
            this.lb_ClientName.BackColor = System.Drawing.Color.Transparent;
            this.lb_ClientName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientName.Location = new System.Drawing.Point(3, 4);
            this.lb_ClientName.Name = "lb_ClientName";
            this.lb_ClientName.Size = new System.Drawing.Size(173, 31);
            this.lb_ClientName.TabIndex = 1;
            this.lb_ClientName.Text = "Tên khách hàng";
            // 
            // lb_ClientAddress
            // 
            this.lb_ClientAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientAddress.AutoSize = true;
            this.lb_ClientAddress.BackColor = System.Drawing.Color.Transparent;
            this.lb_ClientAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientAddress.Location = new System.Drawing.Point(3, 97);
            this.lb_ClientAddress.Name = "lb_ClientAddress";
            this.lb_ClientAddress.Size = new System.Drawing.Size(84, 31);
            this.lb_ClientAddress.TabIndex = 0;
            this.lb_ClientAddress.Text = "Địa chỉ";
            // 
            // lb_ClientContact
            // 
            this.lb_ClientContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientContact.AutoSize = true;
            this.lb_ClientContact.BackColor = System.Drawing.Color.Transparent;
            this.lb_ClientContact.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientContact.Location = new System.Drawing.Point(3, 190);
            this.lb_ClientContact.Name = "lb_ClientContact";
            this.lb_ClientContact.Size = new System.Drawing.Size(87, 31);
            this.lb_ClientContact.TabIndex = 0;
            this.lb_ClientContact.Text = "Liên hệ";
            // 
            // grbx_PeriodTime
            // 
            this.grbx_PeriodTime.BackColor = System.Drawing.Color.Transparent;
            this.grbx_PeriodTime.Controls.Add(this.picbx_Enter1);
            this.grbx_PeriodTime.Controls.Add(this.tbllaypn_RoomList);
            this.grbx_PeriodTime.Controls.Add(this.tbllaypn_FromTo);
            this.grbx_PeriodTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbx_PeriodTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_PeriodTime.Location = new System.Drawing.Point(417, 60);
            this.grbx_PeriodTime.Name = "grbx_PeriodTime";
            this.grbx_PeriodTime.Size = new System.Drawing.Size(538, 262);
            this.grbx_PeriodTime.TabIndex = 0;
            this.grbx_PeriodTime.TabStop = false;
            this.grbx_PeriodTime.Text = "Thông tin đặt phòng";
            // 
            // picbx_Enter1
            // 
            this.picbx_Enter1.Image = global::PBL3REAL.Properties.Resources.scroll_down_fluent_color_48px;
            this.picbx_Enter1.Location = new System.Drawing.Point(486, 76);
            this.picbx_Enter1.Name = "picbx_Enter1";
            this.picbx_Enter1.Size = new System.Drawing.Size(48, 45);
            this.picbx_Enter1.TabIndex = 2;
            this.picbx_Enter1.TabStop = false;
            // 
            // tbllaypn_RoomList
            // 
            this.tbllaypn_RoomList.ColumnCount = 3;
            this.tbllaypn_RoomList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09483F));
            this.tbllaypn_RoomList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.90517F));
            this.tbllaypn_RoomList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tbllaypn_RoomList.Controls.Add(this.picbx_Add, 2, 1);
            this.tbllaypn_RoomList.Controls.Add(this.picbx_Enter2, 2, 0);
            this.tbllaypn_RoomList.Controls.Add(this.lb_Room, 0, 1);
            this.tbllaypn_RoomList.Controls.Add(this.lb_RoomType, 0, 0);
            this.tbllaypn_RoomList.Controls.Add(this.cbb_RoomType, 1, 0);
            this.tbllaypn_RoomList.Controls.Add(this.cbb_Room, 1, 1);
            this.tbllaypn_RoomList.Location = new System.Drawing.Point(7, 154);
            this.tbllaypn_RoomList.Name = "tbllaypn_RoomList";
            this.tbllaypn_RoomList.RowCount = 2;
            this.tbllaypn_RoomList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_RoomList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_RoomList.Size = new System.Drawing.Size(528, 103);
            this.tbllaypn_RoomList.TabIndex = 0;
            // 
            // picbx_Add
            // 
            this.picbx_Add.Image = global::PBL3REAL.Properties.Resources.add_fluent_color_48px1;
            this.picbx_Add.Location = new System.Drawing.Point(477, 54);
            this.picbx_Add.Name = "picbx_Add";
            this.picbx_Add.Size = new System.Drawing.Size(47, 45);
            this.picbx_Add.TabIndex = 2;
            this.picbx_Add.TabStop = false;
            // 
            // picbx_Enter2
            // 
            this.picbx_Enter2.Image = global::PBL3REAL.Properties.Resources.scroll_down_fluent_color_48px;
            this.picbx_Enter2.Location = new System.Drawing.Point(477, 3);
            this.picbx_Enter2.Name = "picbx_Enter2";
            this.picbx_Enter2.Size = new System.Drawing.Size(47, 45);
            this.picbx_Enter2.TabIndex = 1;
            this.picbx_Enter2.TabStop = false;
            // 
            // lb_Room
            // 
            this.lb_Room.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Room.AutoSize = true;
            this.lb_Room.BackColor = System.Drawing.Color.Transparent;
            this.lb_Room.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Room.Location = new System.Drawing.Point(3, 61);
            this.lb_Room.Name = "lb_Room";
            this.lb_Room.Size = new System.Drawing.Size(80, 31);
            this.lb_Room.TabIndex = 0;
            this.lb_Room.Text = "Phòng";
            // 
            // lb_RoomType
            // 
            this.lb_RoomType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_RoomType.AutoSize = true;
            this.lb_RoomType.BackColor = System.Drawing.Color.Transparent;
            this.lb_RoomType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_RoomType.Location = new System.Drawing.Point(3, 10);
            this.lb_RoomType.Name = "lb_RoomType";
            this.lb_RoomType.Size = new System.Drawing.Size(129, 31);
            this.lb_RoomType.TabIndex = 0;
            this.lb_RoomType.Text = "Loại phòng";
            // 
            // cbb_RoomType
            // 
            this.cbb_RoomType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_RoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_RoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_RoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_RoomType.FormattingEnabled = true;
            this.cbb_RoomType.Location = new System.Drawing.Point(141, 7);
            this.cbb_RoomType.MaxDropDownItems = 10;
            this.cbb_RoomType.Name = "cbb_RoomType";
            this.cbb_RoomType.Size = new System.Drawing.Size(330, 36);
            this.cbb_RoomType.TabIndex = 6;
            // 
            // cbb_Room
            // 
            this.cbb_Room.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_Room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_Room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Room.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_Room.FormattingEnabled = true;
            this.cbb_Room.Location = new System.Drawing.Point(141, 59);
            this.cbb_Room.MaxDropDownItems = 10;
            this.cbb_Room.Name = "cbb_Room";
            this.cbb_Room.Size = new System.Drawing.Size(330, 36);
            this.cbb_Room.TabIndex = 7;
            // 
            // tbllaypn_FromTo
            // 
            this.tbllaypn_FromTo.ColumnCount = 2;
            this.tbllaypn_FromTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09483F));
            this.tbllaypn_FromTo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.90517F));
            this.tbllaypn_FromTo.Controls.Add(this.dtp_To, 1, 1);
            this.tbllaypn_FromTo.Controls.Add(this.dtp_From, 1, 0);
            this.tbllaypn_FromTo.Controls.Add(this.lb_To, 0, 1);
            this.tbllaypn_FromTo.Controls.Add(this.lb_From, 0, 0);
            this.tbllaypn_FromTo.Location = new System.Drawing.Point(7, 33);
            this.tbllaypn_FromTo.Name = "tbllaypn_FromTo";
            this.tbllaypn_FromTo.RowCount = 2;
            this.tbllaypn_FromTo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_FromTo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_FromTo.Size = new System.Drawing.Size(477, 115);
            this.tbllaypn_FromTo.TabIndex = 0;
            // 
            // dtp_To
            // 
            this.dtp_To.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_To.Location = new System.Drawing.Point(141, 69);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(331, 34);
            this.dtp_To.TabIndex = 5;
            // 
            // dtp_From
            // 
            this.dtp_From.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_From.Location = new System.Drawing.Point(141, 11);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(331, 34);
            this.dtp_From.TabIndex = 4;
            // 
            // lb_To
            // 
            this.lb_To.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_To.AutoSize = true;
            this.lb_To.BackColor = System.Drawing.Color.Transparent;
            this.lb_To.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_To.Location = new System.Drawing.Point(3, 70);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(111, 31);
            this.lb_To.TabIndex = 0;
            this.lb_To.Text = "Đến ngày";
            // 
            // lb_From
            // 
            this.lb_From.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_From.AutoSize = true;
            this.lb_From.BackColor = System.Drawing.Color.Transparent;
            this.lb_From.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_From.Location = new System.Drawing.Point(3, 13);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(96, 31);
            this.lb_From.TabIndex = 0;
            this.lb_From.Text = "Từ ngày";
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
            this.dgv.Location = new System.Drawing.Point(21, 328);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(875, 219);
            this.dgv.TabIndex = 0;
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
            this.tbllaypn_ControlButtons.Location = new System.Drawing.Point(343, 582);
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
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
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
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
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
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // picbx_Delete
            // 
            this.picbx_Delete.Image = global::PBL3REAL.Properties.Resources.minus_fluent_color_48px;
            this.picbx_Delete.Location = new System.Drawing.Point(902, 328);
            this.picbx_Delete.Name = "picbx_Delete";
            this.picbx_Delete.Size = new System.Drawing.Size(47, 45);
            this.picbx_Delete.TabIndex = 3;
            this.picbx_Delete.TabStop = false;
            // 
            // Form_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(959, 628);
            this.Controls.Add(this.picbx_Delete);
            this.Controls.Add(this.tbllaypn_ControlButtons);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.grbx_PeriodTime);
            this.Controls.Add(this.grbx_ClientInfo);
            this.Controls.Add(this.lb_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.grbx_ClientInfo.ResumeLayout(false);
            this.tbllaypn_ClientInfo.ResumeLayout(false);
            this.tbllaypn_ClientInfo.PerformLayout();
            this.grbx_PeriodTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Enter1)).EndInit();
            this.tbllaypn_RoomList.ResumeLayout(false);
            this.tbllaypn_RoomList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Enter2)).EndInit();
            this.tbllaypn_FromTo.ResumeLayout(false);
            this.tbllaypn_FromTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tbllaypn_ControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.GroupBox grbx_ClientInfo;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ClientInfo;
        private System.Windows.Forms.Label lb_ClientName;
        private System.Windows.Forms.Label lb_ClientAddress;
        private System.Windows.Forms.Label lb_ClientContact;
        private System.Windows.Forms.TextBox tb_ClientName;
        private System.Windows.Forms.TextBox tb_ClientContact;
        private System.Windows.Forms.TextBox tb_ClientAddress;
        private System.Windows.Forms.GroupBox grbx_PeriodTime;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_FromTo;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_RoomList;
        private System.Windows.Forms.Label lb_Room;
        private System.Windows.Forms.Label lb_RoomType;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.ComboBox cbb_RoomType;
        private System.Windows.Forms.ComboBox cbb_Room;
        private System.Windows.Forms.PictureBox picbx_Enter1;
        private System.Windows.Forms.PictureBox picbx_Add;
        private System.Windows.Forms.PictureBox picbx_Enter2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ControlButtons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.PictureBox picbx_Delete;
    }
}