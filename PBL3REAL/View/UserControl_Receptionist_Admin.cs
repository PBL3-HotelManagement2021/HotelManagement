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
            addCbRoom1();
        }
        private void showRoom(int idRoomType, string name)
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = roomBLL.getAll(1, 10, idRoomType, name);
            dataGridView1.Columns["IdRoom"].Visible = false;
        }
        private void addCbRoom1()
        {
            List<CbbItem> list = roomTypeBLL.addCombobox();
            list.Insert(0, new CbbItem(0, "All RoomType"));
            List<CbbItem> res = list;
            cbRoom1.DataSource = res;
        }
        private void showRoomType()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = roomTypeBLL.getAll();
            dataGridView2.Columns["IdRoomtype"].Visible = false;
            /*dataGridView1.Columns["ListImg"].Visible = false;*/
        }

    }
}
