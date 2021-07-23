using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
using PBL3REAL.Extention;

namespace PBL3REAL.View
{
    public partial class Form_Detail_Client : Form
    {
        //---------- GLOBAL DECLARATION ----------//
        //----- Delegation -----//
        public delegate void MyDel();
        public MyDel myDel;

        //----- User Instance Variables -----//
        private ClientVM clientVM;
        private ClientBLL clientBLL;
        private int id;
        private bool Editable_Cli;

        //---------- FORM CONSTRUCTOR ----------//
        public Form_Detail_Client(int ID, bool Editable)
        {
            //--- Initialize ----//
            InitializeComponent();
            id = ID;
            clientBLL = new ClientBLL();
            Editable_Cli = Editable;

            //--- Load Data ----//
            LoadData();   
        }

        //---------- FUNCTIONS ----------//
        //----- Load Data -----//
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
                tb_ClientCode.Text = clientVM.Code;
                tb_ClientEmail.Text = clientVM.Gmail;
                tb_ClientName.Text = clientVM.Name;
                tb_ClientPhone.Text = clientVM.Phone;
                tb_ClientCode.Enabled = false;
            }
            if (!Editable_Cli)
            {
                tbllaypn_Client.Enabled = false;
                btn_OK.Enabled = false;
                btn_Reset.Enabled = false;
            }
        }

        //---------- EVENTS ----------//
        //----- tbllaypn_ControlButtons -----//
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (Email.ValidateEmail(tb_ClientEmail.Text) == false || PhoneNumber.IsValidPhoneNumber(tb_ClientPhone.Text) == false) 
            {
                MessageBox.Show("Invalid Email or Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("gmail", tb_ClientEmail.Text);
            properties.Add("phone", tb_ClientPhone.Text);
            properties.Add("code", tb_ClientCode.Text);
            if (clientBLL.checkexisted(properties))
            {
                clientVM.Gmail = tb_ClientEmail.Text;
                clientVM.Name = tb_ClientName.Text;
                clientVM.Phone = tb_ClientPhone.Text;
                if (id == 0)
                {
                    //Add
                    clientBLL.add(clientVM);
                    MessageBox.Show("Your client has been successfully created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myDel();
                    this.Dispose();
                }
                else
                {
                    clientBLL.update(clientVM);
                    MessageBox.Show("Your client has been successfully updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myDel();
                    this.Dispose();
                }
              
            }
            else
            {
                MessageBox.Show("Phone or Email has existed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset Data
            tb_ClientEmail.Text = clientVM.Gmail;
            tb_ClientName.Text = clientVM.Name;
            tb_ClientPhone.Text = clientVM.Phone;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
