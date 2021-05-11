﻿using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.Model;
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
        private BookingBLL bookingBLL;
        private ClientDAL clientDAL;
        private ClientBLL clientBLL;
        private UserBLL userBLL;
        public Form1()
        {
            InitializeComponent();
            roomTypeBLL = new RoomTypeBLL();
            roomBLL = new RoomBLL();
            bookingBLL = new BookingBLL();
            clientDAL = new ClientDAL();
            clientBLL = new ClientBLL();
            userBLL = new UserBLL();
            PaginationRoom();
            //   findidRoom();
            // addRoomType();
            // deleteRoomType();
            /*editRoomType();*/
            // showClient();
            testCBBRoom();
            //  showBookingDetail();
            //   addBooking();
            //delBooking();
            // addClient();
            //showUser();
            //   addUser();
            //completeBooking();
            checkUser();
        }

        //  PHAN USER (ADMIN ,RECEPTIONIST,...)
        
        //show tat ca user
        public void showUser()
        {
            List<UserVM> listVM = userBLL.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void delUser()
        {
            userBLL.delUser(6);
        }
        public void checkUser()
        {
            
            UserVM userVM = userBLL.checkUser("PVC20001","phanvancuong2001");
            string json = JsonConvert.SerializeObject(userVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void addUser()
        {
            UserVM userVM = userBLL.getAll()[0];
            userVM.IdUser = 0;
            userVM.UserCode = "PhanTest";
            userVM.ListRole.RemoveAt(0);
            userVM.ListImg.Clear();
            ImageVM imageVM = new ImageVM
            {
                ImgstoUrl = "/home/cuong/pro/vip/dangcap"
            };
            userVM.ListImg.Add(imageVM);
            userBLL.addUser(userVM);
        }
      

        //  PHAN CLIENT
        public void showClient()
        {
            List<Client> listVM = clientDAL.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
        public void addClient()
        {
            ClientVM clientVM = new ClientVM
            {
                CliCode = "asdfgqwe",
                CliGmail = "cuonggggggg@",
                CliName = "Hello",
                CliPhone = "0912345678"
            };
         
            clientBLL.add(clientVM);
        }

        ///     PHAN BOOKING

        ///tk nay se goi khi client ts lay phong khach san ,luc do le tan bam nut check --->hoan tat thu tuc booking
        ///Luu y khi complete xong thi ko con chuc nang update nx (unable di)
        public void completeBooking()
        {
            bookingBLL.completeBooking(2);
        }

        public void delBooking()
        {
            bookingBLL.delBooking(19);
        }

        public void addBooking()
        {
            SubBookingDetailVM sub = new SubBookingDetailVM
            {
                BooDetNote = "None",
                BoodetPrice =1000000,
                BoodetIdroom =1
            };
            
            BookingDetailVM result = new BookingDetailVM
            {
                BookNote = "Ko bk",
                BookCheckindate = DateTime.Now,
                BookPaymentdate = DateTime.Now,
                BookBookdate = DateTime.Now,
                BookStatus = "Proccess",
                BookTotalprice = 10000000,
                BookDeposit = 20000,
                clientVM = new ClientVM
                {
                    CliCode = "PROVIP01",
                    CliName = "dadsa",
                    CliGmail = "dasdasdas",
                    CliPhone = "0981234567"
                }
            };
            result.ListSub.Add(sub);
            bookingBLL.addBooking(result);
        }

        //cai ni dung de show bang chi tiet cua booking 
        public void showBookingDetail()
        {
           BookingDetailVM result = bookingBLL.getDetail(1);
            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            richTextBox1.Text = json;
        }

        //cai ni show ra tat ca booking cho dataGridView
        public void showBooking()
        {
            List<BookingVM> listVM = bookingBLL.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }

        //2 cai combobox ni cho roomtype va room ,o day combobox ta truyen vao RoomTypeVM va RoomVM
        public void testCBB()
        {
            comboBox1.DataSource = roomTypeBLL.getAll();
            comboBox1.DisplayMember = "RotyName";
        }
        public void testCBBRoom()
        {

            comboBox2.DataSource = roomBLL.findAvailableRoom(1, Convert.ToDateTime("2021-03-01"), Convert.ToDateTime("2021-03-08"));
            comboBox2.DisplayMember = "RoomName";
        }


        ///     PHAN ROOMTYPE
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
           /* roomDetailVM.MapRoomtype.Add(1, "single room");*/
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
     /*   public void deleteRoom()
        {
            int id = 7;
            roomBLL.deleteRoom(id);
        }*/
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

        public void PaginationRoom()
        {
            textBox1.Text = roomBLL.getPagination().ToString();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((RoomTypeVM)comboBox1.SelectedItem).RotyCurrentprice.ToString();
        }

       
    }
}