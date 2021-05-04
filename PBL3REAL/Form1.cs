using HotelManagement.BBL.Implement;
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
        public Form1()
        {
            InitializeComponent();
            showroomtype();
        }

        public void showroomtype()
        {
            List<RoomTypeVM> listVM = RoomTypeBLL.Instance.getAll();
            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
        }
    }
}
