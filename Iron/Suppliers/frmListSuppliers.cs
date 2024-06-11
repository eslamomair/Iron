using Iron.Customers;
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

namespace Iron.Suppliers
{
    public partial class frmListSuppliers : Form
    {
        private int PeopleID = -1;
        private static DataTable _dtAllSuppliers = clsSuppliers.GetAllInfoSuppliers();
        private DataTable _dtSuppliers = _dtAllSuppliers.DefaultView.ToTable
            (false, "ID", "FirstName", "SecondName", "ThirdName", "LastName", "NationalN",
            "Phone", "Email", "Address", "ImagePath");

        public frmListSuppliers()
        {
            InitializeComponent();
        }

        private void frmListSuppliers_Load(object sender, EventArgs e)
        {
            txtFilterValue.Visible = false;
            dgvListAllSuppliers.DataSource = _dtSuppliers;

            if (dgvListAllSuppliers.Rows.Count > 0)
            {
                dgvListAllSuppliers.Columns[0].HeaderText = "ID";
                dgvListAllSuppliers.Columns[0].Width = 50;

                dgvListAllSuppliers.Columns[1].HeaderText = "First Name";
                dgvListAllSuppliers.Columns[1].Width = 150;

                dgvListAllSuppliers.Columns[2].HeaderText = "Second Name";
                dgvListAllSuppliers.Columns[2].Width = 150;

                dgvListAllSuppliers.Columns[3].HeaderText = "Third Name";
                dgvListAllSuppliers.Columns[3].Width = 150;

                dgvListAllSuppliers.Columns[4].HeaderText = "Last Name";
                dgvListAllSuppliers.Columns[4].Width = 150;
                 
                dgvListAllSuppliers.Columns[5].HeaderText = "National N";
                dgvListAllSuppliers.Columns[5].Width = 170;
                 
                dgvListAllSuppliers.Columns[6].HeaderText = "Phone";
                dgvListAllSuppliers.Columns[6].Width = 170;
                 
                dgvListAllSuppliers.Columns[7].HeaderText = "Email";
                dgvListAllSuppliers.Columns[7].Width = 190;
                 
                dgvListAllSuppliers.Columns[8].HeaderText = "Address";
                dgvListAllSuppliers.Columns[8].Width = 400;

                dgvListAllSuppliers.Columns[9].HeaderText = "Image Path";
                dgvListAllSuppliers.Columns[9].Width = 250;

            }

            lblRecordes.Text = dgvListAllSuppliers.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.SelectedIndex != 0);
            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();

            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnFilter = "";

            switch (cbFilterBy.Text)
            {

                case "Suppliers ID":
                    ColumnFilter = "ID";
                    break;
                case "First Name":
                    ColumnFilter = "FirstName";
                    break;
                case "Last Name":
                    ColumnFilter = "LastName";
                    break;
                case "National N":
                    ColumnFilter = "NationalN";
                    break;
                case "Phone":
                    ColumnFilter = "Phone";
                    break;
                case "Address":
                    ColumnFilter = "Address";
                    break;
                case "Email":
                    ColumnFilter = "Email";
                    break;
                default:
                    ColumnFilter = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || ColumnFilter == "None")
            {
                _dtSuppliers.DefaultView.RowFilter = "";
                lblRecordes.Text = dgvListAllSuppliers.Rows.Count.ToString();
                return;
            }

            if (ColumnFilter == "ID")
            {
                _dtSuppliers.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnFilter, txtFilterValue.Text.Trim());
            }
            else
                _dtSuppliers.DefaultView.RowFilter = string.Format("[{0}] Like '%{1}%'", ColumnFilter, txtFilterValue.Text.Trim());

            lblRecordes.Text = dgvListAllSuppliers.Rows.Count.ToString();
        }

        private void dgvListAllSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = new frmSuppliersDetails(int.Parse(dgvListAllSuppliers.CurrentRow.Cells[0].Value.ToString()));
            form.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmSuppliersDetails(int.Parse(dgvListAllSuppliers.CurrentRow.Cells[0].Value.ToString()));
            form.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
            AddNewSuppliersWithDataBack();
        }

        private void Frm_DataBack(object sender, int PersonID)
        {
           this.PeopleID = PersonID;
        }

        private void AddNewSuppliersWithDataBack()
        {
            if (PeopleID > 0)
            {
                clsSuppliers clsSuppliers = new clsSuppliers();
                clsSuppliers.PersonID = PeopleID;
                clsSuppliers.CreatedByUserID = 1;
                if (clsSuppliers.Save())
                {
                    MessageBox.Show("Data Saved");
                }
                else
                    MessageBox.Show("Data not Saved");
            }
        }

        private void btnAddNewSuppliers_Click(object sender, EventArgs e)
        {
            addNewCustomerToolStripMenuItem_Click(this, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(_dtAllSuppliers.Rows[dgvListAllSuppliers.CurrentRow.Index]["PersonID"].ToString());
            frmAddUpdatePeople frm = new frmAddUpdatePeople(PersonID);
            frm.ShowDialog();
            _Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Sure You Want Delete this Person [{ dgvListAllSuppliers.CurrentRow.Cells[0].Value.ToString()} ]", "Deleting",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                int PeopleID = int.Parse(_dtAllSuppliers.Rows[dgvListAllSuppliers.CurrentRow.Index]["PersonID"].ToString());
                if (clsSuppliers.DeleteSuppliersByID(int.Parse(dgvListAllSuppliers.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Delete Successfully");
                }
                else
                    MessageBox.Show("Delete Fail");

            }
            _Refresh();
        }

        private void _Refresh()
        {
            _dtSuppliers = _dtAllSuppliers.DefaultView.ToTable
            (false, "ID", "FirstName", "SecondName", "ThirdName", "LastName", "NationalN",
            "Phone", "Email", "Address", "ImagePath");

            dgvListAllSuppliers.DataSource = _dtSuppliers;

            lblRecordes.Text = dgvListAllSuppliers.Rows.Count.ToString();
        }

        private void sendMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Suppliers ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "Put the mouse to Read The Error");
            }
            else
                errorProvider1.SetError(txtFilterValue, null);
        }
    }
}
