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
        private int ID_Cli;
        private bool Editable_Cli;
        public Form_Detail_Client(int ID, bool Editable)
        {
            InitializeComponent();
            ID_Cli = ID;
            Editable_Cli = Editable;
        }
        //Load Data Functions
        private void LoadData()
        {
            if (ID_Cli == 0)
            {
                //Add
            }    
            else
            {
                //View or Edit
            }
            if (!Editable_Cli)
            {
                tbllaypn_Client.Enabled = false;
                btn_OK.Enabled = false;
                btn_Reset.Enabled = false;
            }
        }
        //Events
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ID_Cli == 0)
            {
                //Add
            }    
            else
            {
                //Edit
            }    
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset Data
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
