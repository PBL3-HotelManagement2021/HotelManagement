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
using HotelManagement.BBL.Implement;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class UserControl_Receptionist_Admin : UserControl
    {
        private RoomBLL roomBLL;
        private RoomTypeBLL roomTypeBLL;
        public UserControl_Receptionist_Admin()
        {

            InitializeComponent();
            roomBLL = new RoomBLL();
            roomTypeBLL = new RoomTypeBLL();
            //addCbRoom1();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //private void showRoom(int idRoomType, string name)
        //{
        //    dataGridView1.DataSource = null;

        //    dataGridView1.DataSource = roomBLL.getAll(1, 10, idRoomType, name);
        //    dataGridView1.Columns["IdRoom"].Visible = false;
        //}

        //private void btnshow_Click(object sender, EventArgs e)
        //{
        //    int idRoomType = ((CbbItem)cbRoom1.SelectedItem).Value;
        //    string name = searchRoom.Text;
        //    showRoom(idRoomType, name);
        //    /*string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
        //    richTextBox1.Text = json;*/

        //}
        //private void addCbRoom1()
        //{
        //    List<CbbItem> list = roomTypeBLL.addCombobox();
        //    list.Insert(0, new CbbItem(0, "All RoomType"));
        //    List<CbbItem> res = list;
        //    cbRoom1.DataSource = res;
        //}
        //private void btnadd_Click(object sender, EventArgs e)
        //{
        //    Form_Detail_Room f = new Form_Detail_Room(0);
        //    f.Show();
        //}

        //private void btnedit_Click(object sender, EventArgs e)
        //{
        //    DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
        //    if (r.Count != 1)
        //    {
        //        MessageBox.Show("Please choose only 1 row  !!!");
        //    }
        //    else
        //    {
        //        int idRoom = Int32.Parse(r[0].Cells["IdRoom"].Value.ToString());
        //        Form_Detail_Room f = new Form_Detail_Room(idRoom);
        //        f.Show();
        //    }
        //}

        //private void btndelete_Click(object sender, EventArgs e)
        //{
        //    DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
        //    if (r.Count == 0)
        //    {
        //        MessageBox.Show("Please choose rows  !!!");
        //    }
        //    else
        //    {
        //        List<int> listdel = new List<int>();
        //        foreach (DataGridViewRow val in r)
        //        {
        //            listdel.Add(Int32.Parse(val.Cells["IdRoom"].Value.ToString()));
        //        }
        //        try
        //        {
        //            roomBLL.deleteRoom(listdel);
        //            showRoom(0, "");
        //        }
        //        catch (Exception mes)
        //        {
        //            MessageBox.Show(mes.Message);
        //        }

        //    }
        //}

        //private void showRoomType()
        //{
        //    dataGridView2.DataSource = null;
        //    dataGridView2.DataSource = roomTypeBLL.getAll();
        //    dataGridView2.Columns["IdRoomtype"].Visible = false;
        //    /*dataGridView1.Columns["ListImg"].Visible = false;*/
        //}
        //private void btnroty_show_Click(object sender, EventArgs e)
        //{
        //    showRoomType();
        //}

        //private void btnroty_add_Click(object sender, EventArgs e)
        //{
        //    Form f = new Form_Detail_Room_Categorycs(0);
        //    f.Show();
        //}

        //private void btnroty_edit_Click(object sender, EventArgs e)
        //{

        //    DataGridViewSelectedRowCollection r = dataGridView2.SelectedRows;
        //    if (r.Count != 1)
        //    {
        //        MessageBox.Show("Please choose only 1 row  !!!");
        //    }
        //    else
        //    {
        //        int idRoomType = Int32.Parse(r[0].Cells["IdRoom"].Value.ToString());
        //        Form f = new Form_Detail_Room_Categorycs(idRoomType);
        //        f.Show();

        //    }
        //}
    }
}
