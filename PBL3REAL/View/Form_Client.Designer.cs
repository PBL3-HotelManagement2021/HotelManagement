
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
            this.tabControl_Client = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.btn_Home = new System.Windows.Forms.Button();
            this.tabPage_Client = new System.Windows.Forms.TabPage();
            this.dgv_Client = new System.Windows.Forms.DataGridView();
            this.fllaypn_ClientButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ClientView = new System.Windows.Forms.Button();
            this.btn_ClientAdd = new System.Windows.Forms.Button();
            this.btn_ClientEdit = new System.Windows.Forms.Button();
            this.btn_ClientDelete = new System.Windows.Forms.Button();
            this.tbllaypn_Client = new System.Windows.Forms.TableLayoutPanel();
            this.picbx_ClientSearch = new System.Windows.Forms.PictureBox();
            this.picbx_ClientSort = new System.Windows.Forms.PictureBox();
            this.cbb_ClientSort = new System.Windows.Forms.ComboBox();
            this.tb_ClientSearch = new System.Windows.Forms.TextBox();
            this.lb_ClientSearch = new System.Windows.Forms.Label();
            this.lb_ClientSort = new System.Windows.Forms.Label();
            this.tabControl_Client.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.tabPage_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).BeginInit();
            this.fllaypn_ClientButtons.SuspendLayout();
            this.tbllaypn_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientSort)).BeginInit();
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
            this.tabControl_Client.Size = new System.Drawing.Size(1152, 807);
            this.tabControl_Client.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(this.btn_Home);
            this.tabPage_General.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_General.Location = new System.Drawing.Point(4, 37);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(1144, 766);
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
            this.btn_Home.Location = new System.Drawing.Point(377, 262);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(194, 183);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Return Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // tabPage_Client
            // 
            this.tabPage_Client.Controls.Add(this.dgv_Client);
            this.tabPage_Client.Controls.Add(this.fllaypn_ClientButtons);
            this.tabPage_Client.Controls.Add(this.tbllaypn_Client);
            this.tabPage_Client.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_Client.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Client.Name = "tabPage_Client";
            this.tabPage_Client.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Client.Size = new System.Drawing.Size(1144, 766);
            this.tabPage_Client.TabIndex = 1;
            this.tabPage_Client.Text = "Quản lí Client";
            this.tabPage_Client.UseVisualStyleBackColor = true;
            // 
            // dgv_Client
            // 
            this.dgv_Client.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Client.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv_Client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Client.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Client.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Client.ColumnHeadersVisible = false;
            this.dgv_Client.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv_Client.Location = new System.Drawing.Point(0, 273);
            this.dgv_Client.Name = "dgv_Client";
            this.dgv_Client.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Client.RowHeadersWidth = 51;
            this.dgv_Client.RowTemplate.Height = 29;
            this.dgv_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Client.Size = new System.Drawing.Size(1144, 493);
            this.dgv_Client.TabIndex = 0;
            // 
            // fllaypn_ClientButtons
            // 
            this.fllaypn_ClientButtons.Controls.Add(this.btn_ClientView);
            this.fllaypn_ClientButtons.Controls.Add(this.btn_ClientAdd);
            this.fllaypn_ClientButtons.Controls.Add(this.btn_ClientEdit);
            this.fllaypn_ClientButtons.Controls.Add(this.btn_ClientDelete);
            this.fllaypn_ClientButtons.Location = new System.Drawing.Point(449, 3);
            this.fllaypn_ClientButtons.Name = "fllaypn_ClientButtons";
            this.fllaypn_ClientButtons.Size = new System.Drawing.Size(656, 207);
            this.fllaypn_ClientButtons.TabIndex = 0;
            // 
            // btn_ClientView
            // 
            this.btn_ClientView.FlatAppearance.BorderSize = 0;
            this.btn_ClientView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientView.Image = global::PBL3REAL.Properties.Resources.show_property_96px;
            this.btn_ClientView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ClientView.Location = new System.Drawing.Point(3, 3);
            this.btn_ClientView.Name = "btn_ClientView";
            this.btn_ClientView.Size = new System.Drawing.Size(158, 199);
            this.btn_ClientView.TabIndex = 0;
            this.btn_ClientView.Text = "Xem thông tin client đã chọn";
            this.btn_ClientView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ClientView.UseVisualStyleBackColor = true;
            // 
            // btn_ClientAdd
            // 
            this.btn_ClientAdd.FlatAppearance.BorderSize = 0;
            this.btn_ClientAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientAdd.Image = global::PBL3REAL.Properties.Resources.add_fluent_color_96px;
            this.btn_ClientAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ClientAdd.Location = new System.Drawing.Point(167, 3);
            this.btn_ClientAdd.Name = "btn_ClientAdd";
            this.btn_ClientAdd.Size = new System.Drawing.Size(158, 199);
            this.btn_ClientAdd.TabIndex = 0;
            this.btn_ClientAdd.Text = "Thêm client mới";
            this.btn_ClientAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ClientAdd.UseVisualStyleBackColor = true;
            // 
            // btn_ClientEdit
            // 
            this.btn_ClientEdit.FlatAppearance.BorderSize = 0;
            this.btn_ClientEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientEdit.Image = global::PBL3REAL.Properties.Resources.edit_property_fluent_color_96px;
            this.btn_ClientEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ClientEdit.Location = new System.Drawing.Point(331, 3);
            this.btn_ClientEdit.Name = "btn_ClientEdit";
            this.btn_ClientEdit.Size = new System.Drawing.Size(158, 199);
            this.btn_ClientEdit.TabIndex = 0;
            this.btn_ClientEdit.Text = "Chỉnh sửa thông tin client đã chọn";
            this.btn_ClientEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ClientEdit.UseVisualStyleBackColor = true;
            // 
            // btn_ClientDelete
            // 
            this.btn_ClientDelete.FlatAppearance.BorderSize = 0;
            this.btn_ClientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientDelete.Image = global::PBL3REAL.Properties.Resources.waste_fluent_color_96px;
            this.btn_ClientDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ClientDelete.Location = new System.Drawing.Point(495, 3);
            this.btn_ClientDelete.Name = "btn_ClientDelete";
            this.btn_ClientDelete.Size = new System.Drawing.Size(158, 199);
            this.btn_ClientDelete.TabIndex = 0;
            this.btn_ClientDelete.Text = "Xóa client đã chọn";
            this.btn_ClientDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ClientDelete.UseVisualStyleBackColor = true;
            // 
            // tbllaypn_Client
            // 
            this.tbllaypn_Client.ColumnCount = 3;
            this.tbllaypn_Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.30407F));
            this.tbllaypn_Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.69593F));
            this.tbllaypn_Client.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tbllaypn_Client.Controls.Add(this.picbx_ClientSearch, 2, 1);
            this.tbllaypn_Client.Controls.Add(this.picbx_ClientSort, 2, 0);
            this.tbllaypn_Client.Controls.Add(this.cbb_ClientSort, 1, 0);
            this.tbllaypn_Client.Controls.Add(this.tb_ClientSearch, 1, 1);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientSearch, 0, 1);
            this.tbllaypn_Client.Controls.Add(this.lb_ClientSort, 0, 0);
            this.tbllaypn_Client.Location = new System.Drawing.Point(12, 26);
            this.tbllaypn_Client.Name = "tbllaypn_Client";
            this.tbllaypn_Client.RowCount = 2;
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Client.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_Client.Size = new System.Drawing.Size(386, 111);
            this.tbllaypn_Client.TabIndex = 0;
            // 
            // picbx_ClientSearch
            // 
            this.picbx_ClientSearch.Image = global::PBL3REAL.Properties.Resources.search_fluent_color_48px;
            this.picbx_ClientSearch.Location = new System.Drawing.Point(336, 58);
            this.picbx_ClientSearch.Name = "picbx_ClientSearch";
            this.picbx_ClientSearch.Size = new System.Drawing.Size(47, 48);
            this.picbx_ClientSearch.TabIndex = 10;
            this.picbx_ClientSearch.TabStop = false;
            // 
            // picbx_ClientSort
            // 
            this.picbx_ClientSort.Image = global::PBL3REAL.Properties.Resources.filter_fluent_color_48px;
            this.picbx_ClientSort.Location = new System.Drawing.Point(336, 3);
            this.picbx_ClientSort.Name = "picbx_ClientSort";
            this.picbx_ClientSort.Size = new System.Drawing.Size(47, 48);
            this.picbx_ClientSort.TabIndex = 9;
            this.picbx_ClientSort.TabStop = false;
            // 
            // cbb_ClientSort
            // 
            this.cbb_ClientSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_ClientSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_ClientSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ClientSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_ClientSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_ClientSort.FormattingEnabled = true;
            this.cbb_ClientSort.Location = new System.Drawing.Point(127, 3);
            this.cbb_ClientSort.Name = "cbb_ClientSort";
            this.cbb_ClientSort.Size = new System.Drawing.Size(203, 39);
            this.cbb_ClientSort.TabIndex = 0;
            // 
            // tb_ClientSearch
            // 
            this.tb_ClientSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_ClientSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ClientSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ClientSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ClientSearch.Location = new System.Drawing.Point(127, 58);
            this.tb_ClientSearch.Name = "tb_ClientSearch";
            this.tb_ClientSearch.Size = new System.Drawing.Size(203, 31);
            this.tb_ClientSearch.TabIndex = 0;
            // 
            // lb_ClientSearch
            // 
            this.lb_ClientSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ClientSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientSearch.Location = new System.Drawing.Point(3, 55);
            this.lb_ClientSearch.Name = "lb_ClientSearch";
            this.lb_ClientSearch.Size = new System.Drawing.Size(118, 56);
            this.lb_ClientSearch.TabIndex = 0;
            this.lb_ClientSearch.Text = "Tìm kiếm";
            // 
            // lb_ClientSort
            // 
            this.lb_ClientSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ClientSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ClientSort.Location = new System.Drawing.Point(3, 0);
            this.lb_ClientSort.Name = "lb_ClientSort";
            this.lb_ClientSort.Size = new System.Drawing.Size(118, 55);
            this.lb_ClientSort.TabIndex = 0;
            this.lb_ClientSort.Text = "Sắp xếp theo";
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1151, 807);
            this.Controls.Add(this.tabControl_Client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Client";
            this.tabControl_Client.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_Client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).EndInit();
            this.fllaypn_ClientButtons.ResumeLayout(false);
            this.tbllaypn_Client.ResumeLayout(false);
            this.tbllaypn_Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ClientSort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Client;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.TabPage tabPage_Client;
        private System.Windows.Forms.DataGridView dgv_Client;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_ClientButtons;
        private System.Windows.Forms.Button btn_ClientView;
        private System.Windows.Forms.Button btn_ClientAdd;
        private System.Windows.Forms.Button btn_ClientEdit;
        private System.Windows.Forms.Button btn_ClientDelete;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_Client;
        private System.Windows.Forms.PictureBox picbx_ClientSearch;
        private System.Windows.Forms.PictureBox picbx_ClientSort;
        private System.Windows.Forms.ComboBox cbb_ClientSort;
        private System.Windows.Forms.TextBox tb_ClientSearch;
        private System.Windows.Forms.Label lb_ClientSearch;
        private System.Windows.Forms.Label lb_ClientSort;
    }
}