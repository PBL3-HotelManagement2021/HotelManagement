using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.DAL.Implement;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.Model;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class Form_Detail_Room_Category : Form
    {
        private RoomTypeBLL roomTypeBLL;
        private RoomBLL roomBLL;
        private QLBookingBLL bookingBLL;
        private ClientDAL clientDAL;
        private ClientBLL clientBLL;
        private QLUserBLL userBLL;
        private RoomDAL roomDAL;
        private QLInvoiceBLL qLInvoiceBLL;
        List<ImageVM> ImgList = new List<ImageVM>();
        public Form_Detail_Room_Category()
        {
            InitializeComponent();
            LoadData();
            roomTypeBLL = new RoomTypeBLL();
            roomBLL = new RoomBLL();
            bookingBLL = new QLBookingBLL();
            clientDAL = new ClientDAL();
            clientBLL = new ClientBLL();
            userBLL = new QLUserBLL();
            roomDAL = new RoomDAL();
            qLInvoiceBLL = new QLInvoiceBLL();
        }
        //Loading Data Function
        public void LoadData() { }
        //Reset Function
        public void ResetData() { }
        //Hàm tạo folder & insert ảnh
        public Image InsertIMG()
        {
            string palettesPath = "\\Properties\\Room_Type";
            try
            {
                // If the directory doesn't exist, create it.
                if (!System.IO.Directory.Exists(palettesPath))
                {
                    System.IO.Directory.CreateDirectory(palettesPath);
                }
            }
            catch (Exception)
            {
                // Fail silently
                MessageBox.Show("Error!");
            }
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(open.FileName);
            }
            return null;
        }
        public void addRoomType()
        {
            RoomTypeVM roomTypeVM = new RoomTypeVM
            {
                RotyCapacity = Int32.Parse(tb_RoomTypeCapacity.Text),
                RotyCurrentprice = Int32.Parse(tb_RoomTypePrice.Text),
                RotyDescription = tb_RoomTypeDescription.Text,
                RotyName = tb_RoomTypeName.Text,
            };
            //ImageVM image1 = new ImageVM
            //{
            //    ImgstoUrl = "home/cuong/yessss"
            //};
            //roomTypeVM.ListImg.Add(image1);
            //ImageVM image2 = new ImageVM
            //{
            //    ImgstoUrl = "home/cuong/nooooo"
            //};
            //roomTypeVM.ListImg.Add(image2);
            roomTypeBLL.addRoomType(roomTypeVM);
        }
        //Events
        private void picbx_add1_Click(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add1.BackgroundImage);
            picbx_add1.BackgroundImage = null;
            picbx_add1.Image = InsertIMG();
            picbx_add1.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add2.BackgroundImage = temp;
        }
        private void picbx_add2_Click(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add2.BackgroundImage);
            picbx_add2.BackgroundImage = null;
            picbx_add2.Image = InsertIMG();
            picbx_add2.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add3.BackgroundImage = temp;
        }
        private void picbx_add3_Click(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add3.BackgroundImage);
            picbx_add3.BackgroundImage = null;
            picbx_add3.Image = InsertIMG();
            picbx_add3.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add4.BackgroundImage = temp;
        }
        private void picbx_add4_Click(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add4.BackgroundImage);
            picbx_add4.BackgroundImage = null;
            picbx_add4.Image = InsertIMG();
            picbx_add4.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add5.BackgroundImage = temp;
        }
        private void picbx_add5_Click(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add5.BackgroundImage);
            picbx_add5.BackgroundImage = null;
            picbx_add5.Image = InsertIMG();
            picbx_add5.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add6.BackgroundImage = temp;
        }
        private void picbx_add6_Click(object sender, EventArgs e)
        {
            picbx_add6.BackgroundImage = null;
            picbx_add6.Image = InsertIMG();
            picbx_add6.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            //Gọi hàm BLL xử lí nghiệp vụ
            
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Gọi hàm xóa tất cả dữ liệu đã nhập hoặc có sẵn trước đó
            ResetData();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
