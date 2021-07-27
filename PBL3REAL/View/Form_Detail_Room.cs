using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using PBL3REAL.BLL;
using PBL3REAL.BLL.FacadeBLL;
using PBL3REAL.Extention;
using PBL3REAL.ViewModel;

namespace HotelManagement.View
{
    public partial class Form_Detail_Room : Form
    {
        //---------- GLOBAL DECLARATION ----------//
        //----- Delegation -----//
        public delegate void MyDel();
        public MyDel myDel;

        //----- BLL Room Instance Variables -----//
        private DetailRoomManageFacade _detailRoomManageFacade;
        private int idRoom;
        private RoomDetailVM roomDetailVM;
        private List<int> listdel;

        //---------- FORM CONSTRUCTOR ----------//
        public Form_Detail_Room(int idRoom, bool Editable)
        {
            //--- Initialize ---//
            InitializeComponent();
            this.idRoom = idRoom;
            _detailRoomManageFacade = new DetailRoomManageFacade();

            //--- Load Data ---//
            comboboxRoomType();
            if (Editable)  { comboboxStatus(); }
            else
            {
                grbx_FromToStatus.Enabled = false;
                grbx_RoomInfo.Enabled = false;
                btn_OK.Enabled = false;
                btn_Reset.Enabled = false;
            }  
            if (idRoom != 0) LoadData();
            else roomDetailVM = new RoomDetailVM();
            listdel = new List<int>();
        }

        //---------- FUNCTIONS ----------//
        //----- Load Data -----//
        private void comboboxRoomType()
        {
            List<CbbItem> res = _detailRoomManageFacade.AddCombobox();
            cbb_RoomType.DataSource = res;
        }
        private void comboboxStatus()
        {
            List<CbbItem> res = _detailRoomManageFacade.AddComboboxStatus();
            cbb_RoomStatus.DataSource = res;
        }
        private void addDataGridView()
        {
            dgv.DataSource = null;
            dgv.DataSource = roomDetailVM.ListStatusTime;
            dgv.Columns["IdStatim"].Visible = false;
            dgv.Columns["IdStatus"].Visible = false;
        }
        private void LoadData()
        {
            roomDetailVM = _detailRoomManageFacade.FindByID(idRoom);
            tb_RoomName.Text = roomDetailVM.RoomName;
            tb_RoomDescription.Text = roomDetailVM.RoomDescription;
            addDataGridView();
            for (int i = 0; i < cbb_RoomType.Items.Count; i++)
            {
                CbbItem cbbItem = (CbbItem)cbb_RoomType.Items[i];
                if (cbbItem.text == roomDetailVM.RoTyName)
                {
                    cbb_RoomType.SelectedIndex = i;
                    break;
                }
            }
        }



        //---------- EVENTS ----------//
        //----- tbllaypn_ControlButtons -----//
        private void btn_Add_Click(object sender, EventArgs e)
        {
            StatusTimeVM statusTimeVM = new StatusTimeVM
            {
                StatimFromdate = dtp_From.Value,
                StatimTodate = dtp_To.Value,
                IdStatus = ((CbbItem)cbb_RoomStatus.SelectedItem).Value,
                StaName = ((CbbItem)cbb_RoomStatus.SelectedItem).text
            };
            roomDetailVM.ListStatusTime.Add(statusTimeVM);
            addDataGridView();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv.SelectedRows;
            if (r.Count == 0) MessageBox.Show("Please choose at least one row to delete!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                foreach (DataGridViewRow val in r)
                {
                    int id = Int32.Parse(val.Cells["IdStatim"].Value.ToString());
                    int i = val.Index;
                    roomDetailVM.ListStatusTime.RemoveAt(i);
                    if (id != 0) listdel.Add(id);
                }
            }
            addDataGridView();
        }

        //----- tbllaypn_ControlButtons -----//
        private void btn_OK_Click(object sender, EventArgs e)
        {
            roomDetailVM.RoomName = tb_RoomName.Text;
            roomDetailVM.RoomDescription = tb_RoomDescription.Text;
            roomDetailVM.IdRoomType = ((CbbItem)cbb_RoomType.SelectedItem).Value;
            if (idRoom != 0)  { _detailRoomManageFacade.EditRoom(roomDetailVM, listdel); }
            else  { _detailRoomManageFacade.AddRoom(roomDetailVM); }
            myDel();
            this.Dispose();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset data
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            myDel();
            this.Dispose();
        }
    }
}
