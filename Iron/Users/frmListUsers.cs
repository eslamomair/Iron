using Iron_Bussness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iron.Users
{
    public partial class frmListUsers : Form
    {
        private static DataTable _dtAllUsers;
        public frmListUsers()
        {
            InitializeComponent();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _dtAllUsers= clsUsers.GetAllUsers();
            dgvListAllUsers.DataSource= _dtAllUsers;
            cbFilterBy.SelectedIndex=0;
            lblRecordCount.Text = dgvListAllUsers.Rows.Count.ToString();

            if (dgvListAllUsers.Rows.Count >0)
            {
                dgvListAllUsers.Columns[0].HeaderText = "User ID";
                dgvListAllUsers.Columns[0].Width = 90;

                 dgvListAllUsers.Columns[1].HeaderText = "Person ID";
                dgvListAllUsers.Columns[1].Width = 90;

                 dgvListAllUsers.Columns[2].HeaderText = "Full Name";
                dgvListAllUsers.Columns[2].Width = 170;

                 dgvListAllUsers.Columns[3].HeaderText = "User Name";
                dgvListAllUsers.Columns[3].Width = 130;

                 dgvListAllUsers.Columns[4].HeaderText = "Is Active";
                dgvListAllUsers.Columns[4].Width = 90;



            }
        }

        private void cbFitlyBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text ==  "Is Active")
            {
                txtFilterValues.Visible = false;
                cbFilterIsActive.Visible = true;
                cbFilterIsActive.Focus();
                cbFilterIsActive.SelectedIndex = 0;

            }
            else
            {

                txtFilterValues.Visible = (cbFilterBy.Text != "None");
                cbFilterIsActive.Visible = false;

                txtFilterValues.Text = "";
                txtFilterValues.Focus();

            }
        }

        private void txtFilterValues_TextChanged(object sender, EventArgs e)
        {
            string ColumnFilter = "";

            switch (cbFilterBy.Text)
            {
                case "User ID":
                    ColumnFilter = "ID";
                    break;
                case "User Name":
                    ColumnFilter = "UserName";
                    break;
                case "Person ID":
                    ColumnFilter = "PersonID"
                        ; break;
                case "Full Name":
                    ColumnFilter = "FullName";
                    break;
                default:
                    ColumnFilter = "None";
                    break;
            }

            if (txtFilterValues.Text.Trim() == "" || ColumnFilter == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvListAllUsers.Rows.Count.ToString();
                return;
            }

            if (ColumnFilter == "PersonID" || ColumnFilter ==  "ID")
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnFilter, txtFilterValues.Text.Trim());
                lblRecordCount.Text = dgvListAllUsers.Rows.Count.ToString();
            }
            else
            {
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", ColumnFilter, txtFilterValues.Text.Trim());
                lblRecordCount.Text = dgvListAllUsers.Rows.Count.ToString();
            }

        }

        private void cbFilterIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = "";

            switch (cbFilterIsActive.Text)
            {
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
                default:
                    FilterValue = "All";
                    break;
            }

            if (FilterValue == "All")
            {
                _dtAllUsers.DefaultView.RowFilter = "";

            }
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] ={1}", FilterColumn, FilterValue);
            lblRecordCount.Text = dgvListAllUsers.Rows.Count.ToString();
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserInfo((int)dgvListAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tsmAddNewUser_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdateUser();
            form.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void tsmEditUser_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdateUser((int)dgvListAllUsers.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void tsmDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure u Want Delete The User","Deleting",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsUsers.DeleteUser((int)dgvListAllUsers.CurrentRow.Cells[0].Value))
                {
                    if (clsPeoples.DeletePerson((int)dgvListAllUsers.CurrentRow.Cells[1].Value))
                    {
                        MessageBox.Show("Success Deleting");
                    }
                    else
                        MessageBox.Show("Error,Cant' Delete User Information Some Data is Used");
                }
                else
                    MessageBox.Show("Can't Delete The User");
            }
        }

        private void txtFilterValues_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
