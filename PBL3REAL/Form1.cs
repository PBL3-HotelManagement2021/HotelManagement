using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using PBL3REAL.ViewModel;
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
            //   findidRoom();
            // addRoomType();
            // deleteRoomType();
            editRoomType();
        }

        public void showroomtype()
        {
            List<RoomTypeVM> listVM = roomTypeBLL.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void addRoom()
        {
            RoomDetailVM roomDetailVM = new RoomDetailVM
            {
                RoomName = "Cuongpr",
                RotyCurrentprice = 2000000,
                RoomDescription = "ko co"
            };
            roomDetailVM.MapRoomtype.Add(1, "single room");
            StatusTimeVM statusTimeVM1 = new StatusTimeVM
            {
                StatimFromdate = DateTime.Now,
                StatimTodate = Convert.ToDateTime("01/10/2022"),
            };
            statusTimeVM1.statusVM = new StatusVM
            {
                IdStatus = 1
            };
            roomDetailVM.ListStatusTime.Add(statusTimeVM1);

            StatusTimeVM statusTimeVM2 = new StatusTimeVM
            {
                StatimFromdate = DateTime.Now,
                StatimTodate = Convert.ToDateTime("01/12/2021"),
            };
            statusTimeVM2.statusVM = new StatusVM
            {
                IdStatus = 2
            };
            roomDetailVM.ListStatusTime.Add(statusTimeVM2);
            roomBLL.addRoom(roomDetailVM);
        }
        public void findidRoom()
        {
            RoomDetailVM roomDetailVM = roomBLL.findByID(1);
            string json = JsonConvert.SerializeObject(roomDetailVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void deleteRoom()
        {
            int id = 7;
            roomBLL.deleteRoom(id);
        }
        public void updateRoom()
        {
            RoomDetailVM roomDetailVM = roomBLL.findByID(1);
            roomDetailVM.RoomName = "PROROOOM";
            //edit status time
            roomDetailVM.ListStatusTime[1].StatimTodate = Convert.ToDateTime("01/10/2021");

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
            roomBLL.editRoom(roomDetailVM, null);
        }
        public void showRoom()
        {
            List<RoomVM> listVM = roomBLL.getAll(1,2,0,"A10");
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void addRoomType()
        {
            RoomTypeVM roomTypeVM = new RoomTypeVM
            {
                RotyCapacity = 3,
                RotyCurrentprice = 10000,
                RotyDescription = "ko co",
                RotyName = "Cuongpor",
            };
            ImageVM image1 = new ImageVM
            {
                ImgstoUrl = "home/cuong/yessss"
        };
            roomTypeVM.ListImg.Add(image1);
            ImageVM image2 = new ImageVM
            {
                ImgstoUrl = "home/cuong/nooooo"
            };
            roomTypeVM.ListImg.Add(image2);
            roomTypeBLL.addRoomType(roomTypeVM);
        }
        public void editRoomType()
        {
            RoomTypeVM roomTypeVM = roomTypeBLL.findbyid(1);
            roomTypeVM.RotyCapacity = 4;
            List<int> listdel = new List<int>();
            ImageVM imageVM1 = roomTypeVM.ListImg[1];
            listdel.Add(imageVM1.IdImgsto);
            roomTypeVM.ListImg.Remove(imageVM1);
            ImageVM imageVM = new ImageVM
            {
                ImgstoUrl = "/home/cuong/oke"
            };
            roomTypeVM.ListImg.Add(imageVM);
            roomTypeBLL.editRoomType(roomTypeVM,listdel);
         }
        public void deleteRoomType()
        {
            roomTypeBLL.deleteRoomType(7);
        }
    }
}
