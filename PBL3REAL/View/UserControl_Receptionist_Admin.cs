using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using HotelManagement.View;
using HotelManagement.BLL.Implement;
using HotelManagement.BBL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.ViewModel;
using PBL3REAL.BLL;
namespace PBL3REAL.View
{
    public partial class UserControl_Receptionist_Admin : UserControl
    {
        private RoomBLL roomBLL;
        private RoomTypeBLL roomTypeBLL;
        private QLBookingBLL bookingBLL;
        public UserControl_Receptionist_Admin()
        {
            InitializeComponent();
            roomBLL = new RoomBLL();
            roomTypeBLL = new RoomTypeBLL();
            bookingBLL = new QLBookingBLL();
            LoadBookingList();
            AddCbRoom();
            showRoom(0,"");
            showRoomType();
        }
        //Booking Functions
        private void LoadBookingList()
        {
            dgv_Booking.DataSource = bookingBLL.getAll();
        }
        //Room Functions
        private void showRoom(int idRoomType, string name)
        {
            dgv_Room.DataSource = null;
            dgv_Room.DataSource = roomBLL.getAll(1, 10, idRoomType, name);
            dgv_Room.Columns["IdRoom"].Visible = false;
        }
        private void AddCbRoom()
        {
            //List<CbbItem> list = roomTypeBLL.addCombobox();
            //list.Insert(0, new CbbItem(0, "All RoomType"));
            //List<CbbItem> res = list;
            //cbRoom1.DataSource = res;
        }
        //Romm Type Functions
        private void showRoomType()
        {
            dgv_Booking.DataSource = null;
            dgv_Booking.DataSource = roomTypeBLL.getAll();
            dgv_Booking.Columns["IdRoomtype"].Visible = false;
            /*dataGridView1.Columns["ListImg"].Visible = false;*/
        }
        //Booking Events
        private void btn_BookingView_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_Booking.SelectedRows;
            if (r.Count == 1)
            {
                Form_Booking f = new Form_Booking(int.Parse(r[0].Cells["IdBook"].Value.ToString()),false);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn để xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                MessageBox.Show("Chỉ có thể chọn một đơn trong một lần xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_BookingAdd_Click(object sender, EventArgs e)
        {
            Form_Booking f = new Form_Booking(0,true);
            this.Hide();
            f.ShowDialog();
            this.Show();
            //Reload Data
        }
        private void btn_BookingEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_Booking.SelectedRows;
            if (r.Count == 1)
            {
                Form_Booking f = new Form_Booking(int.Parse(r[0].Cells["IdBook"].Value.ToString()),true);
                this.Hide();
                f.ShowDialog();
                this.Show();
                //Reload Data
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chỉ có thể chọn một đơn trong một lần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_BookingDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_Booking.SelectedRows;
            if (r.Count == 1)
            {
                bookingBLL.delBooking(int.Parse(r[0].Cells["IdBook"].Value.ToString()),r[0].Cells["BookStatus"].Value.ToString());
                //Reload Data
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chỉ có thể chọn một đơn trong một lần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Room Events

        //Room Type Events
    }
}
