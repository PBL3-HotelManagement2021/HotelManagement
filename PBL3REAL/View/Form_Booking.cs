using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class Form_Booking : Form
    {
        private QLBookingBLL BookingBLL;
        private int IDBook = 0;
        public Form_Booking(int IdBook, bool Editable)
        {
            InitializeComponent();
            BookingBLL = new QLBookingBLL();
            IDBook = IdBook;
            if (IdBook != 0)
            {
                LoadData(Editable);
            }  
            else
            {
                //Generate IdBook để add
            }    
        }
        //Load Data
        private void LoadData(bool Edit)
        {
            //BookingVM temp = BookingBLL.getDetail(IDBook);
            //tb_ClientName.Text = temp.CliCode;
            //tb_ClientAddress.Text = temp.
        }
    }
}
