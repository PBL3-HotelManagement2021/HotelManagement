
namespace PBL3REAL.View
{
    partial class Form_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Client));
            this.tabControl_Client = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.btn_Home = new System.Windows.Forms.Button();
            this.tabPage_Client = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.fllaypn_ClientButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.CLIE_VIEW = new System.Windows.Forms.Button();
            this.CLIE_ADD = new System.Windows.Forms.Button();
            this.CLIE_UPDATE = new System.Windows.Forms.Button();
            this.CLIE_INACTIVE = new System.Windows.Forms.Button();
            this.CLIE_ACTIVE = new System.Windows.Forms.Button();
            this.tbllaypn_Client = new System.Windows.Forms.TableLayoutPanel();
            this.picbx_ClientSort = new System.Windows.Forms.PictureBox();
            this.cbb_ClientSort = new System.Windows.Forms.ComboBox();
            this.lb_ClientSort = new System.Windows.Forms.Label();
            this.tb_ClientSearch = new System.Windows.Forms.TextBox();
            this.lb_ClientSearch = new System.Windows.Forms.Label();
            this.lb_ClientStatus = new System.Windows.Forms.Label();
            this.cbb_ClientStatus = new System.Windows.Forms.ComboBox();
            this.picbx_ClientSearch = new System.Windows.Forms.PictureBox();
            this.fllaypn_ClientSwitchPage = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ClientPrevPage = new System.Windows.Forms.Button();
            this.tb_ClientPageNumber = new System.Windows.Forms.TextBox();
            this.btn_ClientNextPage = new System.Windows.Forms.Button();
            this.picbx_ClientRefresh = new System.Windows.Forms.PictureBox();
            this.tabControl_Client.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.tabPage_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.fllaypn_ClientButtons.SuspendLayout();
            this.tbllaypn_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientSearch)).BeginInit();
            this.fllaypn_ClientSwitchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Client
            // 
            this.tabControl_Client.Controls.Add(this.tabPage_General);
            this.tabControl_Client.Controls.Add(this.tabPage_Client);
            this.tabControl_Client.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl_Client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl_Client.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Client.Name = "tabControl_Client";
            this.tabControl_Client.SelectedIndex = 0;
            this.tabControl_Client.Size = new System.Drawing.Size(1301, 788);
            this.tabControl_Client.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(this.btn_Home);
            this.tabPage_General.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_General.Location = new System.Drawing.Point(4, 37);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_General.Size = new System.Drawing.Size(1293, 747);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "General";
            this.tabPage_General.UseVisualStyleBackColor = true;
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Image = global::PBL3REAL.Properties.Resources.home_page_fluent_color_96px;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Home.Location = new System.Drawing.Point(377, 252);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(194, 183);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Return Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // tabPage_Client
            // 
            this.tabPage_Client.Controls.Add(this.dgv);
            this.tabPage_Client.Controls.Add(this.fllaypn_ClientButtons);
            this.tabPage_Client.Controls.Add(this.tbllaypn_Client);
            this.tabPage_Client.Controls.Add(this.fllaypn_ClientSwitchPage);
            this.tabPage_Client.Controls.Add(this.picbx_ClientRefresh);
            this.tabPage_Client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_Client.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Client.Name = "tabPage_Client";
            this.tabPage_Client.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_Client.Size = new System.Drawing.Size(1293, 747);
            this.tabPage_Client.TabIndex = 1;
            this.tabPage_Client.Text = "Client Management";
            this.tabPage_Client.UseVisualStyleBackColor = true;
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
            this.dgv.Location = new System.Drawing.Point(0, 253);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1293, 493);
            this.dgv.TabIndex = 0;
            // 
            // fllaypn_ClientButtons
            // 
            this.fllaypn_ClientButtons.Controls.Add(this.CLIE_VIEW);
            this.fllaypn_ClientButtons.Controls.Add(this.CLIE_ADD);
            this.fllaypn_ClientButtons.Controls.Add(this.CLIE_UPDATE);
            this.fllaypn_ClientButtons.Controls.Add(this.CLIE_INACTIVE);
            this.fllaypn_ClientButtons.Controls.Add(this.CLIE_ACTIVE);
            this.fllaypn_ClientButtons.Location = new System.Drawing.Point(449, 3);
            this.fllaypn_ClientButtons.Name = "fllaypn_ClientButtons";
            this.fllaypn_ClientButtons.Size = new System.Drawing.Size(841, 207);
            this.fllaypn_ClientButtons.TabIndex = 0;
            // 
            // CLIE_VIEW
            // 
            this.CLIE_VIEW.Enabled = false;
            this.CLIE_VIEW.FlatAppearance.BorderSize = 0;
            this.CLIE_VIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLIE_VIEW.Image = global::PBL3REAL.Properties.Resources.show_property_96px;
            this.CLIE_VIEW.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CLIE_VIEW.Location = new System.Drawing.Point(3, 3);
            this.CLIE_VIEW.Name = "CLIE_VIEW";
            this.CLIE_VIEW.Size = new System.Drawing.Size(158, 199);
            this.CLIE_VIEW.TabIndex = 0;
            this.CLIE_VIEW.Text = "View Client";
            this.CLIE_VIEW.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CLIE_VIEW.UseVisualStyleBackColor = true;
            this.CLIE_VIEW.Click += new System.EventHandler(this.btn_ClientView_Click);
            // 
            // CLIE_ADD
            // 
            this.CLIE_ADD.Enabled = false;
            this.CLIE_ADD.FlatAppearance.BorderSize = 0;
            this.CLIE_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLIE_ADD.Image = global::PBL3REAL.Properties.Resources.add_fluent_color_96px;
            this.CLIE_ADD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CLIE_ADD.Location = new System.Drawing.Point(167, 3);
            this.CLIE_ADD.Name = "CLIE_ADD";
            this.CLIE_ADD.Size = new System.Drawing.Size(158, 199);
            this.CLIE_ADD.TabIndex = 0;
            this.CLIE_ADD.Text = "Add Client";
            this.CLIE_ADD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CLIE_ADD.UseVisualStyleBackColor = true;
            this.CLIE_ADD.Click += new System.EventHandler(this.btn_ClientAdd_Click);
            // 
            // CLIE_UPDATE
            // 
            this.CLIE_UPDATE.Enabled = false;
            this.CLIE_UPDATE.FlatAppearance.BorderSize = 0;
            this.CLIE_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLIE_UPDATE.Image = global::PBL3REAL.Properties.Resources.edit_property_fluent_color_96px;
            this.CLIE_UPDATE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CLIE_UPDATE.Location = new System.Drawing.Point(331, 3);
            this.CLIE_UPDATE.Name = "CLIE_UPDATE";
            this.CLIE_UPDATE.Size = new System.Drawing.Size(158, 199);
            this.CLIE_UPDATE.TabIndex = 0;
            this.CLIE_UPDATE.Text = "Update Client";
            this.CLIE_UPDATE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CLIE_UPDATE.UseVisualStyleBackColor = true;
            this.CLIE_UPDATE.Click += new System.EventHandler(this.btn_ClientEdit_Click);
            // 
            // CLIE_INACTIVE
            // 
            this.CLIE_INACTIVE.Enabled = false;
            this.CLIE_INACTIVE.FlatAppearance.BorderSize = 0;
            this.CLIE_INACTIVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLIE_INACTIVE.Image = global::PBL3REAL.Properties.Resources.waste_fluent_color_96px;
            this.CLIE_INACTIVE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CLIE_INACTIVE.Location = new System.Drawing.Point(495, 3);
            this.CLIE_INACTIVE.Name = "CLIE_INACTIVE";
            this.CLIE_INACTIVE.Size = new System.Drawing.Size(158, 199);
            this.CLIE_INACTIVE.TabIndex = 0;
            this.CLIE_INACTIVE.Text = "Inactive Client";
            this.CLIE_INACTIVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CLIE_INACTIVE.UseVisualStyleBackColor = true;
            this.CLIE_INACTIVE.Click += new System.EventHandler(this.btn_ClientDelete_Click);
            // 
            // CLIE_ACTIVE
            // 
            this.CLIE_ACTIVE.Enabled = false;
            this.CLIE_ACTIVE.FlatAppearance.BorderSize = 0;
            this.CLIE_ACTIVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLIE_ACTIVE.Image = global::PBL3REAL.Properties.Resources.restore_fluent_color_96px;
            this.CLIE_ACTIVE.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CLIE_ACTIVE.Location = new System.Drawing.Point(659, 3);
            this.CLIE_ACTIVE.Name = "CLIE_ACTIVE";
            this.CLIE_ACTIVE.Size = new System.Drawing.Size(158, 199);
            this.CLIE_ACTIVE.TabIndex = 0;
            this.CLIE_ACTIVE.Text = "Restore Client";
            this.CLIE_ACTIVE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CLIE_ACTIVE.UseVisualStyleBackColor = true;
            this.CLIE_ACTIVE.Click += new System.EventHandler(this.btn_ClientRestore_Click);
            // 
            // tbllaypn_Client
            // 
            this.tbllaypn_Client.ColumnCount = 3;
            this.tbllaypn_Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.56425F));
            this.tbllaypn_Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.43575F));
            this.tbllaypn_Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tbllaypn_Client.Controls.Add(this.picbx_ClientSort, 2, 0);
            this.tbllaypn_Client.Controls.Add(this.cbb_ClientSort, 1, 0);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientSort, 0, 0);
            this.tbllaypn_Client.Controls.Add(this.tb_ClientSearch, 1, 2);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientSearch, 0, 2);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientStatus, 0, 1);
            this.tbllaypn_Client.Controls.Add(this.cbb_ClientStatus, 1, 1);
            this.tbllaypn_Client.Controls.Add(this.picbx_ClientSearch, 2, 2);
            this.tbllaypn_Client.Location = new System.Drawing.Point(8, 15);
            this.tbllaypn_Client.Name = "tbllaypn_Client";
            this.tbllaypn_Client.RowCount = 3;
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Client.Size = new System.Drawing.Size(369, 159);
            this.tbllaypn_Client.TabIndex = 0;
            // 
            // picbx_ClientSort
            // 
            this.picbx_ClientSort.Image = global::PBL3REAL.Properties.Resources.filter_fluent_color_48px;
            this.picbx_ClientSort.Location = new System.Drawing.Point(322, 3);
            this.picbx_ClientSort.Name = "picbx_ClientSort";
            this.picbx_ClientSort.Size = new System.Drawing.Size(44, 47);
            this.picbx_ClientSort.TabIndex = 9;
            this.picbx_ClientSort.TabStop = false;
            // 
            // cbb_ClientSort
            // 
            this.cbb_ClientSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_ClientSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_ClientSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ClientSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_ClientSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_ClientSort.FormattingEnabled = true;
            this.cbb_ClientSort.Items.AddRange(new object[] {
            "None",
            "Name Asc",
            "Name Desc"});
            this.cbb_ClientSort.Location = new System.Drawing.Point(104, 7);
            this.cbb_ClientSort.Name = "cbb_ClientSort";
            this.cbb_ClientSort.Size = new System.Drawing.Size(211, 39);
            this.cbb_ClientSort.TabIndex = 1;
            // 
            // lb_ClientSort
            // 
            this.lb_ClientSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientSort.AutoSize = true;
            this.lb_ClientSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientSort.Location = new System.Drawing.Point(3, 11);
            this.lb_ClientSort.Name = "lb_ClientSort";
            this.lb_ClientSort.Size = new System.Drawing.Size(86, 31);
            this.lb_ClientSort.TabIndex = 0;
            this.lb_ClientSort.Text = "Sort by";
            // 
            // tb_ClientSearch
            // 
            this.tb_ClientSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ClientSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ClientSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientSearch.Location = new System.Drawing.Point(104, 117);
            this.tb_ClientSearch.Name = "tb_ClientSearch";
            this.tb_ClientSearch.Size = new System.Drawing.Size(212, 31);
            this.tb_ClientSearch.TabIndex = 3;
            // 
            // lb_ClientSearch
            // 
            this.lb_ClientSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientSearch.AutoSize = true;
            this.lb_ClientSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientSearch.Location = new System.Drawing.Point(3, 117);
            this.lb_ClientSearch.Name = "lb_ClientSearch";
            this.lb_ClientSearch.Size = new System.Drawing.Size(82, 31);
            this.lb_ClientSearch.TabIndex = 0;
            this.lb_ClientSearch.Text = "Search";
            // 
            // lb_ClientStatus
            // 
            this.lb_ClientStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_ClientStatus.AutoSize = true;
            this.lb_ClientStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientStatus.Location = new System.Drawing.Point(3, 64);
            this.lb_ClientStatus.Name = "lb_ClientStatus";
            this.lb_ClientStatus.Size = new System.Drawing.Size(76, 31);
            this.lb_ClientStatus.TabIndex = 11;
            this.lb_ClientStatus.Text = "Status";
            // 
            // cbb_ClientStatus
            // 
            this.cbb_ClientStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_ClientStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_ClientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ClientStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_ClientStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_ClientStatus.FormattingEnabled = true;
            this.cbb_ClientStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbb_ClientStatus.Location = new System.Drawing.Point(104, 60);
            this.cbb_ClientStatus.Name = "cbb_ClientStatus";
            this.cbb_ClientStatus.Size = new System.Drawing.Size(211, 39);
            this.cbb_ClientStatus.TabIndex = 2;
            // 
            // picbx_ClientSearch
            // 
            this.picbx_ClientSearch.Image = global::PBL3REAL.Properties.Resources.search_fluent_color_48px;
            this.picbx_ClientSearch.Location = new System.Drawing.Point(322, 109);
            this.picbx_ClientSearch.Name = "picbx_ClientSearch";
            this.picbx_ClientSearch.Size = new System.Drawing.Size(44, 47);
            this.picbx_ClientSearch.TabIndex = 10;
            this.picbx_ClientSearch.TabStop = false;
            this.picbx_ClientSearch.Click += new System.EventHandler(this.picbx_ClientSearch_Click);
            // 
            // fllaypn_ClientSwitchPage
            // 
            this.fllaypn_ClientSwitchPage.Controls.Add(this.btn_ClientPrevPage);
            this.fllaypn_ClientSwitchPage.Controls.Add(this.tb_ClientPageNumber);
            this.fllaypn_ClientSwitchPage.Controls.Add(this.btn_ClientNextPage);
            this.fllaypn_ClientSwitchPage.Location = new System.Drawing.Point(-3, 213);
            this.fllaypn_ClientSwitchPage.Name = "fllaypn_ClientSwitchPage";
            this.fllaypn_ClientSwitchPage.Size = new System.Drawing.Size(187, 44);
            this.fllaypn_ClientSwitchPage.TabIndex = 0;
            // 
            // btn_ClientPrevPage
            // 
            this.btn_ClientPrevPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ClientPrevPage.FlatAppearance.BorderSize = 0;
            this.btn_ClientPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientPrevPage.Image = global::PBL3REAL.Properties.Resources.prev_fluent_color_48px;
            this.btn_ClientPrevPage.Location = new System.Drawing.Point(0, 0);
            this.btn_ClientPrevPage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ClientPrevPage.Name = "btn_ClientPrevPage";
            this.btn_ClientPrevPage.Size = new System.Drawing.Size(43, 43);
            this.btn_ClientPrevPage.TabIndex = 0;
            this.btn_ClientPrevPage.UseVisualStyleBackColor = true;
            this.btn_ClientPrevPage.Click += new System.EventHandler(this.btn_ClientPrevPage_Click);
            // 
            // tb_ClientPageNumber
            // 
            this.tb_ClientPageNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ClientPageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ClientPageNumber.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientPageNumber.Location = new System.Drawing.Point(43, 2);
            this.tb_ClientPageNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ClientPageNumber.Name = "tb_ClientPageNumber";
            this.tb_ClientPageNumber.Size = new System.Drawing.Size(94, 38);
            this.tb_ClientPageNumber.TabIndex = 0;
            this.tb_ClientPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ClientNextPage
            // 
            this.btn_ClientNextPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ClientNextPage.FlatAppearance.BorderSize = 0;
            this.btn_ClientNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientNextPage.Image = global::PBL3REAL.Properties.Resources.right_button_fluent_color_48px;
            this.btn_ClientNextPage.Location = new System.Drawing.Point(137, 0);
            this.btn_ClientNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ClientNextPage.Name = "btn_ClientNextPage";
            this.btn_ClientNextPage.Size = new System.Drawing.Size(43, 43);
            this.btn_ClientNextPage.TabIndex = 0;
            this.btn_ClientNextPage.UseVisualStyleBackColor = true;
            this.btn_ClientNextPage.Click += new System.EventHandler(this.btn_ClientNextPage_Click);
            // 
            // picbx_ClientRefresh
            // 
            this.picbx_ClientRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picbx_ClientRefresh.Image = global::PBL3REAL.Properties.Resources.refresh_fluent_color_48px;
            this.picbx_ClientRefresh.Location = new System.Drawing.Point(194, 211);
            this.picbx_ClientRefresh.Name = "picbx_ClientRefresh";
            this.picbx_ClientRefresh.Size = new System.Drawing.Size(47, 45);
            this.picbx_ClientRefresh.TabIndex = 16;
            this.picbx_ClientRefresh.TabStop = false;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1299, 788);
            this.Controls.Add(this.tabControl_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Client";
            this.tabControl_Client.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_Client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.fllaypn_ClientButtons.ResumeLayout(false);
            this.tbllaypn_Client.ResumeLayout(false);
            this.tbllaypn_Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientSearch)).EndInit();
            this.fllaypn_ClientSwitchPage.ResumeLayout(false);
            this.fllaypn_ClientSwitchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Client;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.TabPage tabPage_Client;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_ClientButtons;
        private System.Windows.Forms.Button CLIE_VIEW;
        private System.Windows.Forms.Button CLIE_ADD;
        private System.Windows.Forms.Button CLIE_UPDATE;
        private System.Windows.Forms.Button CLIE_INACTIVE;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_Client;
        private System.Windows.Forms.PictureBox picbx_ClientSearch;
        private System.Windows.Forms.PictureBox picbx_ClientSort;
        private System.Windows.Forms.ComboBox cbb_ClientSort;
        private System.Windows.Forms.TextBox tb_ClientSearch;
        private System.Windows.Forms.Label lb_ClientSearch;
        private System.Windows.Forms.Label lb_ClientSort;
        private System.Windows.Forms.Button CLIE_ACTIVE;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_ClientSwitchPage;
        private System.Windows.Forms.Button btn_ClientPrevPage;
        private System.Windows.Forms.TextBox tb_ClientPageNumber;
        private System.Windows.Forms.Button btn_ClientNextPage;
        private System.Windows.Forms.PictureBox picbx_ClientRefresh;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lb_ClientStatus;
        private System.Windows.Forms.ComboBox cbb_ClientStatus;
    }
}