﻿using System;
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

        private BookingDetailVM detailVM;
        private BindingList<SubBookingDetailVM> subBookings;
        private Dictionary<string, List<AvailableRoomVM>> storeRoomDel;
        private List<AvailableRoomVM> listForCbb;
        private int idClient;
        private string currentRoomType;
        private List<int> listOld;
        private List<int> listDel;

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
            subBookings.AllowEdit = false;
            subBookings.RaiseListChangedEvents = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            listForCbb = new List<AvailableRoomVM>();
            listOld = new List<int>();
            listDel = new List<int>();
            //     storeDelRoom = new List<AvailableRoomVM>();
            storeRoomDel = new Dictionary<string, List<AvailableRoomVM>>();
            IDBook = IdBook;
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
            dgv.Columns["IdBoodet"].Visible = false;
            dgv.Columns["BoodetIdroom"].Visible = false;
            dgv.Columns["BoodetIdbook"].Visible = false;
            dgv.Columns["BoodetRotyCode"].Visible = false;
        }
        private void LoadAvailableTempRoomList(int IdRoomtype, DateTime fromDate, DateTime toDate)
        {
            listForCbb = roomBLL.findAvailableRoom(IdRoomtype, fromDate, toDate);
            string rotyname = listForCbb[0].RoTyName;
            if (storeRoomDel.ContainsKey(rotyname))
            {
                foreach (var delRoom in storeRoomDel[rotyname])
                {
                    listForCbb.RemoveAll(x => x.IdRoom == delRoom.IdRoom);

                }
            }
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
                detailVM = new BookingDetailVM();
                tb_BookDate.Text = DateTime.Now.ToString();
                tb_DueDate.Text = (DateTime.Now.AddDays(4)).ToString();
                rbtn_NewClient.Checked = true;
                rbtn_OldClient.Checked = false;
                tb_ClientSearch.Enabled = true;

                dgv.DataSource = null;
            }
            else
            {
                rbtn_OldClient.Checked = true;
                tb_ClientSearch.Enabled = false;
                detailVM = BookingBLL.getDetail(IDBook);
                //View or Edit
                rbtn_OldClient.Checked = true;
                idClient = detailVM.clientVM.IdClient;
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
                tb_Status.Text = detailVM.BookStatus;
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
                    btn_Checkin.Enabled = true;
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
            tb_Status.Enabled = false;
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

        private int calTotalPrice()
        {
            int result = 0;
            foreach (var val in subBookings)
            {
                result += val.BoodetPrice;
            }
            return result;
        }
        //Booking Functions
        private void AddBooking()
        {
            detailVM = new BookingDetailVM
            {
                BookNote = tb_Note.Text,
                BookCheckindate = dtp_From.Value,
                BookCheckoutdate = dtp_To.Value,
                BookBookdate = Convert.ToDateTime(tb_BookDate.Text),
                BookDuedate = Convert.ToDateTime(tb_DueDate.Text),
                //   BookStatus = cbb_Status.Text.Replace(" ", String.Empty),
                BookStatus = "Processed",
                BookTotalprice = Int32.Parse(tb_Total.Text),
                BookDeposit = Int32.Parse(tb_Deposit.Text)
            };
            if (rbtn_NewClient.Checked)
            {
                detailVM.clientVM = new ClientVM
                {
                    CliName = tb_ClientName.Text,
                    CliPhone = tb_ClientPhone.Text,
                    CliGmail = tb_ClientEmail.Text
                };
            }
            else
            {
                detailVM.clientVM = new ClientVM
                {
                    IdClient = idClient
                };
            }
            foreach (var val in subBookings)
            {
                detailVM.ListSub.Add(val);
            }
            BookingBLL.addBooking(detailVM);
        }
        private void UpdateBooking()
        {
            detailVM.BookNote = tb_Note.Text;
            detailVM.BookCheckindate = dtp_From.Value;
            detailVM.BookCheckoutdate = dtp_To.Value;
            detailVM.BookTotalprice = calTotalPrice();
            detailVM.BookDeposit = detailVM.BookTotalprice * 3 / 10;
            detailVM.ListSub.Clear();
            foreach (SubBookingDetailVM val in subBookings)
            {                
                detailVM.ListSub.Add(val);
            }
            detailVM.clientVM.CliGmail = tb_ClientEmail.Text;
            detailVM.clientVM.CliName = tb_ClientName.Text;
            detailVM.clientVM.CliPhone = tb_ClientPhone.Text;
            BookingBLL.updateBooking(detailVM, listDel);
        }
    


        //Events
    /*    private void rbtn_NewClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_NewClient.Checked)
            {
                tb_ClientSearch.Enabled = false;
                picbx_ClientSearch.Enabled = false;
            }
        }*/
   /*     private void rbtn_OldClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_OldClient.Checked)
            {
                tb_ClientSearch.Enabled = true;
                picbx_ClientSearch.Enabled = true;
            }
        }*/
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
                    idClient = listClient[0].IdClient;
                    rbtn_OldClient.Checked = true;
                    tb_ClientEmail.Enabled = false;
                    tb_ClientName.Enabled = false;
                    tb_ClientPhone.Enabled = false;
                }
                else
                {
                    tb_ClientEmail.Text = "";
                    tb_ClientName.Text = "";
                    tb_ClientPhone.Text = "";
                    MessageBox.Show("Client isn't existed");
                    rbtn_NewClient.Checked = true;
                    tb_ClientEmail.Enabled = true;
                    tb_ClientName.Enabled = true;
                    tb_ClientPhone.Enabled = true;
                }
            }   
        }
        private void picbx_Enter_Click(object sender, EventArgs e)
        {
            currentRoomType = ((CbbItem)cbb_RoomType.SelectedItem).text;
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
                            BoodetIdroom = result.IdRoom,
                            BoodetRoTyCode = result.RotyCode,
                            RoomName = result.RoomName,
                            RoomType = result.RoTyName
                        });
                if (storeRoomDel.ContainsKey(currentRoomType))
                {
                    storeRoomDel[currentRoomType].Add(result);
                }
                else
                {
                    var temp = new List<AvailableRoomVM>();
                    temp.Add(result);
                    storeRoomDel.Add(currentRoomType, temp);
                }
                        //     storeDelRoom.Add(result);
                             listForCbb.Remove(result);
                             LoadCbbRoom();
                             LoadBookedRoomList();
                tb_Total.Text = calTotalPrice().ToString();
                tb_Deposit.Text = (calTotalPrice() * 3 / 10).ToString();
            }    
        }
        private void picbx_Delete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1 && dgv.Rows.Count > 0)
            {
                int selectedIdRoom = int.Parse(dgv.SelectedRows[0].Cells["BoodetIdroom"].Value.ToString());
                //      int index = subBookings.FindIndex(x => x.BoodetIdroom == selectedIdRoom);
                SubBookingDetailVM val = subBookings.Where(x =>x.BoodetIdroom == selectedIdRoom).FirstOrDefault();
                if (val.IdBoodet != 0) listDel.Add(val.IdBoodet);
                subBookings.Remove(val);
                if (storeRoomDel.ContainsKey(val.RoomType))
                {
                    AvailableRoomVM store = storeRoomDel[val.RoomType].Find(x => x.IdRoom == selectedIdRoom);
                    listForCbb.Add(store);
                    storeRoomDel[val.RoomType].Remove(store);
                }
       //         AvailableRoomVM store = storeDelRoom.Find(x =>x.IdRoom == selectedIdRoom);
         //       storeDelRoom.Remove(store);
         //       listForCbb.Add(store);
                LoadCbbRoom();
                LoadBookedRoomList();
                tb_Total.Text = calTotalPrice().ToString();
                tb_Deposit.Text = (calTotalPrice() * 3 / 10).ToString();
            } 
            else
            {
                MessageBox.Show("Bạn chưa chọn hoặc chọn nhiều hơn một phòng để xóa khỏi đơn booking", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onDtbChange()
        {
            foreach (var value in subBookings)
            {
                if (value.IdBoodet != 0) listDel.Add(value.IdBoodet);
            }
            tb_Total.Text = "0";
            tb_Deposit.Text = "0";
            subBookings.Clear();
            dgv.DataSource = null;
            storeRoomDel.Clear();
            cbb_Room.DataSource = null;
        }
        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            onDtbChange();
        }
        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            onDtbChange();
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
                        UpdateBooking();
                        MessageBox.Show("Đã cập nhật thành công đơn booking!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void btn_Checkin_Click(object sender, EventArgs e)
        {
            BookingBLL.completeBooking(IDBook);
        }
    }
}