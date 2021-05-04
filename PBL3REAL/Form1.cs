using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3REAL
{
    public partial class Form1 : Form
    {
        private RoomTypeBLL roomTypeBLL;
        private RoomBLL roomBLL;
        public Form1()
        {
            InitializeComponent();
            roomTypeBLL = new RoomTypeBLL();
            roomBLL = new RoomBLL();
            updateRoom();
        }

        public void showroomtype()
        {
            List<RoomTypeVM> listVM = roomTypeBLL.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void updateRoom()
        {
            RoomVM roomVM = roomBLL.getAll(1, 2, "hello")[0];
            roomVM.RoomName = "PROROOOM";
            //edit status time
            roomVM.ListStatusTime[1].StatimTodate = Convert.ToDateTime("01/10/2021");

            //add Status time
            /*  StatusVM statusVM = new StatusVM();
              statusVM.IdStatus = 1;
              StatusTimeVM statusTimeVM = new StatusTimeVM();
              //statusTimeVM.IdStatim = 4; //gia su minh sua lai thong tin tk status_time da co trong db
              statusTimeVM.StatimFromdate = DateTime.Now;
              statusTimeVM.StatimTodate = Convert.ToDateTime("12/12/2021");
              statusTimeVM.statusVM = statusVM;
              roomVM.ListStatusTime.Add(statusTimeVM);*/

            //del sattus time
            // List<int>listdel = new List<int>();
            // listdel.Add(3);
            roomBLL.editRoom(roomVM, null);
        }
        public void showRoom()
        {
            List<RoomVM> listVM = roomBLL.getAll(1,2,"hell");
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
       /* public void addRoomType()
        {
            RoomTypeVM roomTypeVM = new RoomTypeVM
            {
                RotyCapacity = 3,
                RotyCurrentprice = 10000,
                RotyDescription = "ko co",
                RotyName = "Cuongpor",
                Map
                
            };
            roomTypeVM.RotyCapacity = 3;
            RoomTypeBLL.Instance.editRoomType(roomTypeVM);
        }*/
    }
}
