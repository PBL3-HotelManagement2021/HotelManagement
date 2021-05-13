using HotelManagement.BBL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3REAL.View
{
    public partial class Form_Detail_Room_Category : Form
    {
        private int idRoomType;
        private RoomTypeBLL roomTypeBLL;
        private RoomTypeVM roomTypeVM;
      
        public Form_Detail_Room_Category(int id)
        {
        
            InitializeComponent();
            this.idRoomType = id;
            roomTypeBLL = new RoomTypeBLL();
            if (idRoomType != 0) loadData();
            else roomTypeVM = new RoomTypeVM();
        }

        private void loadData()
        {
            roomTypeVM = roomTypeBLL.findbyid(idRoomType);
            textBox2.Text = roomTypeVM.RotyName;
            textBox1.Text = roomTypeVM.RotyDescription;
            textBox3.Text = roomTypeVM.RotyCurrentprice.ToString();
            foreach(ImageVM imageVM in roomTypeVM.ListImg)
            {
                
            }
        }

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
 
      

        private void button2_Click(object sender, EventArgs e)
        {
            //Gọi hàm xóa tất cả dữ liệu đã nhập hoặc có sẵn trước đó
        }

        private void picbx_add1_Click_1(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add1.BackgroundImage);
            picbx_add1.BackgroundImage = null;
            picbx_add1.Image = InsertIMG();
            picbx_add1.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add2.BackgroundImage = temp;
        }

        private void picbx_add2_Click_1(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add2.BackgroundImage);
            picbx_add2.BackgroundImage = null;
            picbx_add2.Image = InsertIMG();
            picbx_add2.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add3.BackgroundImage = temp;
        }

        private void picbx_add3_Click_1(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add3.BackgroundImage);
            picbx_add3.BackgroundImage = null;
            picbx_add3.Image = InsertIMG();
            picbx_add3.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add4.BackgroundImage = temp;
        }

        private void picbx_add4_Click_1(object sender, EventArgs e)
        {
            Image temp = new Bitmap(picbx_add4.BackgroundImage);
            picbx_add4.BackgroundImage = null;
            picbx_add4.Image = InsertIMG();
            picbx_add4.SizeMode = PictureBoxSizeMode.StretchImage;
            picbx_add5.BackgroundImage = temp;
        }

        private void picbx_add5_Click_1(object sender, EventArgs e)
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
       /* public void addRoom()
        {
            RoomDetailVM roomDetailVM = new RoomDetailVM
            {
                RoomName = "Cuongpr",
                RotyCurrentprice = 2000000,
                RoomDescription = "ko co"
            };
            *//* roomDetailVM.MapRoomtype.Add(1, "single room");*//*
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
        }*/
        private void button3_Click(object sender, EventArgs e)
        {
            if(idRoomType == 0)
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
            else
            {

            }
        }

    /*    private void btn_Click(object sender, EventArgs e)
        {
            string idbutton = ((Button)sender).Name.ToString();
            if (idbutton.Equals("btncancel"))
            {
                this.Dispose();
            }
            if (idbutton.Equals("btnoke"))
            {

                if (txtmssv.Text.Length == 0 || txtname.Text.Length == 0) MessageBox.Show("Vui long nhap day du thong tin");
                else
                {
                    if (sv != null)
                    {
                        getdata(sv);
                        CSDL_OOP.Instance.updateSV(sv);
                        myDel(0, "");
                        this.Dispose();
                    }
                    else
                    {
                        SV sv1 = new SV();
                        getdata(sv1);
                        try
                        {
                            CSDL_OOP.Instance.addSV(sv1);
                            myDel(0, "");
                            this.Dispose();
                        }
                        catch (ArgumentException ae)
                        {
                            MessageBox.Show(ae.Message);
                        }

                    }

                }

            }
        }*/

        
    }
}
