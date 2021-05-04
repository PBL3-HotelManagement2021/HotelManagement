using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using System.Windows.Forms;
using HotelManagement.View;
using HotelManagement.BLL.Implement;

namespace PBL3REAL.View
{
    public partial class UserControl_Receptionist_Admin : UserControl
    {
        private RoomBLL roomBLL;
        public UserControl_Receptionist_Admin()
        {

            InitializeComponent();
            roomBLL = new RoomBLL();
        }

     

      

        private void btnshow_Click(object sender, EventArgs e)
        {
            
                dataGridView1.DataSource =roomBLL.getAll(1, 2, 0, "A10");
            dataGridView1.Columns["IdRoom"].Visible = false;
            /*string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;*/

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Form_Detail_Room f = new Form_Detail_Room(0);
            f.Show();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count != 1)
            {
                MessageBox.Show("Please choose only 1 row  !!!");
            }
            else
            {
                int idRoom = Int32.Parse(r[0].Cells["IdRoom"].Value.ToString());
                Form_Detail_Room f = new Form_Detail_Room(idRoom);
                f.Show();
            }
        }
    }
}
