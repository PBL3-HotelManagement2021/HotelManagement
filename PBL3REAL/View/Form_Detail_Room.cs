using HotelManagement.BBL.Implement;
using HotelManagement.BLL.Implement;
using HotelManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class Form_Detail_Room : Form
    {
        private int idRoom;
        private RoomBLL _roomBLL;
        private RoomTypeBLL _roomTypeBLL;
        private RoomDetailVM roomDetailVM;
        private List<int> listdel;
        public Form_Detail_Room(int idRoom)
        {
            InitializeComponent();
            //this.idRoom = idRoom;
            //_roomBLL = new RoomBLL();
            //_roomTypeBLL = new RoomTypeBLL();
            //comboboxRoomType();
            //comboboxStatus();
            //if (idRoom != 0) loadData();
            //else roomDetailVM = new RoomDetailVM();
            //listdel = new List<int>();
        }

        //        private void addDataGridView()
        //        {
        //            dataGridView1.DataSource = null;
        //            dataGridView1.DataSource = roomDetailVM.ListStatusTime;
        //            dataGridView1.Columns["IdStatim"].Visible = false;
        //            dataGridView1.Columns["statusVM"].Visible = false;
        //            dataGridView1.Columns["IdStatus"].Visible = false;
        //        }


        //        private void loadData()
        //        {
        //            roomDetailVM = _roomBLL.findByID(idRoom);
        //            textBox1.Text = roomDetailVM.RoomName;
        //            textBox2.Text = roomDetailVM.RoomDescription;
        //            addDataGridView();
        //           /* if (dataGridView1.Columns["Status"] == null)
        //            {
        //                DataGridViewColumn newcol = new DataGridViewColumn();
        //                newcol.HeaderText = "Status";
        //                newcol.Name = "Status";
        //                DataGridViewCell cell = new DataGridViewTextBoxCell();
        //                cell.ValueType = typeof(string);
        //                newcol.CellTemplate = cell;
        //                newcol.Visible = true;
        //                dataGridView1.Columns.Add(newcol);
        //            }
        //            int j = 0;
        //            foreach(StatusTimeVM statusTimeVM in roomDetailVM.ListStatusTime)
        //            {
        //                dataGridView1.Rows[j].Cells["Status"].Value = statusTimeVM.statusVM.StaName;
        //            }
        //*/
        //            for (int i = 0; i < comboBox1.Items.Count; i++)
        //            {
        //                CbbItem cbbItem = (CbbItem)comboBox1.Items[i];
        //                if (cbbItem.text == roomDetailVM.RoTyName )
        //                {
        //                    comboBox1.SelectedIndex = i;
        //                    break;
        //                }
        //            }
        //        }

        //        private void comboboxRoomType()
        //        {
        //            List<CbbItem> res = _roomTypeBLL.addCombobox();
        //            comboBox1.DataSource = res;
        //        }
        //        private void comboboxStatus()
        //        {
        //            List<CbbItem> res = _roomBLL.addComboboxStatus();
        //            comboBox2.DataSource = res;
        //        }
        //Events
        private void btnadd_Click(object sender, EventArgs e)
        {
            //StatusTimeVM statusTimeVM = new StatusTimeVM
            //{
            //    StatimFromdate = dateTimePicker1.Value,
            //    StatimTodate = dateTimePicker2.Value,
            //    statusVM = new StatusVM()
            //};
            //statusTimeVM.statusVM.IdStatus = ((CbbItem)comboBox2.SelectedItem).Value;
            //statusTimeVM.StaName = ((CbbItem)comboBox2.SelectedItem).text;

            //roomDetailVM.ListStatusTime.Add(statusTimeVM);
            //addDataGridView();
            ///*     dataGridView1.Rows.Add(dateTimePicker1.Value, dateTimePicker2.Value, ((CbbItem)comboBox1.SelectedItem).Value);*/
        }
        private void btnOke_Click(object sender, EventArgs e)
        {
            //roomDetailVM.RoomName = textBox1.Text;
            //roomDetailVM.RoomDescription = textBox2.Text;
            //roomDetailVM.IdRoomType = ((CbbItem)comboBox1.SelectedItem).Value;
            //if (idRoom != 0)
            //{

            //    _roomBLL.editRoom(roomDetailVM, listdel);
            //}
            //else
            //{
            //    _roomBLL.addRoom(roomDetailVM);
            //}

            //this.Dispose();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            //DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            //if (r.Count == 0) MessageBox.Show("Please choose rows to delete !!!");
            //else
            //{
            //    foreach (DataGridViewRow val in r)
            //    {
            //        int id = Int32.Parse(val.Cells["IdStatim"].Value.ToString());
            //        int i = val.Index;
            //        roomDetailVM.ListStatusTime.RemoveAt(i);
            //        if (id != 0) listdel.Add(id);
            //    }
            //}
            //addDataGridView();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
