using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3REAL.View
{
    public partial class Form_Detail_Client : Form
    {
        private int id;
        private bool Editable_Cli;
        private ClientVM clientVM;
        private ClientBLL clientBLL; 
        public Form_Detail_Client(int ID, bool Editable)
        {
            InitializeComponent();
            id = ID;
            clientBLL = new ClientBLL();
            Editable_Cli = Editable;
            LoadData();   
        }
        //Load Data Functions
        private void LoadData()
        {
            if (id == 0)
            {
                //Add
                clientVM = new ClientVM();
                tb_ClientCode.Enabled = false;
            }    
            else
            {
                //View or Edit
                clientVM = clientBLL.findById(id);
                tb_ClientCode.Text = clientVM.CliCode;
                tb_ClientEmail.Text = clientVM.CliGmail;
                tb_ClientName.Text = clientVM.CliName;
                tb_ClientPhone.Text = clientVM.CliPhone;
                tb_ClientCode.Enabled = false;
            }
            if (!Editable_Cli)
            {
                tbllaypn_Client.Enabled = false;
                btn_OK.Enabled = false;
                btn_Reset.Enabled = false;
            }
        }
        //Check Data Function
        private void CheckData()
        {

        }
        //Events
        private void btn_OK_Click(object sender, EventArgs e)
        {
            clientVM.CliGmail = tb_ClientEmail.Text;
            clientVM.CliName = tb_ClientName.Text;
            clientVM.CliPhone = tb_ClientPhone.Text;
            if (id == 0)
            {
                //Add
                clientBLL.add(clientVM);
                MessageBox.Show("Thêm mới khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                clientBLL.update(clientVM);
                MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Dispose();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset Data
            tb_ClientEmail.Text = "";
            tb_ClientName.Text = "";
            tb_ClientPhone.Text = "";
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
