
namespace PBL3REAL.View
{
    partial class Form_Accountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Accountant));
            this.tabControl_Accountant = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.btn_Home = new System.Windows.Forms.Button();
            this.tabPage_Invoice = new System.Windows.Forms.TabPage();
            this.dgv_Invoice = new System.Windows.Forms.DataGridView();
            this.fllaypn_InvoiceButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_InvoiceView = new System.Windows.Forms.Button();
            this.btn_InvoiceDelete = new System.Windows.Forms.Button();
            this.tbllaypn_Invoice = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_InvoiceTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_InvoiceFrom = new System.Windows.Forms.DateTimePicker();
            this.lb_InvoiceTo = new System.Windows.Forms.Label();
            this.lb_InvoiceFrom = new System.Windows.Forms.Label();
            this.picbx_InvoiceSort = new System.Windows.Forms.PictureBox();
            this.cbb_InvoiceSort = new System.Windows.Forms.ComboBox();
            this.lb_InvoiceSort = new System.Windows.Forms.Label();
            this.lb_InvoiceSearch = new System.Windows.Forms.Label();
            this.tb_InvoiceSearch = new System.Windows.Forms.TextBox();
            this.picbx_InvoiceSearch = new System.Windows.Forms.PictureBox();
            this.fllaypn_InvoiceSwitchPage = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_InvoicePrevPage = new System.Windows.Forms.Button();
            this.tb_InvoicePageNumber = new System.Windows.Forms.TextBox();
            this.btn_InvoiceNextPage = new System.Windows.Forms.Button();
            this.picbx_InvoiceRefresh = new System.Windows.Forms.PictureBox();
            this.tabPage_StatAnalyze = new System.Windows.Forms.TabPage();
            this.grbx_AnalyzeOption = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkbx_PredictOption = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkbx_AnalyzeOption = new System.Windows.Forms.CheckBox();
            this.grbx_StatisticOption = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_ChartType = new System.Windows.Forms.ComboBox();
            this.cbb_DataSort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbx_StatAnalyze = new System.Windows.Forms.GroupBox();
            this.tbllaypn_ControlBar = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tbllaypn_DataOption = new System.Windows.Forms.TableLayoutPanel();
            this.tbllaypn_ActionOption = new System.Windows.Forms.TableLayoutPanel();
            this.chkbx_Analyze = new System.Windows.Forms.CheckBox();
            this.chkbx_Statistic = new System.Windows.Forms.CheckBox();
            this.lb_DataType = new System.Windows.Forms.Label();
            this.lb_PeriodTime = new System.Windows.Forms.Label();
            this.lb_From = new System.Windows.Forms.Label();
            this.lb_To = new System.Windows.Forms.Label();
            this.lb_ActionOption = new System.Windows.Forms.Label();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.cbb_DataType = new System.Windows.Forms.ComboBox();
            this.cbb_PeriodTime = new System.Windows.Forms.ComboBox();
            this.tabControl_Accountant.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.tabPage_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).BeginInit();
            this.fllaypn_InvoiceButtons.SuspendLayout();
            this.tbllaypn_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSearch)).BeginInit();
            this.fllaypn_InvoiceSwitchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceRefresh)).BeginInit();
            this.tabPage_StatAnalyze.SuspendLayout();
            this.grbx_AnalyzeOption.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbx_StatisticOption.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grbx_StatAnalyze.SuspendLayout();
            this.tbllaypn_ControlBar.SuspendLayout();
            this.tbllaypn_DataOption.SuspendLayout();
            this.tbllaypn_ActionOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Accountant
            // 
            this.tabControl_Accountant.Controls.Add(this.tabPage_General);
            this.tabControl_Accountant.Controls.Add(this.tabPage_Invoice);
            this.tabControl_Accountant.Controls.Add(this.tabPage_StatAnalyze);
            this.tabControl_Accountant.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl_Accountant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl_Accountant.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Accountant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Accountant.Name = "tabControl_Accountant";
            this.tabControl_Accountant.SelectedIndex = 0;
            this.tabControl_Accountant.Size = new System.Drawing.Size(1004, 524);
            this.tabControl_Accountant.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(this.btn_Home);
            this.tabPage_General.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_General.Location = new System.Drawing.Point(4, 30);
            this.tabPage_General.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_General.Size = new System.Drawing.Size(996, 490);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "Chung";
            this.tabPage_General.UseVisualStyleBackColor = true;
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Image = global::PBL3REAL.Properties.Resources.home_page_fluent_color_96px;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Home.Location = new System.Drawing.Point(340, 178);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(170, 137);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Return Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // tabPage_Invoice
            // 
            this.tabPage_Invoice.Controls.Add(this.dgv_Invoice);
            this.tabPage_Invoice.Controls.Add(this.fllaypn_InvoiceButtons);
            this.tabPage_Invoice.Controls.Add(this.tbllaypn_Invoice);
            this.tabPage_Invoice.Controls.Add(this.fllaypn_InvoiceSwitchPage);
            this.tabPage_Invoice.Controls.Add(this.picbx_InvoiceRefresh);
            this.tabPage_Invoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_Invoice.Location = new System.Drawing.Point(4, 30);
            this.tabPage_Invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Invoice.Name = "tabPage_Invoice";
            this.tabPage_Invoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Invoice.Size = new System.Drawing.Size(996, 490);
            this.tabPage_Invoice.TabIndex = 1;
            this.tabPage_Invoice.Text = "Quản lí hóa đơn";
            this.tabPage_Invoice.UseVisualStyleBackColor = true;
            // 
            // dgv_Invoice
            // 
            this.dgv_Invoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Invoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Invoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Invoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoice.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Invoice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv_Invoice.Location = new System.Drawing.Point(0, 226);
            this.dgv_Invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Invoice.Name = "dgv_Invoice";
            this.dgv_Invoice.ReadOnly = true;
            this.dgv_Invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Invoice.RowHeadersVisible = false;
            this.dgv_Invoice.RowHeadersWidth = 51;
            this.dgv_Invoice.RowTemplate.Height = 29;
            this.dgv_Invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Invoice.Size = new System.Drawing.Size(997, 268);
            this.dgv_Invoice.TabIndex = 0;
            // 
            // fllaypn_InvoiceButtons
            // 
            this.fllaypn_InvoiceButtons.Controls.Add(this.btn_InvoiceView);
            this.fllaypn_InvoiceButtons.Controls.Add(this.btn_InvoiceDelete);
            this.fllaypn_InvoiceButtons.Location = new System.Drawing.Point(609, 14);
            this.fllaypn_InvoiceButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fllaypn_InvoiceButtons.Name = "fllaypn_InvoiceButtons";
            this.fllaypn_InvoiceButtons.Size = new System.Drawing.Size(370, 147);
            this.fllaypn_InvoiceButtons.TabIndex = 0;
            // 
            // btn_InvoiceView
            // 
            this.btn_InvoiceView.FlatAppearance.BorderSize = 0;
            this.btn_InvoiceView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvoiceView.Image = global::PBL3REAL.Properties.Resources.show_property_96px;
            this.btn_InvoiceView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InvoiceView.Location = new System.Drawing.Point(3, 2);
            this.btn_InvoiceView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InvoiceView.Name = "btn_InvoiceView";
            this.btn_InvoiceView.Size = new System.Drawing.Size(170, 144);
            this.btn_InvoiceView.TabIndex = 0;
            this.btn_InvoiceView.Text = "Xem thông tin đơn đã chọn";
            this.btn_InvoiceView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_InvoiceView.UseVisualStyleBackColor = true;
            this.btn_InvoiceView.Click += new System.EventHandler(this.btn_InvoiceView_Click);
            // 
            // btn_InvoiceDelete
            // 
            this.btn_InvoiceDelete.FlatAppearance.BorderSize = 0;
            this.btn_InvoiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvoiceDelete.Image = global::PBL3REAL.Properties.Resources.waste_fluent_color_96px;
            this.btn_InvoiceDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InvoiceDelete.Location = new System.Drawing.Point(179, 2);
            this.btn_InvoiceDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_InvoiceDelete.Name = "btn_InvoiceDelete";
            this.btn_InvoiceDelete.Size = new System.Drawing.Size(170, 144);
            this.btn_InvoiceDelete.TabIndex = 0;
            this.btn_InvoiceDelete.Text = "Xóa đơn đã chọn";
            this.btn_InvoiceDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_InvoiceDelete.UseVisualStyleBackColor = true;
            this.btn_InvoiceDelete.Click += new System.EventHandler(this.btn_InvoiceDelete_Click);
            // 
            // tbllaypn_Invoice
            // 
            this.tbllaypn_Invoice.ColumnCount = 3;
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.63241F));
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.36759F));
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tbllaypn_Invoice.Controls.Add(this.dtp_InvoiceTo, 1, 2);
            this.tbllaypn_Invoice.Controls.Add(this.dtp_InvoiceFrom, 1, 1);
            this.tbllaypn_Invoice.Controls.Add(this.lb_InvoiceTo, 0, 2);
            this.tbllaypn_Invoice.Controls.Add(this.lb_InvoiceFrom, 0, 1);
            this.tbllaypn_Invoice.Controls.Add(this.picbx_InvoiceSort, 2, 0);
            this.tbllaypn_Invoice.Controls.Add(this.cbb_InvoiceSort, 1, 0);
            this.tbllaypn_Invoice.Controls.Add(this.lb_InvoiceSort, 0, 0);
            this.tbllaypn_Invoice.Controls.Add(this.lb_InvoiceSearch, 0, 3);
            this.tbllaypn_Invoice.Controls.Add(this.tb_InvoiceSearch, 1, 3);
            this.tbllaypn_Invoice.Controls.Add(this.picbx_InvoiceSearch, 2, 3);
            this.tbllaypn_Invoice.Location = new System.Drawing.Point(7, 4);
            this.tbllaypn_Invoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbllaypn_Invoice.Name = "tbllaypn_Invoice";
            this.tbllaypn_Invoice.RowCount = 4;
            this.tbllaypn_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbllaypn_Invoice.Size = new System.Drawing.Size(490, 159);
            this.tbllaypn_Invoice.TabIndex = 0;
            // 
            // dtp_InvoiceTo
            // 
            this.dtp_InvoiceTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_InvoiceTo.Location = new System.Drawing.Point(138, 83);
            this.dtp_InvoiceTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_InvoiceTo.Name = "dtp_InvoiceTo";
            this.dtp_InvoiceTo.Size = new System.Drawing.Size(299, 29);
            this.dtp_InvoiceTo.TabIndex = 3;
            // 
            // dtp_InvoiceFrom
            // 
            this.dtp_InvoiceFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_InvoiceFrom.Location = new System.Drawing.Point(138, 44);
            this.dtp_InvoiceFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_InvoiceFrom.Name = "dtp_InvoiceFrom";
            this.dtp_InvoiceFrom.Size = new System.Drawing.Size(299, 29);
            this.dtp_InvoiceFrom.TabIndex = 2;
            // 
            // lb_InvoiceTo
            // 
            this.lb_InvoiceTo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_InvoiceTo.AutoSize = true;
            this.lb_InvoiceTo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceTo.Location = new System.Drawing.Point(3, 85);
            this.lb_InvoiceTo.Name = "lb_InvoiceTo";
            this.lb_InvoiceTo.Size = new System.Drawing.Size(92, 25);
            this.lb_InvoiceTo.TabIndex = 0;
            this.lb_InvoiceTo.Text = "Đến ngày";
            // 
            // lb_InvoiceFrom
            // 
            this.lb_InvoiceFrom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_InvoiceFrom.AutoSize = true;
            this.lb_InvoiceFrom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceFrom.Location = new System.Drawing.Point(3, 46);
            this.lb_InvoiceFrom.Name = "lb_InvoiceFrom";
            this.lb_InvoiceFrom.Size = new System.Drawing.Size(79, 25);
            this.lb_InvoiceFrom.TabIndex = 0;
            this.lb_InvoiceFrom.Text = "Từ ngày";
            // 
            // picbx_InvoiceSort
            // 
            this.picbx_InvoiceSort.Image = global::PBL3REAL.Properties.Resources.filter_fluent_color_48px;
            this.picbx_InvoiceSort.Location = new System.Drawing.Point(443, 2);
            this.picbx_InvoiceSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbx_InvoiceSort.Name = "picbx_InvoiceSort";
            this.picbx_InvoiceSort.Size = new System.Drawing.Size(41, 35);
            this.picbx_InvoiceSort.TabIndex = 9;
            this.picbx_InvoiceSort.TabStop = false;
            // 
            // cbb_InvoiceSort
            // 
            this.cbb_InvoiceSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_InvoiceSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_InvoiceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_InvoiceSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_InvoiceSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_InvoiceSort.FormattingEnabled = true;
            this.cbb_InvoiceSort.Items.AddRange(new object[] {
            "None",
            "Total Price Asc",
            "Total Price Desc"});
            this.cbb_InvoiceSort.Location = new System.Drawing.Point(138, 3);
            this.cbb_InvoiceSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_InvoiceSort.Name = "cbb_InvoiceSort";
            this.cbb_InvoiceSort.Size = new System.Drawing.Size(299, 33);
            this.cbb_InvoiceSort.TabIndex = 1;
            // 
            // lb_InvoiceSort
            // 
            this.lb_InvoiceSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_InvoiceSort.AutoSize = true;
            this.lb_InvoiceSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceSort.Location = new System.Drawing.Point(3, 7);
            this.lb_InvoiceSort.Name = "lb_InvoiceSort";
            this.lb_InvoiceSort.Size = new System.Drawing.Size(121, 25);
            this.lb_InvoiceSort.TabIndex = 0;
            this.lb_InvoiceSort.Text = "Sắp xếp theo";
            // 
            // lb_InvoiceSearch
            // 
            this.lb_InvoiceSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_InvoiceSearch.AutoSize = true;
            this.lb_InvoiceSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceSearch.Location = new System.Drawing.Point(3, 125);
            this.lb_InvoiceSearch.Name = "lb_InvoiceSearch";
            this.lb_InvoiceSearch.Size = new System.Drawing.Size(88, 25);
            this.lb_InvoiceSearch.TabIndex = 0;
            this.lb_InvoiceSearch.Text = "Tìm kiếm";
            // 
            // tb_InvoiceSearch
            // 
            this.tb_InvoiceSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_InvoiceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_InvoiceSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_InvoiceSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_InvoiceSearch.Location = new System.Drawing.Point(138, 125);
            this.tb_InvoiceSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_InvoiceSearch.Name = "tb_InvoiceSearch";
            this.tb_InvoiceSearch.Size = new System.Drawing.Size(299, 25);
            this.tb_InvoiceSearch.TabIndex = 4;
            // 
            // picbx_InvoiceSearch
            // 
            this.picbx_InvoiceSearch.Image = global::PBL3REAL.Properties.Resources.search_fluent_color_48px;
            this.picbx_InvoiceSearch.Location = new System.Drawing.Point(443, 119);
            this.picbx_InvoiceSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbx_InvoiceSearch.Name = "picbx_InvoiceSearch";
            this.picbx_InvoiceSearch.Size = new System.Drawing.Size(41, 35);
            this.picbx_InvoiceSearch.TabIndex = 10;
            this.picbx_InvoiceSearch.TabStop = false;
            this.picbx_InvoiceSearch.Click += new System.EventHandler(this.picbx_InvoiceSearch_Click);
            // 
            // fllaypn_InvoiceSwitchPage
            // 
            this.fllaypn_InvoiceSwitchPage.Controls.Add(this.btn_InvoicePrevPage);
            this.fllaypn_InvoiceSwitchPage.Controls.Add(this.tb_InvoicePageNumber);
            this.fllaypn_InvoiceSwitchPage.Controls.Add(this.btn_InvoiceNextPage);
            this.fllaypn_InvoiceSwitchPage.Location = new System.Drawing.Point(841, 196);
            this.fllaypn_InvoiceSwitchPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fllaypn_InvoiceSwitchPage.Name = "fllaypn_InvoiceSwitchPage";
            this.fllaypn_InvoiceSwitchPage.Size = new System.Drawing.Size(164, 33);
            this.fllaypn_InvoiceSwitchPage.TabIndex = 0;
            // 
            // btn_InvoicePrevPage
            // 
            this.btn_InvoicePrevPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_InvoicePrevPage.FlatAppearance.BorderSize = 0;
            this.btn_InvoicePrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvoicePrevPage.Image = global::PBL3REAL.Properties.Resources.prev_fluent_color_48px;
            this.btn_InvoicePrevPage.Location = new System.Drawing.Point(0, 0);
            this.btn_InvoicePrevPage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_InvoicePrevPage.Name = "btn_InvoicePrevPage";
            this.btn_InvoicePrevPage.Size = new System.Drawing.Size(38, 32);
            this.btn_InvoicePrevPage.TabIndex = 0;
            this.btn_InvoicePrevPage.UseVisualStyleBackColor = true;
            this.btn_InvoicePrevPage.Click += new System.EventHandler(this.btn_InvoicePrevPage_Click);
            // 
            // tb_InvoicePageNumber
            // 
            this.tb_InvoicePageNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_InvoicePageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_InvoicePageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_InvoicePageNumber.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_InvoicePageNumber.Location = new System.Drawing.Point(38, 1);
            this.tb_InvoicePageNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tb_InvoicePageNumber.Name = "tb_InvoicePageNumber";
            this.tb_InvoicePageNumber.Size = new System.Drawing.Size(82, 30);
            this.tb_InvoicePageNumber.TabIndex = 0;
            this.tb_InvoicePageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_InvoiceNextPage
            // 
            this.btn_InvoiceNextPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_InvoiceNextPage.FlatAppearance.BorderSize = 0;
            this.btn_InvoiceNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvoiceNextPage.Image = global::PBL3REAL.Properties.Resources.right_button_fluent_color_48px;
            this.btn_InvoiceNextPage.Location = new System.Drawing.Point(120, 0);
            this.btn_InvoiceNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_InvoiceNextPage.Name = "btn_InvoiceNextPage";
            this.btn_InvoiceNextPage.Size = new System.Drawing.Size(38, 32);
            this.btn_InvoiceNextPage.TabIndex = 0;
            this.btn_InvoiceNextPage.UseVisualStyleBackColor = true;
            this.btn_InvoiceNextPage.Click += new System.EventHandler(this.btn_InvoiceNextPage_Click);
            // 
            // picbx_InvoiceRefresh
            // 
            this.picbx_InvoiceRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picbx_InvoiceRefresh.Image = global::PBL3REAL.Properties.Resources.refresh_fluent_color_48px;
            this.picbx_InvoiceRefresh.Location = new System.Drawing.Point(792, 192);
            this.picbx_InvoiceRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picbx_InvoiceRefresh.Name = "picbx_InvoiceRefresh";
            this.picbx_InvoiceRefresh.Size = new System.Drawing.Size(41, 34);
            this.picbx_InvoiceRefresh.TabIndex = 14;
            this.picbx_InvoiceRefresh.TabStop = false;
            // 
            // tabPage_StatAnalyze
            // 
            this.tabPage_StatAnalyze.Controls.Add(this.grbx_AnalyzeOption);
            this.tabPage_StatAnalyze.Controls.Add(this.grbx_StatisticOption);
            this.tabPage_StatAnalyze.Controls.Add(this.grbx_StatAnalyze);
            this.tabPage_StatAnalyze.Location = new System.Drawing.Point(4, 30);
            this.tabPage_StatAnalyze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_StatAnalyze.Name = "tabPage_StatAnalyze";
            this.tabPage_StatAnalyze.Size = new System.Drawing.Size(996, 490);
            this.tabPage_StatAnalyze.TabIndex = 2;
            this.tabPage_StatAnalyze.Text = "Thống kê & Phân tích số liệu";
            this.tabPage_StatAnalyze.UseVisualStyleBackColor = true;
            // 
            // grbx_AnalyzeOption
            // 
            this.grbx_AnalyzeOption.Controls.Add(this.tableLayoutPanel3);
            this.grbx_AnalyzeOption.Location = new System.Drawing.Point(609, 239);
            this.grbx_AnalyzeOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_AnalyzeOption.Name = "grbx_AnalyzeOption";
            this.grbx_AnalyzeOption.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_AnalyzeOption.Size = new System.Drawing.Size(381, 254);
            this.grbx_AnalyzeOption.TabIndex = 0;
            this.grbx_AnalyzeOption.TabStop = false;
            this.grbx_AnalyzeOption.Text = "Tùy chọn phân tích";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chkbx_PredictOption, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkbx_AnalyzeOption, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(290, 127);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // chkbx_PredictOption
            // 
            this.chkbx_PredictOption.AutoSize = true;
            this.chkbx_PredictOption.Location = new System.Drawing.Point(148, 65);
            this.chkbx_PredictOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbx_PredictOption.Name = "chkbx_PredictOption";
            this.chkbx_PredictOption.Size = new System.Drawing.Size(88, 25);
            this.chkbx_PredictOption.TabIndex = 0;
            this.chkbx_PredictOption.Text = "Dự đoán";
            this.chkbx_PredictOption.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dự đoán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Phân tích";
            // 
            // chkbx_AnalyzeOption
            // 
            this.chkbx_AnalyzeOption.AutoSize = true;
            this.chkbx_AnalyzeOption.Location = new System.Drawing.Point(148, 2);
            this.chkbx_AnalyzeOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbx_AnalyzeOption.Name = "chkbx_AnalyzeOption";
            this.chkbx_AnalyzeOption.Size = new System.Drawing.Size(93, 25);
            this.chkbx_AnalyzeOption.TabIndex = 5;
            this.chkbx_AnalyzeOption.Text = "Phân tích";
            this.chkbx_AnalyzeOption.UseVisualStyleBackColor = true;
            // 
            // grbx_StatisticOption
            // 
            this.grbx_StatisticOption.Controls.Add(this.tableLayoutPanel2);
            this.grbx_StatisticOption.Location = new System.Drawing.Point(7, 237);
            this.grbx_StatisticOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_StatisticOption.Name = "grbx_StatisticOption";
            this.grbx_StatisticOption.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_StatisticOption.Size = new System.Drawing.Size(381, 254);
            this.grbx_StatisticOption.TabIndex = 0;
            this.grbx_StatisticOption.TabStop = false;
            this.grbx_StatisticOption.Text = "Tùy chọn thống kê";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.61905F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.38095F));
            this.tableLayoutPanel2.Controls.Add(this.cbb_ChartType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbb_DataSort, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 127);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbb_ChartType
            // 
            this.cbb_ChartType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_ChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ChartType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_ChartType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_ChartType.FormattingEnabled = true;
            this.cbb_ChartType.Items.AddRange(new object[] {
            "Biểu đồ đường",
            "Biểu đồ cột"});
            this.cbb_ChartType.Location = new System.Drawing.Point(141, 65);
            this.cbb_ChartType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_ChartType.Name = "cbb_ChartType";
            this.cbb_ChartType.Size = new System.Drawing.Size(224, 29);
            this.cbb_ChartType.TabIndex = 0;
            // 
            // cbb_DataSort
            // 
            this.cbb_DataSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_DataSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_DataSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_DataSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_DataSort.FormattingEnabled = true;
            this.cbb_DataSort.Items.AddRange(new object[] {
            "7 ngày gần đây",
            "30 ngày gần đây",
            "Tùy chỉnh"});
            this.cbb_DataSort.Location = new System.Drawing.Point(141, 2);
            this.cbb_DataSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_DataSort.Name = "cbb_DataSort";
            this.cbb_DataSort.Size = new System.Drawing.Size(224, 29);
            this.cbb_DataSort.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chọn biểu đồ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sắp xếp theo";
            // 
            // grbx_StatAnalyze
            // 
            this.grbx_StatAnalyze.Controls.Add(this.tbllaypn_ControlBar);
            this.grbx_StatAnalyze.Controls.Add(this.tbllaypn_DataOption);
            this.grbx_StatAnalyze.Location = new System.Drawing.Point(7, 2);
            this.grbx_StatAnalyze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_StatAnalyze.Name = "grbx_StatAnalyze";
            this.grbx_StatAnalyze.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbx_StatAnalyze.Size = new System.Drawing.Size(983, 224);
            this.grbx_StatAnalyze.TabIndex = 0;
            this.grbx_StatAnalyze.TabStop = false;
            this.grbx_StatAnalyze.Text = "Tùy chọn dữ liệu";
            // 
            // tbllaypn_ControlBar
            // 
            this.tbllaypn_ControlBar.ColumnCount = 1;
            this.tbllaypn_ControlBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_ControlBar.Controls.Add(this.btn_Reset, 0, 1);
            this.tbllaypn_ControlBar.Controls.Add(this.btn_OK, 0, 0);
            this.tbllaypn_ControlBar.Location = new System.Drawing.Point(722, 84);
            this.tbllaypn_ControlBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbllaypn_ControlBar.Name = "tbllaypn_ControlBar";
            this.tbllaypn_ControlBar.RowCount = 2;
            this.tbllaypn_ControlBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_ControlBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_ControlBar.Size = new System.Drawing.Size(96, 98);
            this.tbllaypn_ControlBar.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(9, 58);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(78, 30);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OK.Location = new System.Drawing.Point(9, 9);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(78, 30);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tbllaypn_DataOption
            // 
            this.tbllaypn_DataOption.ColumnCount = 2;
            this.tbllaypn_DataOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.02078F));
            this.tbllaypn_DataOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.97922F));
            this.tbllaypn_DataOption.Controls.Add(this.tbllaypn_ActionOption, 1, 4);
            this.tbllaypn_DataOption.Controls.Add(this.lb_DataType, 0, 0);
            this.tbllaypn_DataOption.Controls.Add(this.lb_PeriodTime, 0, 1);
            this.tbllaypn_DataOption.Controls.Add(this.lb_From, 0, 2);
            this.tbllaypn_DataOption.Controls.Add(this.lb_To, 0, 3);
            this.tbllaypn_DataOption.Controls.Add(this.lb_ActionOption, 0, 4);
            this.tbllaypn_DataOption.Controls.Add(this.dtp_From, 1, 2);
            this.tbllaypn_DataOption.Controls.Add(this.dtp_To, 1, 3);
            this.tbllaypn_DataOption.Controls.Add(this.cbb_DataType, 1, 0);
            this.tbllaypn_DataOption.Controls.Add(this.cbb_PeriodTime, 1, 1);
            this.tbllaypn_DataOption.Location = new System.Drawing.Point(5, 25);
            this.tbllaypn_DataOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbllaypn_DataOption.Name = "tbllaypn_DataOption";
            this.tbllaypn_DataOption.RowCount = 5;
            this.tbllaypn_DataOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbllaypn_DataOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbllaypn_DataOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbllaypn_DataOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbllaypn_DataOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbllaypn_DataOption.Size = new System.Drawing.Size(678, 193);
            this.tbllaypn_DataOption.TabIndex = 0;
            // 
            // tbllaypn_ActionOption
            // 
            this.tbllaypn_ActionOption.ColumnCount = 2;
            this.tbllaypn_ActionOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_ActionOption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_ActionOption.Controls.Add(this.chkbx_Analyze, 1, 0);
            this.tbllaypn_ActionOption.Controls.Add(this.chkbx_Statistic, 0, 0);
            this.tbllaypn_ActionOption.Location = new System.Drawing.Point(186, 154);
            this.tbllaypn_ActionOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbllaypn_ActionOption.Name = "tbllaypn_ActionOption";
            this.tbllaypn_ActionOption.RowCount = 1;
            this.tbllaypn_ActionOption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_ActionOption.Size = new System.Drawing.Size(290, 35);
            this.tbllaypn_ActionOption.TabIndex = 0;
            // 
            // chkbx_Analyze
            // 
            this.chkbx_Analyze.AutoSize = true;
            this.chkbx_Analyze.Location = new System.Drawing.Point(148, 2);
            this.chkbx_Analyze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbx_Analyze.Name = "chkbx_Analyze";
            this.chkbx_Analyze.Size = new System.Drawing.Size(93, 25);
            this.chkbx_Analyze.TabIndex = 0;
            this.chkbx_Analyze.Text = "Phân tích";
            this.chkbx_Analyze.UseVisualStyleBackColor = true;
            this.chkbx_Analyze.CheckedChanged += new System.EventHandler(this.chkbx_Analyze_CheckedChanged);
            // 
            // chkbx_Statistic
            // 
            this.chkbx_Statistic.AutoSize = true;
            this.chkbx_Statistic.Location = new System.Drawing.Point(3, 2);
            this.chkbx_Statistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbx_Statistic.Name = "chkbx_Statistic";
            this.chkbx_Statistic.Size = new System.Drawing.Size(93, 25);
            this.chkbx_Statistic.TabIndex = 0;
            this.chkbx_Statistic.Text = "Thống kê";
            this.chkbx_Statistic.UseVisualStyleBackColor = true;
            this.chkbx_Statistic.CheckedChanged += new System.EventHandler(this.chkbx_Statistic_CheckedChanged);
            // 
            // lb_DataType
            // 
            this.lb_DataType.AutoSize = true;
            this.lb_DataType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_DataType.Location = new System.Drawing.Point(3, 0);
            this.lb_DataType.Name = "lb_DataType";
            this.lb_DataType.Size = new System.Drawing.Size(156, 25);
            this.lb_DataType.TabIndex = 0;
            this.lb_DataType.Text = "Chọn loại dữ liệu";
            // 
            // lb_PeriodTime
            // 
            this.lb_PeriodTime.AutoSize = true;
            this.lb_PeriodTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_PeriodTime.Location = new System.Drawing.Point(3, 38);
            this.lb_PeriodTime.Name = "lb_PeriodTime";
            this.lb_PeriodTime.Size = new System.Drawing.Size(159, 25);
            this.lb_PeriodTime.TabIndex = 0;
            this.lb_PeriodTime.Text = "Phạm vi thời gian";
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_From.Location = new System.Drawing.Point(3, 76);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(79, 25);
            this.lb_From.TabIndex = 0;
            this.lb_From.Text = "Từ ngày";
            // 
            // lb_To
            // 
            this.lb_To.AutoSize = true;
            this.lb_To.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_To.Location = new System.Drawing.Point(3, 114);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(92, 25);
            this.lb_To.TabIndex = 0;
            this.lb_To.Text = "Đến ngày";
            // 
            // lb_ActionOption
            // 
            this.lb_ActionOption.AutoSize = true;
            this.lb_ActionOption.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ActionOption.Location = new System.Drawing.Point(3, 152);
            this.lb_ActionOption.Name = "lb_ActionOption";
            this.lb_ActionOption.Size = new System.Drawing.Size(154, 25);
            this.lb_ActionOption.TabIndex = 0;
            this.lb_ActionOption.Text = "Chọn hành động";
            // 
            // dtp_From
            // 
            this.dtp_From.Location = new System.Drawing.Point(186, 78);
            this.dtp_From.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(290, 29);
            this.dtp_From.TabIndex = 3;
            // 
            // dtp_To
            // 
            this.dtp_To.Location = new System.Drawing.Point(186, 116);
            this.dtp_To.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(290, 29);
            this.dtp_To.TabIndex = 4;
            // 
            // cbb_DataType
            // 
            this.cbb_DataType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_DataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_DataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_DataType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_DataType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_DataType.FormattingEnabled = true;
            this.cbb_DataType.Items.AddRange(new object[] {
            "Doanh thu",
            "Đơn booking"});
            this.cbb_DataType.Location = new System.Drawing.Point(186, 4);
            this.cbb_DataType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_DataType.Name = "cbb_DataType";
            this.cbb_DataType.Size = new System.Drawing.Size(290, 29);
            this.cbb_DataType.TabIndex = 1;
            // 
            // cbb_PeriodTime
            // 
            this.cbb_PeriodTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_PeriodTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_PeriodTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_PeriodTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_PeriodTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_PeriodTime.FormattingEnabled = true;
            this.cbb_PeriodTime.Items.AddRange(new object[] {
            "7 ngày gần đây",
            "30 ngày gần đây",
            "Tùy chỉnh"});
            this.cbb_PeriodTime.Location = new System.Drawing.Point(186, 42);
            this.cbb_PeriodTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_PeriodTime.Name = "cbb_PeriodTime";
            this.cbb_PeriodTime.Size = new System.Drawing.Size(290, 29);
            this.cbb_PeriodTime.TabIndex = 2;
            this.cbb_PeriodTime.SelectedIndexChanged += new System.EventHandler(this.cbb_PeriodTime_SelectedIndexChanged);
            // 
            // Form_Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 524);
            this.Controls.Add(this.tabControl_Accountant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Accountant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Accountant";
            this.tabControl_Accountant.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).EndInit();
            this.fllaypn_InvoiceButtons.ResumeLayout(false);
            this.tbllaypn_Invoice.ResumeLayout(false);
            this.tbllaypn_Invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSearch)).EndInit();
            this.fllaypn_InvoiceSwitchPage.ResumeLayout(false);
            this.fllaypn_InvoiceSwitchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceRefresh)).EndInit();
            this.tabPage_StatAnalyze.ResumeLayout(false);
            this.grbx_AnalyzeOption.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grbx_StatisticOption.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grbx_StatAnalyze.ResumeLayout(false);
            this.tbllaypn_ControlBar.ResumeLayout(false);
            this.tbllaypn_DataOption.ResumeLayout(false);
            this.tbllaypn_DataOption.PerformLayout();
            this.tbllaypn_ActionOption.ResumeLayout(false);
            this.tbllaypn_ActionOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Accountant;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TabPage tabPage_Invoice;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_InvoiceButtons;
        private System.Windows.Forms.Button btn_InvoiceView;
        private System.Windows.Forms.Button btn_InvoiceDelete;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_Invoice;
        private System.Windows.Forms.PictureBox picbx_InvoiceSearch;
        private System.Windows.Forms.PictureBox picbx_InvoiceSort;
        private System.Windows.Forms.ComboBox cbb_InvoiceSort;
        private System.Windows.Forms.TextBox tb_InvoiceSearch;
        private System.Windows.Forms.Label lb_InvoiceSearch;
        private System.Windows.Forms.Label lb_InvoiceSort;
        private System.Windows.Forms.TabPage tabPage_StatAnalyze;
        private System.Windows.Forms.GroupBox grbx_StatAnalyze;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_DataOption;
        private System.Windows.Forms.GroupBox grbx_AnalyzeOption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbx_StatisticOption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ControlBar;
        private System.Windows.Forms.Label lb_DataType;
        private System.Windows.Forms.Label lb_PeriodTime;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.Label lb_ActionOption;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ActionOption;
        private System.Windows.Forms.CheckBox chkbx_Analyze;
        private System.Windows.Forms.CheckBox chkbx_Statistic;
        private System.Windows.Forms.ComboBox cbb_DataType;
        private System.Windows.Forms.ComboBox cbb_PeriodTime;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_InvoiceSwitchPage;
        private System.Windows.Forms.Button btn_InvoicePrevPage;
        private System.Windows.Forms.TextBox tb_InvoicePageNumber;
        private System.Windows.Forms.Button btn_InvoiceNextPage;
        private System.Windows.Forms.PictureBox picbx_InvoiceRefresh;
        private System.Windows.Forms.CheckBox chkbx_PredictOption;
        private System.Windows.Forms.CheckBox chkbx_AnalyzeOption;
        private System.Windows.Forms.ComboBox cbb_ChartType;
        private System.Windows.Forms.ComboBox cbb_DataSort;
        private System.Windows.Forms.Label lb_InvoiceFrom;
        private System.Windows.Forms.Label lb_InvoiceTo;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceTo;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceFrom;
        private System.Windows.Forms.DataGridView dgv_Invoice;
    }
}