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
        public Form_Detail_Room_Category()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ////Mở cửa sổ duyệt tìm ảnh   
            //// open file dialog   
            //OpenFileDialog open = new OpenFileDialog();
            //// image filters  
            //open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    // display image in picture box  
            //    pictureBox2.Image = new Bitmap(open.FileName);
            //    // image file path  
            //    textBox1.Text = open.FileName;
            //    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
            pictureBox2.Image = InsertIMG();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Mở cửa sổ duyệt tìm ảnh   
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox2.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Mở cửa sổ duyệt tìm ảnh   
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox2.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Mở cửa sổ duyệt tìm ảnh   
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox2.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Mở cửa sổ duyệt tìm ảnh   
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox2.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Mở cửa sổ duyệt tìm ảnh   
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox2.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
