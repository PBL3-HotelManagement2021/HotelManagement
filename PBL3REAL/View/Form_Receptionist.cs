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
using PBL3REAL.Extention;
using PBL3REAL.View;
namespace PBL3REAL.View
{
    public partial class Form_Receptionist : Form
    {
        /***** GLOBAL DECLARATION *****/
        //-> Global BLL Parameter
        private QLBookingBLL bookingBLL;
        private RoomBLL roomBLL;
        private RoomTypeBLL roomTypeBLL;
        private readonly int ROWS = 5;

        //-> Parameter for Booking
        private int BookingCurrentPage = 1;
        private int totalBookingPages = 0;
        private string bookingSearch = "";
        private CalendarVM searchByDate;
        private string bookOrderBy = "None";
        private string bookStatus = "";




        //-> Parameter for Room 
        private int totalRoomPages = 0;
        private string nameSearch = "";
        private int idRoomTypeSearch = 0;
        private int roomActivate = 0;
        private int RoomCurrentPage = 1;

        //-> Parameter for RoomType
        private string rotySearch ="";
        private string rotyOrderBy = "None";
        public Form_Receptionist(int LoggedID, string LoggedRole)
        {
            InitializeComponent();
            /*** Initialize Parameter ***/
            roomBLL = new RoomBLL();
            roomTypeBLL = new RoomTypeBLL();
            bookingBLL = new QLBookingBLL();
            /*** Load Data & Set GUI ***/
            AddCbbRoomFilter();
            LoadRoomList();
            LoadRoomTypeList();
            addCbbRoomTypeOrder();
            AddCbbActive();
            if (LoggedRole != "Admin")
            {
                btn_RoomAdd.Enabled = false;
                btn_RoomEdit.Enabled = false;
                btn_RoomDelete.Enabled = false;
                btn_RoomTypeAdd.Enabled = false;
                btn_RoomTypeEdit.Enabled = false;
                btn_RoomTypeDelete.Enabled = false;
            }
            tb_RoomPageNumber.Text = "";
            


            /****Booking****/
            cbb_BookingSearchFilter.SelectedIndex = 0;
            cbb_BookingSort.SelectedIndex = 0;
            cbb_BookingStatus.SelectedIndex = 0;
            searchByDate = new CalendarVM();
            tb_BookingPageNumber.Text = "0/0";
        }
        /***** GENERAL *****/
        //-> General Functions
        //-> General Events
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /***** BOOKING *****/
        //-> Booking Functions
        private void LoadBookingList()
        {
           
            dgv_Booking.DataSource = null;
            dgv_Booking.DataSource = bookingBLL.findByProperty(BookingCurrentPage, ROWS,searchByDate, bookingSearch, bookOrderBy,bookStatus);
            dgv_Booking.Columns["BookDeposit"].Visible = false;
            dgv_Booking.Columns["IdBook"].Visible = false;
            dgv_Booking.Columns["BookNote"].Visible = false;
        }

        public void searchBookData()
        {
            bookingSearch = tb_BookingSearch.Text;
            bookOrderBy = cbb_BookingSort.SelectedItem.ToString();
            bookStatus = cbb_BookingStatus.SelectedItem.ToString();
            searchByDate.type = cbb_BookingSearchFilter.SelectedItem.ToString();
            searchByDate.fromDate = dtp_BookingFrom.Value;
            searchByDate.toDate = dtp_BookingTo.Value;
            BookingCurrentPage = 1;
            totalBookingPages = bookingBLL.getPagination(ROWS, searchByDate, bookOrderBy, bookingSearch, bookStatus);
            if (totalBookingPages != 0)
            {
                tb_BookingPageNumber.Text = BookingCurrentPage + "/" + totalBookingPages;
                LoadBookingList();
            }
            else
            {
                tb_BookingPageNumber.Text = "0/0";
                dgv_Booking.DataSource = null;
            }
        }

     
        private int CheckBookingData()
        {
            if (cbb_BookingSearchFilter.SelectedItem == null)
            {
                return 1;
            }
            if (dtp_BookingFrom.Value > dtp_BookingTo.Value)
            {
                return 2;
            }
            return 0;
        }
        //-> Booking Events
        private void btn_BookingExport_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_Booking.SelectedRows;
            if (r.Count == 1)
            {
                if(r[0].Cells["BookStatus"].Value.ToString() != "Processed")
                {
                    Form_Detail_Invoice f = new Form_Detail_Invoice(r[0].Cells["BookCode"].Value.ToString());
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Can't export booking with status 'Processed'", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btn_BookingView_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_Booking.SelectedRows;
            if (r.Count == 1)
            {
                Form_Booking f = new Form_Booking(int.Parse(r[0].Cells["IdBook"].Value.ToString()), false);
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
            Form_Booking f = new Form_Booking(0, true);
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
                if(r[0].Cells["BookStatus"].Value.ToString() == "Processed")
                {
                    Form_Booking f = new Form_Booking(int.Parse(r[0].Cells["IdBook"].Value.ToString()), true);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Only booking with status 'Processed' can update");
                }
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
                if (r[0].Cells["BookStatus"].Value.ToString() == "Processed")
                {
                    try
                    {
                        bookingBLL.delBooking(int.Parse(r[0].Cells["IdBook"].Value.ToString()), r[0].Cells["BookStatus"].Value.ToString());
                        searchBookData();
                    }
                    catch (Exception mes)
                    {
                        MessageBox.Show(mes.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Only booking with status 'Processed' can delete");
                }
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
      
        private void picbx_BookingSearch_Click(object sender, EventArgs e)
        {
            //Search 
            switch(CheckBookingData())
            {
                case 1:
                    MessageBox.Show("Bạn chưa chọn loại cần tìm kiếm theo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Dữ liệu thời gian bạn nhập chưa phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    //Gọi hàm tìm kiếm booking
                    searchBookData();
                    break;
            }
        }
        private void picbx_BookingRefresh_Click(object sender, EventArgs e)
        {
    //        searchBookData();
        }
        private void btn_BookingPrevPage_Click(object sender, EventArgs e)
        {
            if (BookingCurrentPage > 1)
            {
                BookingCurrentPage -= 1;
                LoadBookingList();
                tb_BookingPageNumber.Text = BookingCurrentPage+"/"+totalBookingPages;
            }
        }
        private void btn_BookingNextPage_Click(object sender, EventArgs e)
        {
            if (BookingCurrentPage < totalBookingPages) //Thay 10 thanh ham get total booking record 
            {
                BookingCurrentPage += 1;
                LoadBookingList();
                tb_BookingPageNumber.Text = BookingCurrentPage + "/" + totalBookingPages;
            }
        }
        /***** ROOM *****/
        //-> Room Functions
        private void AddCbbRoomFilter()
        {
            List<CbbItem> list = roomTypeBLL.addCombobox();
            list.Insert(0, new CbbItem(0, "All RoomType"));
            List<CbbItem> res = list;
            cbb_RoomFilter.DataSource = res;
        }
        private void AddCbbActive()
        {
            cbb_RoomActive.Items.Add("All");
            cbb_RoomActive.Items.Add("Activate");
            cbb_RoomActive.Items.Add("Inactivate");
            cbb_RoomActive.SelectedIndex = 0;
        }
        private void LoadRoomList()
        {
            dgv_Room.DataSource = null;
            dgv_Room.DataSource = roomBLL.findByProperty(RoomCurrentPage, ROWS, idRoomTypeSearch, nameSearch, roomActivate);
            dgv_Room.Columns["IdRoom"].Visible = false;
        }
        public void findidRoom()
        {
            RoomDetailVM roomDetailVM = roomBLL.findByID(1);
        }
        public void ReloadRoomData()
        {
            cbb_RoomFilter.SelectedIndex = 0;
            idRoomTypeSearch = 0;
            nameSearch = tb_RoomSearch.Text="";
            cbb_RoomActive.SelectedIndex = 0;
            searchRoomData();
        }
        public void searchRoomData()
        {
            idRoomTypeSearch = ((CbbItem)cbb_RoomFilter.SelectedItem).Value;
            nameSearch = tb_RoomSearch.Text;
            roomActivate = cbb_RoomActive.SelectedIndex;
            RoomCurrentPage = 1;
            totalRoomPages = roomBLL.getPagination(ROWS, idRoomTypeSearch, nameSearch,roomActivate);
            LoadRoomList();
            if (totalRoomPages != 0) tb_RoomPageNumber.Text = RoomCurrentPage + "/" + totalRoomPages;
            else tb_RoomPageNumber.Text = "0/0";
        }
        //-> Room Events
        private void btn_RoomView_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_Room.SelectedRows;
            if (r.Count == 1)
            {
                HotelManagement.View.Form_Detail_Room f = new HotelManagement.View.Form_Detail_Room(int.Parse(r[0].Cells["IdRoom"].Value.ToString()), false);
                this.Hide();
                f.myDel = new HotelManagement.View.Form_Detail_Room.MyDel(ReloadRoomData);
                f.ShowDialog();
                this.Show();
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng để xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chỉ có thể chọn một phòng trong một lần xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_RoomAdd_Click(object sender, EventArgs e)
        {
            HotelManagement.View.Form_Detail_Room f = new HotelManagement.View.Form_Detail_Room(0, true);
            this.Hide();
            f.myDel = new HotelManagement.View.Form_Detail_Room.MyDel(ReloadRoomData);
            f.ShowDialog();
            this.Show();
        }
        private void btn_RoomEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_Room.SelectedRows;
            if (r.Count == 1)
            {
                HotelManagement.View.Form_Detail_Room f = new HotelManagement.View.Form_Detail_Room(int.Parse(r[0].Cells["IdRoom"].Value.ToString()), true);
                this.Hide();
                f.myDel = new HotelManagement.View.Form_Detail_Room.MyDel(ReloadRoomData);
                f.ShowDialog();
                this.Show();
                //Reload Data
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chỉ có thể chọn một phòng trong một lần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_RoomDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_Room.SelectedRows;
            if (r.Count == 1)
            {
                roomBLL.deleteRoom(int.Parse(r[0].Cells["IdRoom"].Value.ToString()));
               ReloadRoomData();
                //Reload Data
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chỉ có thể chọn một phòng trong một lần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_RoomChangeActiveState_Click(object sender, EventArgs e)
        {
            //Change active status
        }
        private void picbx_RoomSort_Click(object sender, EventArgs e)
        {
            //Sort by Filter
        }
        private void picbx_RoomSearch_Click(object sender, EventArgs e)
        {
            //Search 
            searchRoomData();

        }
        private void picbx_RoomRefresh_Click(object sender, EventArgs e)
        {
           ReloadRoomData();
        }
        private void btn_RoomPrevPage_Click(object sender, EventArgs e)
        {
            if (RoomCurrentPage > 1)
            {
                //   dgv_Room.DataSource = roomBLL.findByProperty(RoomCurrentPage - 1, 10, 0, "");
                RoomCurrentPage -= 1;
              
                LoadRoomList();
                tb_RoomPageNumber.Text = RoomCurrentPage + "/" + totalRoomPages;
            }
        }
        private void btn_RoomNextPage_Click(object sender, EventArgs e)
        {
        
            if (RoomCurrentPage < totalRoomPages)
            {
                // dgv_Room.DataSource = roomBLL.findByProperty(RoomCurrentPage + 1, 10, 0, "");
                RoomCurrentPage += 1;
                LoadRoomList();              
                tb_RoomPageNumber.Text = RoomCurrentPage+"/"+ totalRoomPages;
            }
        }
        private void dgv_Room_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Room.SelectedRows.Count == 1)
            {
                //if (dgv_Room.SelectedRows[0].Cells[])
            }   
            else
            {

            }    
        }
        /***** ROOM TYPE *****/
        //-> Romm Type Functions
        private void LoadRoomTypeList()
        {
            dgv_RoomType.DataSource = null;
            dgv_RoomType.DataSource = roomTypeBLL.findByProperty(rotySearch,rotyOrderBy);
            dgv_RoomType.Columns["IdRoomtype"].Visible = false;

        }
        private void ReloadRoTyData()
        {
   
            LoadRoomTypeList();
        }
        //-> Room Type Events
        private void addCbbRoomTypeOrder()
        {
            cbb_RoomTypeSort.Items.Add("None");
            cbb_RoomTypeSort.Items.Add("Current Price Asc");
            cbb_RoomTypeSort.Items.Add("Current Price Desc");
            cbb_RoomTypeSort.SelectedIndex = 0;
        }
        private void btn_RoomTypeView_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_RoomType.SelectedRows;
            if (r.Count == 1)
            {
                Form_Detail_Room_Category f = new Form_Detail_Room_Category(int.Parse(r[0].Cells["IdRoomtype"].Value.ToString()), false);
                this.Hide();
                f.myDel = new Form_Detail_Room_Category.MyDel(ReloadRoTyData);
                f.ShowDialog();
                this.Show();
                //Reload Data
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại phòng để xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chỉ có thể chọn một loại phòng trong một lần xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_RoomTypeAdd_Click(object sender, EventArgs e)
        {
            Form_Detail_Room_Category f = new Form_Detail_Room_Category(0, true);
            this.Hide();
            f.myDel = new Form_Detail_Room_Category.MyDel(ReloadRoTyData);
            f.ShowDialog();
            this.Show();
            //Reload data
        }
        private void btn_RoomTypeEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_RoomType.SelectedRows;
            if (r.Count == 1)
            {
                Form_Detail_Room_Category f = new Form_Detail_Room_Category(int.Parse(r[0].Cells["IdRoomType"].Value.ToString()), true);
                this.Hide();
                f.myDel = new Form_Detail_Room_Category.MyDel(ReloadRoTyData);
                f.ShowDialog();
                this.Show();
                //Reload Data
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại phòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chỉ có thể chọn một loại phòng trong một lần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_RoomTypeDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_RoomType.SelectedRows;
            if (r.Count == 1)
            {
                roomTypeBLL.deleteRoomType(int.Parse(r[0].Cells["IdRoomtype"].Value.ToString()));
                //Reload Data
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại phòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chỉ có thể chọn một loại phòng trong một lần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void picbx_RoomTypeSearch_Click(object sender, EventArgs e)
        {
            rotySearch = tb_RoomTypeSearch.Text;
            rotyOrderBy = cbb_RoomTypeSort.SelectedItem.ToString();
            LoadRoomTypeList();
        }
        private void picbx_RoomTypeSort_Click(object sender, EventArgs e)
        {
            //Sort by Filter
        }

      
    }
}
