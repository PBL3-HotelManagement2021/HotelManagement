using PBL3REAL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBL3REAL.View
{
    public partial class Form_HRM : Form
    {
        private QLUserBLL qLUserBLL;
        private string search = "";
        private string orderBy = "";

        private List<Button> listButton;
        public Form_HRM()
        {
            InitializeComponent();
            qLUserBLL = new QLUserBLL();
            cbb_HRMSort.SelectedIndex = 0;
            cbb_HRMStatus.SelectedIndex = 0;
            listButton = new List<Button>()
            {
                USER_ACTIVE,USER_ADD,USER_INACTIVE,USER_UPDATE,USER_VIEW
            };
            Authorization();
        }

        private void Authorization()
        {
            List<string> listAction = QLUserBLL.stoUser.ListRole.Where(x => x.IsSelected == true).FirstOrDefault().ActionList;
            foreach (var button in listButton)
            {
                string idbutton = button.Name.ToString();
                if (listAction.Contains(idbutton)) button.Enabled = true;
            }
        }


        private void loadDtbUser()
        {
            dgv_HRM.DataSource = null;
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("name", search);
            properties.Add("status", cbb_HRMStatus.SelectedItem.ToString());
            dgv_HRM.DataSource = qLUserBLL.findByProperty(properties, orderBy);
            dgv_HRM.Columns["IdUser"].Visible = false;
            dgv_HRM.Columns["UserPassword"].Visible = false;
            dgv_HRM.Columns["UserActiveflag"].Visible = false;
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void picbx_HRMSearch_Click(object sender, EventArgs e)
        {
            search = tb_HRMSearch.Text;
            orderBy = cbb_HRMSort.SelectedItem.ToString();
            loadDtbUser();
        }
        private void btn_HRMAdd_Click(object sender, EventArgs e)
        {
            Form_User_Profile f = new Form_User_Profile(0, "", true, false);
            f.myDel = loadDtbUser;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btn_HRMView_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_HRM.SelectedRows;
            if (r.Count == 1)
            {
                Form_User_Profile f = new Form_User_Profile(int.Parse(r[0].Cells["IdUser"].Value.ToString()),"", false,false);
                f.myDel = loadDtbUser;
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
        private void btn_HRMEdit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_HRM.SelectedRows;
            if (r.Count == 1)
            {
                if (bool.Parse(r[0].Cells["UserActiveflag"].Value.ToString()))
                {
                    Form_User_Profile f = new Form_User_Profile(int.Parse(r[0].Cells["IdUser"].Value.ToString()), "", true, false);
                    f.myDel = loadDtbUser;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Can't update inactive user!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btn_HRMDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_HRM.SelectedRows;
            if (r.Count == 1)
            {
                qLUserBLL.delUser(int.Parse(r[0].Cells["IdUser"].Value.ToString()));
                loadDtbUser();
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Please choose 1 row to delete", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Only one row can be choosed while deleting!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_HRMRestore_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv_HRM.SelectedRows;
            if (r.Count == 1)
            {
                qLUserBLL.restoreUser(int.Parse(r[0].Cells["IdUser"].Value.ToString()));
                loadDtbUser();
            }
            else if (r.Count == 0)
            {
                MessageBox.Show("Please choose 1 row to delete", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Only one row can be choosed while deleting!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
