
namespace PBL3REAL.View
{
    partial class UserControl_Accountant_Admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Accountant = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
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
            this.tabControl_Accountant.SuspendLayout();
            this.tabPage_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).BeginInit();
            this.fllaypn_InvoiceButtons.SuspendLayout();
            this.tbllaypn_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSort)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Accountant
            // 
            this.tabControl_Accountant.Controls.Add(this.tabPage_General);
            this.tabControl_Accountant.Controls.Add(this.tabPage_Invoice);
            this.tabControl_Accountant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl_Accountant.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Accountant.Name = "tabControl_Accountant";
            this.tabControl_Accountant.SelectedIndex = 0;
            this.tabControl_Accountant.Size = new System.Drawing.Size(993, 692);
            this.tabControl_Accountant.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_General.Location = new System.Drawing.Point(4, 37);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(830, 763);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "Chung";
            this.tabPage_General.UseVisualStyleBackColor = true;
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
            this.tabPage_Invoice.Size = new System.Drawing.Size(985, 651);
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
            this.dgv_Invoice.Location = new System.Drawing.Point(3, 159);
            this.dgv_Invoice.Name = "dgv_Invoice";
            this.dgv_Invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Invoice.RowHeadersWidth = 51;
            this.dgv_Invoice.RowTemplate.Height = 29;
            this.dgv_Invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Invoice.Size = new System.Drawing.Size(979, 486);
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
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.06097F));
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.93903F));
            this.tbllaypn_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
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
            this.picbx_InvoiceSearch.Location = new System.Drawing.Point(325, 58);
            this.picbx_InvoiceSearch.Name = "picbx_InvoiceSearch";
            this.picbx_InvoiceSearch.Size = new System.Drawing.Size(48, 48);
            this.picbx_InvoiceSearch.TabIndex = 10;
            this.picbx_InvoiceSearch.TabStop = false;
            // 
            // picbx_InvoiceSort
            // 
            this.picbx_InvoiceSort.Image = global::PBL3REAL.Properties.Resources.filter_fluent_color_48px;
            this.picbx_InvoiceSort.Location = new System.Drawing.Point(325, 3);
            this.picbx_InvoiceSort.Name = "picbx_InvoiceSort";
            this.picbx_InvoiceSort.Size = new System.Drawing.Size(48, 48);
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
            this.cbb_InvoiceSort.Location = new System.Drawing.Point(116, 3);
            this.cbb_InvoiceSort.Name = "cbb_InvoiceSort";
            this.cbb_InvoiceSort.Size = new System.Drawing.Size(203, 39);
            this.cbb_InvoiceSort.TabIndex = 0;
            // 
            // tb_InvoiceSearch
            // 
            this.tb_InvoiceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_InvoiceSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_InvoiceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_InvoiceSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_InvoiceSearch.Location = new System.Drawing.Point(116, 58);
            this.tb_InvoiceSearch.Name = "tb_InvoiceSearch";
            this.tb_InvoiceSearch.Size = new System.Drawing.Size(203, 31);
            this.tb_InvoiceSearch.TabIndex = 0;
            // 
            // lb_InvoiceSearch
            // 
            this.lb_InvoiceSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_InvoiceSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceSearch.Location = new System.Drawing.Point(3, 55);
            this.lb_InvoiceSearch.Name = "lb_InvoiceSearch";
            this.lb_InvoiceSearch.Size = new System.Drawing.Size(107, 56);
            this.lb_InvoiceSearch.TabIndex = 0;
            this.lb_InvoiceSearch.Text = "Tìm kiếm";
            // 
            // lb_InvoiceSort
            // 
            this.lb_InvoiceSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_InvoiceSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_InvoiceSort.Location = new System.Drawing.Point(3, 0);
            this.lb_InvoiceSort.Name = "lb_InvoiceSort";
            this.lb_InvoiceSort.Size = new System.Drawing.Size(107, 55);
            this.lb_InvoiceSort.TabIndex = 0;
            this.lb_InvoiceSort.Text = "Sắp xếp theo";
            // 
            // UserControl_Accountant_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_Accountant);
            this.Name = "UserControl_Accountant_Admin";
            this.Size = new System.Drawing.Size(989, 690);
            this.tabControl_Accountant.ResumeLayout(false);
            this.tabPage_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).EndInit();
            this.fllaypn_InvoiceButtons.ResumeLayout(false);
            this.tbllaypn_Invoice.ResumeLayout(false);
            this.tbllaypn_Invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_InvoiceSort)).EndInit();
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
    }
}
