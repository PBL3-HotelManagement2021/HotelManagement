using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
using PBL3REAL.Extention;
using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using System.Linq;

namespace PBL3REAL.View
{
    public partial class Form_Detail_Room : Form
    {
        //Declaration
        private QLBookingBLL BookingBLL;
        private RoomTypeBLL roomTypeBLL;
        private RoomBLL roomBLL;
        private ClientBLL clientBLL;
        private int IDBook = 0;
        private int price = 0;
        private BookingDetailVM detailVM;
        private BindingList<SubBookingDetailVM> subBookings;
        private List<AvailableRoomVM> storeDelRoom;
        private List<AvailableRoomVM> listForCbb;
       
        public Form_Detail_Room(int IdBook, bool Editable)
        {
            InitializeComponent();
            BookingBLL = new QLBookingBLL();
            roomTypeBLL = new RoomTypeBLL();
            roomBLL = new RoomBLL();
            clientBLL = new ClientBLL();
            subBookings = new BindingList<SubBookingDetailVM>();
            subBookings.AllowNew = true;
            subBookings.AllowRemove = true;
            listForCbb = new List<AvailableRoomVM>();
            storeDelRoom = new List<AvailableRoomVM>();
                IDBook = IdBook;
            if (IdBook != 0)
            {
                detailVM = BookingBLL.getDetail(IDBook);
            }  
            else
            {
                //Generate IdBook để add
                LoadBookedRoomList();
            }
            LoadData(IdBook, Editable);
            LoadRoomTypeList();
        }
        //Load Data Functions
        private void LoadRoomTypeList()
        {
            List<CbbItem> list = roomTypeBLL.addCombobox();
            List<CbbItem> res = list;
            cbb_RoomType.DataSource = res;
        }
        private void LoadBookedRoomList()
        {
            //dgv.DataSource = detailVM.ListSub;
            dgv.DataSource = null;
            dgv.DataSource = subBookings;
        }
        private void LoadAvailableTempRoomList(int IdRoomtype, DateTime fromDate, DateTime toDate)
        {
        
           listForCbb= roomBLL.findAvailableRoom(IdRoomtype, fromDate, toDate);
            LoadCbbRoom();
        }

        private void LoadCbbRoom()
        {
            cbb_Room.DataSource = null;
            cbb_Room.DataSource = listForCbb;
            cbb_Room.DisplayMember = "RoomName";
        }
        private void LoadData(int id, bool Edit)
        {
            if (id == 0)
            {
                //Add new booking
                tb_BookDate.Text = DateTime.Now.ToString();
                tb_DueDate.Text = (DateTime.Now.AddDays(4)).ToString();
                rbtn_NewClient.Checked = true;
                rbtn_OldClient.Checked = false;
                tb_ClientSearch.Enabled = true;
                picbx_ClientSearch.Enabled = false;
            }
            else
            {
                //View or Edit
                rbtn_OldClient.Checked = true;
                tb_ClientName.Text = detailVM.clientVM.CliName;
                tb_ClientEmail.Text = detailVM.clientVM.CliGmail;
                tb_ClientPhone.Text = detailVM.clientVM.CliPhone;
                dtp_From.Value = detailVM.BookCheckindate;
                dtp_To.Value = detailVM.BookCheckoutdate;
                foreach (SubBookingDetailVM item in detailVM.ListSub) { subBookings.Add(item); }
                LoadBookedRoomList();
                tb_BookDate.Text = detailVM.BookBookdate.ToString();
                tb_DueDate.Text = detailVM.BookDuedate.ToString();
                tb_Deposit.Text = detailVM.BookDeposit.ToString();
                tb_Total.Text = detailVM.BookTotalprice.ToString();
                cbb_Status.Text = detailVM.BookStatus;
                tb_Note.Text = detailVM.BookNote;
                if (!Edit)
                {
                    grbx_ClientInfo.Enabled = false;
                    grbx_PeriodTime.Enabled = false;
                    grbx_BookingInfo.Enabled = false;
                    picbx_Enter.Enabled = false;
                    picbx_Add.Enabled = false;
                    picbx_Delete.Enabled = false;
                    btn_OK.Enabled = false;
                    btn_Invoice.Enabled = false;
                    btn_Checkin.Enabled = false;
                    btn_Reset.Enabled = false;
                }
                else
                {
                    foreach (SubBookingDetailVM item in subBookings)
                    {
                        RoomDetailVM temproom = roomBLL.findByID(item.BoodetIdroom);
                       /* BookedRoomVMs.Add(new RoomVM
                        {
                            IdRoom = temproom.IdRoom,
                            RoomName = temproom.RoomName,
                            RoomDescription = temproom.RoomDescription,
                            RotyCurrentprice = temproom.RotyCurrentprice,
                            RoTyName = temproom.RoTyName
                        });*/
                    }
                }
            }
            cbb_Status.Enabled = false;
            tb_Total.Enabled = false;
            tb_Deposit.Enabled = false;
        }
        //Check Data Function
        private int CheckData()
        {
            if (tb_ClientName.Text == "" || tb_ClientPhone.Text == "" || tb_ClientEmail.Text == "")
            { return 1; }   
            else if (dgv.Rows.Count == 0)
            { return 2; }    
            else
            { return 0; }    
        }
        //Booking Functions
        private void AddBooking()
        {
            BookingDetailVM result = new BookingDetailVM
            {
                BookNote = tb_Note.Text,
                BookCheckindate = dtp_From.Value,
                BookCheckoutdate = dtp_To.Value,
                BookBookdate = Convert.ToDateTime(tb_BookDate.Text),
                BookStatus = cbb_Status.Text.Replace(" ",String.Empty),
                BookTotalprice = price,
                BookDeposit = price / 2,
                clientVM = new ClientVM
                {
                    CliName = tb_ClientName.Text,
                    CliPhone = tb_ClientPhone.Text
                }
            };
       /*     foreach (RoomVM item in BookedRoomVMs)
            {
                result.ListSub.Add(new SubBookingDetailVM
                {
                    BooDetNote = "",
                    BoodetPrice = Convert.ToInt32(item.RotyCurrentprice),
                    BoodetIdroom = item.IdRoom,
                    BoodetRoTyCode = cbb_RoomType.SelectedValue.ToString()
                });
            }*/
            BookingBLL.addBooking(result);
        }
        private void UpdateBooking(bool Changes)
        {
            List<int> listOld = new List<int>();
            List<int> listdel = new List<int>();
            if (Changes)
            {
                BookingDetailVM bookingDetailVM = BookingBLL.getDetail(1);
                bookingDetailVM.BookNote = tb_Note.Text;
                bookingDetailVM.BookCheckindate = dtp_From.Value;
                bookingDetailVM.BookCheckoutdate = dtp_To.Value;
                //b1 luu tat ca id cua SubBookingDetailVm qua listOld
                foreach (SubBookingDetailVM val in bookingDetailVM.ListSub)
                {
                    listOld.Add(val.IdBoodet);
                }
                //b2 Xoa het tat ca SubBookingDetailVm
                bookingDetailVM.ListSub.Clear();
                //b3 them SubBookingDetailVm ms vao

             /*   foreach(RoomVM item in BookedRoomVMs)
                {
                    bookingDetailVM.ListSub.Add(new SubBookingDetailVM {
                        BooDetNote = "",
                        BoodetPrice = Convert.ToInt32(item.RotyCurrentprice),
                        BoodetIdroom = item.IdRoom,
                        BoodetRoTyCode = cbb_RoomType.SelectedValue.ToString()
                    });
                }    */
                BookingBLL.updateBooking(bookingDetailVM, null, listOld);
            }
            else
            {
                //foreach (SubBookingDetailVM item )
                BookingDetailVM bookingDetailVM = BookingBLL.getDetail(1);
                bookingDetailVM.BookNote = tb_Note.Text;
                /*foreach (RoomVM item in BookedRoomVMs)
                {
                    bookingDetailVM.ListSub.Add(new SubBookingDetailVM
                    {
                        BooDetNote = "",
                        BoodetPrice = Convert.ToInt32(item.RotyCurrentprice),
                        BoodetIdroom = item.IdRoom,
                        BoodetRoTyCode = cbb_RoomType.SelectedValue.ToString()
                    });
                }*/
                BookingBLL.updateBooking(bookingDetailVM, listdel, listOld);
            }
        }
        //Events
        private void rbtn_NewClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_NewClient.Checked)
            {
                tb_ClientSearch.Enabled = false;
                picbx_ClientSearch.Enabled = false;
            }
        }
        private void rbtn_OldClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_OldClient.Checked)
            {
                tb_ClientSearch.Enabled = true;
                picbx_ClientSearch.Enabled = true;
            }
        }
        private void picbx_ClientSearch_Click(object sender, EventArgs e)
        {
            if (tb_ClientSearch.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Dictionary<string, string> properties = new Dictionary<string, string>();
                properties.Add("phone", tb_ClientSearch.Text);
                List<ClientVM> listClient = clientBLL.findByProperty(properties);
                if(listClient !=null && listClient.Count != 0)
                {
                    tb_ClientEmail.Text = listClient[0].CliGmail;
                    tb_ClientName.Text = listClient[0].CliName;
                    tb_ClientPhone.Text = listClient[0].CliPhone;
                }
                else
                {
                    tb_ClientEmail.Text = "";
                    tb_ClientName.Text = "";
                    tb_ClientPhone.Text = "";
                    MessageBox.Show("Client isn't existed");
                }
            }   
        }
        private void picbx_Enter_Click(object sender, EventArgs e)
        {
            dgv.DataSource = new List<SubBookingDetailVM>();
            LoadAvailableTempRoomList(((CbbItem)cbb_RoomType.SelectedItem).Value,dtp_From.Value,dtp_To.Value);
        }
        private void picbx_Add_Click(object sender, EventArgs e)
        {
            //add room
            if (dtp_From.Value != null && dtp_To.Value != null && cbb_RoomType.SelectedItem != null)
            {
                AvailableRoomVM result = ((AvailableRoomVM)cbb_Room.SelectedItem);  
                        subBookings.Add(new SubBookingDetailVM
                        {
                         
                            BoodetPrice = Convert.ToInt32(result.RotyCurrentprice),
                            //BooDetNote = item.RoomDescription,
                            BoodetIdroom = result.IdRoom,
                            BoodetRoTyCode = result.RotyCode,
                            RoomName = result.RoomName,
                            RoomType = result.RoTyName
                        });
                             storeDelRoom.Add(result);
                             listForCbb.Remove(result);
                             LoadCbbRoom();
                             LoadBookedRoomList();
            }    
        }
        private void picbx_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1 && dgv.Rows.Count > 0)
            {
                int selectedIdRoom = int.Parse(dgv.SelectedRows[0].Cells["BoodetIdroom"].Value.ToString());
                //      int index = subBookings.FindIndex(x => x.BoodetIdroom == selectedIdRoom);
                SubBookingDetailVM val = subBookings.Where(x =>x.BoodetIdroom == selectedIdRoom).SingleOrDefault();
                subBookings.Remove(val);
                AvailableRoomVM store = storeDelRoom.Find(x =>x.IdRoom == selectedIdRoom);
                storeDelRoom.Remove(store);
                listForCbb.Add(store);
                LoadCbbRoom();
            } 
            else
            {
                MessageBox.Show("Bạn chưa chọn hoặc chọn nhiều hơn một phòng để xóa khỏi đơn booking", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            subBookings.Clear();
            storeDelRoom.Clear();
            cbb_Room.DataSource = null;
        }
        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            subBookings.Clear();
            storeDelRoom.Clear();
            cbb_Room.DataSource = null;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            switch (CheckData())
            {
                case 1:
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case 2:
                    MessageBox.Show("Bạn chưa chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                default:
                    if (IDBook == 0)
                    {
                        AddBooking();
                        MessageBox.Show("Đã tạo thành công đơn booking mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (dtp_From.Value == detailVM.BookCheckindate && dtp_To.Value == detailVM.BookCheckoutdate)
                        {
                            UpdateBooking(false);
                        }
                        else
                        {
                            UpdateBooking(true);
                        }
                        MessageBox.Show("Đã cập nhật thành công đơn booking!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }
    }
}
