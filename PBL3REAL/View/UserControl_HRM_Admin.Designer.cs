
namespace PBL3REAL.View
{
    partial class UserControl_HRM_Admin
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
            this.tabControl_HRM = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.tabPage_HRM = new System.Windows.Forms.TabPage();
            this.tabControl_HRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_HRM
            // 
            this.tabControl_HRM.Controls.Add(this.tabPage_General);
            this.tabControl_HRM.Controls.Add(this.tabPage_HRM);
            this.tabControl_HRM.Location = new System.Drawing.Point(0, 0);
            this.tabControl_HRM.Name = "tabControl_HRM";
            this.tabControl_HRM.SelectedIndex = 0;
            this.tabControl_HRM.Size = new System.Drawing.Size(945, 804);
            this.tabControl_HRM.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_General.Location = new System.Drawing.Point(4, 29);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(937, 771);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "Chung";
            this.tabPage_General.UseVisualStyleBackColor = true;
            // 
            // tabPage_HRM
            // 
            this.tabPage_HRM.Location = new System.Drawing.Point(4, 29);
            this.tabPage_HRM.Name = "tabPage_HRM";
            this.tabPage_HRM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HRM.Size = new System.Drawing.Size(937, 771);
            this.tabPage_HRM.TabIndex = 1;
            this.tabPage_HRM.Text = "Quản lí nhân sự";
            this.tabPage_HRM.UseVisualStyleBackColor = true;
            // 
            // UserControl_HRM_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_HRM);
            this.Name = "UserControl_HRM_Admin";
            this.Size = new System.Drawing.Size(945, 804);
            this.tabControl_HRM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_HRM;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TabPage tabPage_HRM;
    }
}
