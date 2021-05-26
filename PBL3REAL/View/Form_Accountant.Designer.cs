﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Accountant));
            this.tabControl_Accountant = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.btn_Home = new System.Windows.Forms.Button();
            this.tabPage_Invoice = new System.Windows.Forms.TabPage();
            this.dgv_Invoice = new System.Windows.Forms.DataGridView();
            this.fllaypn_InvoiceButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_InvoiceView = new System.Windows.Forms.Button();
            this.btn_InvoiceAdd = new System.Windows.Forms.Button();
            this.btn_InvoiceEdit = new System.Windows.Forms.Button();
            this.btn_InvoiceDelete = new System.Windows.Forms.Button();
            this.tbllaypn_Invoice = new System.Windows.Forms.TableLayoutPanel();
            this.picbx_InvoiceSearch = new System.Windows.Forms.PictureBox();
            this.picbx_InvoiceSort = new System.Windows.Forms.PictureBox();
            this.cbb_InvoiceSort = new System.Windows.Forms.ComboBox();
            this.tb_InvoiceSearch = new System.Windows.Forms.TextBox();
            this.lb_InvoiceSearch = new System.Windows.Forms.Label();
            this.lb_InvoiceSort = new System.Windows.Forms.Label();
            this.tabPage_StatAnalyze = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbx_StatAnalyze = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl_Accountant.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.tabPage_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).BeginInit();
            this.fllaypn_InvoiceButtons.SuspendLayout();
            this.tbllaypn_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSort)).BeginInit();
            this.tabPage_StatAnalyze.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grbx_StatAnalyze.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tabControl_Accountant.Name = "tabControl_Accountant";
            this.tabControl_Accountant.SelectedIndex = 0;
            this.tabControl_Accountant.Size = new System.Drawing.Size(980, 699);
            this.tabControl_Accountant.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(this.btn_Home);
            this.tabPage_General.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_General.Location = new System.Drawing.Point(4, 37);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(972, 658);
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
            this.btn_Home.Location = new System.Drawing.Point(389, 238);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(194, 183);
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
            this.tabPage_Invoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_Invoice.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Invoice.Name = "tabPage_Invoice";
            this.tabPage_Invoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Invoice.Size = new System.Drawing.Size(972, 658);
            this.tabPage_Invoice.TabIndex = 1;
            this.tabPage_Invoice.Text = "Quản lí hóa đơn";
            this.tabPage_Invoice.UseVisualStyleBackColor = true;
            // 
            // dgv_Invoice
            // 
            this.dgv_Invoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Invoice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Invoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Invoice.ColumnHeadersVisible = false;
            this.dgv_Invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv_Invoice.Location = new System.Drawing.Point(0, 165);
            this.dgv_Invoice.Name = "dgv_Invoice";
            this.dgv_Invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Invoice.RowHeadersWidth = 51;
            this.dgv_Invoice.RowTemplate.Height = 29;
            this.dgv_Invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Invoice.Size = new System.Drawing.Size(969, 493);
            this.dgv_Invoice.TabIndex = 0;
            // 
            // fllaypn_InvoiceButtons
            // 
            this.fllaypn_InvoiceButtons.Controls.Add(this.btn_InvoiceView);
            this.fllaypn_InvoiceButtons.Controls.Add(this.btn_InvoiceAdd);
            this.fllaypn_InvoiceButtons.Controls.Add(this.btn_InvoiceEdit);
            this.fllaypn_InvoiceButtons.Controls.Add(this.btn_InvoiceDelete);
            this.fllaypn_InvoiceButtons.Location = new System.Drawing.Point(449, 3);
            this.fllaypn_InvoiceButtons.Name = "fllaypn_InvoiceButtons";
            this.fllaypn_InvoiceButtons.Size = new System.Drawing.Size(516, 147);
            this.fllaypn_InvoiceButtons.TabIndex = 0;
            // 
            // btn_InvoiceView
            // 
            this.btn_InvoiceView.FlatAppearance.BorderSize = 0;
            this.btn_InvoiceView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvoiceView.Image = global::PBL3REAL.Properties.Resources.show_property_96px;
            this.btn_InvoiceView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InvoiceView.Location = new System.Drawing.Point(3, 3);
            this.btn_InvoiceView.Name = "btn_InvoiceView";
            this.btn_InvoiceView.Size = new System.Drawing.Size(123, 147);
            this.btn_InvoiceView.TabIndex = 0;
            this.btn_InvoiceView.Text = "Xem thông tin đơn đã chọn";
            this.btn_InvoiceView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_InvoiceView.UseVisualStyleBackColor = true;
            // 
            // btn_InvoiceAdd
            // 
            this.btn_InvoiceAdd.FlatAppearance.BorderSize = 0;
            this.btn_InvoiceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvoiceAdd.Image = global::PBL3REAL.Properties.Resources.add_fluent_color_96px;
            this.btn_InvoiceAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InvoiceAdd.Location = new System.Drawing.Point(132, 3);
            this.btn_InvoiceAdd.Name = "btn_InvoiceAdd";
            this.btn_InvoiceAdd.Size = new System.Drawing.Size(123, 147);
            this.btn_InvoiceAdd.TabIndex = 0;
            this.btn_InvoiceAdd.Text = "Thêm đơn mới";
            this.btn_InvoiceAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_InvoiceAdd.UseVisualStyleBackColor = true;
            // 
            // btn_InvoiceEdit
            // 
            this.btn_InvoiceEdit.FlatAppearance.BorderSize = 0;
            this.btn_InvoiceEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvoiceEdit.Image = global::PBL3REAL.Properties.Resources.edit_property_fluent_color_96px;
            this.btn_InvoiceEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InvoiceEdit.Location = new System.Drawing.Point(261, 3);
            this.btn_InvoiceEdit.Name = "btn_InvoiceEdit";
            this.btn_InvoiceEdit.Size = new System.Drawing.Size(123, 147);
            this.btn_InvoiceEdit.TabIndex = 0;
            this.btn_InvoiceEdit.Text = "Chỉnh sửa thông tin đơn đã chọn";
            this.btn_InvoiceEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_InvoiceEdit.UseVisualStyleBackColor = true;
            // 
            // btn_InvoiceDelete
            // 
            this.btn_InvoiceDelete.FlatAppearance.BorderSize = 0;
            this.btn_InvoiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InvoiceDelete.Image = global::PBL3REAL.Properties.Resources.waste_fluent_color_96px;
            this.btn_InvoiceDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InvoiceDelete.Location = new System.Drawing.Point(390, 3);
            this.btn_InvoiceDelete.Name = "btn_InvoiceDelete";
            this.btn_InvoiceDelete.Size = new System.Drawing.Size(123, 147);
            this.btn_InvoiceDelete.TabIndex = 0;
            this.btn_InvoiceDelete.Text = "Xóa đơn đã chọn";
            this.btn_InvoiceDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_InvoiceDelete.UseVisualStyleBackColor = true;
            // 
            // tbllaypn_Invoice
            // 
            this.tbllaypn_Invoice.ColumnCount = 3;
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.30407F));
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.69593F));
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tbllaypn_Invoice.Controls.Add(this.picbx_InvoiceSearch, 2, 1);
            this.tbllaypn_Invoice.Controls.Add(this.picbx_InvoiceSort, 2, 0);
            this.tbllaypn_Invoice.Controls.Add(this.cbb_InvoiceSort, 1, 0);
            this.tbllaypn_Invoice.Controls.Add(this.tb_InvoiceSearch, 1, 1);
            this.tbllaypn_Invoice.Controls.Add(this.lb_InvoiceSearch, 0, 1);
            this.tbllaypn_Invoice.Controls.Add(this.lb_InvoiceSort, 0, 0);
            this.tbllaypn_Invoice.Location = new System.Drawing.Point(12, 26);
            this.tbllaypn_Invoice.Name = "tbllaypn_Invoice";
            this.tbllaypn_Invoice.RowCount = 2;
            this.tbllaypn_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Invoice.Size = new System.Drawing.Size(386, 111);
            this.tbllaypn_Invoice.TabIndex = 0;
            // 
            // picbx_InvoiceSearch
            // 
            this.picbx_InvoiceSearch.Image = global::PBL3REAL.Properties.Resources.search_fluent_color_48px;
            this.picbx_InvoiceSearch.Location = new System.Drawing.Point(308, 58);
            this.picbx_InvoiceSearch.Name = "picbx_InvoiceSearch";
            this.picbx_InvoiceSearch.Size = new System.Drawing.Size(47, 48);
            this.picbx_InvoiceSearch.TabIndex = 10;
            this.picbx_InvoiceSearch.TabStop = false;
            // 
            // picbx_InvoiceSort
            // 
            this.picbx_InvoiceSort.Image = global::PBL3REAL.Properties.Resources.filter_fluent_color_48px;
            this.picbx_InvoiceSort.Location = new System.Drawing.Point(308, 3);
            this.picbx_InvoiceSort.Name = "picbx_InvoiceSort";
            this.picbx_InvoiceSort.Size = new System.Drawing.Size(47, 48);
            this.picbx_InvoiceSort.TabIndex = 9;
            this.picbx_InvoiceSort.TabStop = false;
            // 
            // cbb_InvoiceSort
            // 
            this.cbb_InvoiceSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_InvoiceSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_InvoiceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_InvoiceSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_InvoiceSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_InvoiceSort.FormattingEnabled = true;
            this.cbb_InvoiceSort.Location = new System.Drawing.Point(117, 3);
            this.cbb_InvoiceSort.Name = "cbb_InvoiceSort";
            this.cbb_InvoiceSort.Size = new System.Drawing.Size(185, 39);
            this.cbb_InvoiceSort.TabIndex = 0;
            // 
            // tb_InvoiceSearch
            // 
            this.tb_InvoiceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_InvoiceSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_InvoiceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_InvoiceSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_InvoiceSearch.Location = new System.Drawing.Point(117, 58);
            this.tb_InvoiceSearch.Name = "tb_InvoiceSearch";
            this.tb_InvoiceSearch.Size = new System.Drawing.Size(185, 31);
            this.tb_InvoiceSearch.TabIndex = 0;
            // 
            // lb_InvoiceSearch
            // 
            this.lb_InvoiceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_InvoiceSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceSearch.Location = new System.Drawing.Point(3, 55);
            this.lb_InvoiceSearch.Name = "lb_InvoiceSearch";
            this.lb_InvoiceSearch.Size = new System.Drawing.Size(108, 56);
            this.lb_InvoiceSearch.TabIndex = 0;
            this.lb_InvoiceSearch.Text = "Tìm kiếm";
            // 
            // lb_InvoiceSort
            // 
            this.lb_InvoiceSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_InvoiceSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceSort.Location = new System.Drawing.Point(3, 0);
            this.lb_InvoiceSort.Name = "lb_InvoiceSort";
            this.lb_InvoiceSort.Size = new System.Drawing.Size(108, 55);
            this.lb_InvoiceSort.TabIndex = 0;
            this.lb_InvoiceSort.Text = "Sắp xếp theo";
            // 
            // tabPage_StatAnalyze
            // 
            this.tabPage_StatAnalyze.Controls.Add(this.groupBox2);
            this.tabPage_StatAnalyze.Controls.Add(this.groupBox1);
            this.tabPage_StatAnalyze.Controls.Add(this.grbx_StatAnalyze);
            this.tabPage_StatAnalyze.Location = new System.Drawing.Point(4, 37);
            this.tabPage_StatAnalyze.Name = "tabPage_StatAnalyze";
            this.tabPage_StatAnalyze.Size = new System.Drawing.Size(972, 658);
            this.tabPage_StatAnalyze.TabIndex = 2;
            this.tabPage_StatAnalyze.Text = "Thống kê & Phân tích số liệu";
            this.tabPage_StatAnalyze.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(534, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 339);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn phân tích";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 46);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(332, 169);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Dự đoán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Phân tích";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(8, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 169);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chọn biểu đồ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sắp xếp theo";
            // 
            // grbx_StatAnalyze
            // 
            this.grbx_StatAnalyze.Controls.Add(this.tableLayoutPanel4);
            this.grbx_StatAnalyze.Controls.Add(this.tableLayoutPanel1);
            this.grbx_StatAnalyze.Location = new System.Drawing.Point(8, 3);
            this.grbx_StatAnalyze.Name = "grbx_StatAnalyze";
            this.grbx_StatAnalyze.Size = new System.Drawing.Size(961, 298);
            this.grbx_StatAnalyze.TabIndex = 0;
            this.grbx_StatAnalyze.TabStop = false;
            this.grbx_StatAnalyze.Text = "Tùy chọn dữ liệu";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Reset, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_OK, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(825, 112);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(110, 130);
            this.tableLayoutPanel4.TabIndex = 1;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(10, 77);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(89, 40);
            this.btn_Reset.TabIndex = 2;
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
            this.btn_OK.Location = new System.Drawing.Point(10, 12);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(89, 40);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.02078F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.97922F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn loại dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phạm vi thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn hành động";
            // 
            // Form_Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 699);
            this.Controls.Add(this.tabControl_Accountant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSort)).EndInit();
            this.tabPage_StatAnalyze.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grbx_StatAnalyze.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Accountant;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TabPage tabPage_Invoice;
        private System.Windows.Forms.DataGridView dgv_Invoice;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_InvoiceButtons;
        private System.Windows.Forms.Button btn_InvoiceView;
        private System.Windows.Forms.Button btn_InvoiceAdd;
        private System.Windows.Forms.Button btn_InvoiceEdit;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Home;
    }
}