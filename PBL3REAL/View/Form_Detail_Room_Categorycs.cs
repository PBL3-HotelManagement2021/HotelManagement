using HotelManagement.BBL.Implement;
using HotelManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class Form_Detail_Room_Categorycs : Form
    {
        private int idRoomType;
        private RoomTypeBLL roomTypeBLL;
        private RoomTypeVM roomTypeVM;
        public Form_Detail_Room_Categorycs(int idRoomType)
        {
            InitializeComponent();
            this.idRoomType = idRoomType;
            roomTypeBLL = new RoomTypeBLL();
            if (idRoomType != 0) loadData();
            else roomTypeVM = new RoomTypeVM();
        }

        private void loadData()
        {
            roomTypeVM = roomTypeBLL.findbyid(idRoomType);
            textBox1.Text = roomTypeVM.RotyName;
            textBox2.Text = roomTypeVM.RotyDescription;
            textBox3.Text = roomTypeVM.RotyCurrentprice.ToString();
        }

        private void btnoke_Click(object sender, EventArgs e)
        {

        }
    }
}
